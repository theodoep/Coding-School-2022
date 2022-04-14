

using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {

        private readonly FuelStationContext context;



        public CustomerRepo(FuelStationContext dbContext)
        {
            context = dbContext;
        }


        public async Task AddAsync(Customer entity)
        {

            AddLogic(entity, context);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            DeleteLogic(id, context);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await context.Customers.ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(Guid id)
        {
            return await context.Customers.SingleOrDefaultAsync(customer => customer.ID == id);
        }

        public async Task UpdateAsync(Guid id, Customer entity)
        {
            UpdateLogic(id, entity, context);
            await context.SaveChangesAsync();
        }





        private void AddLogic(Customer entity, FuelStationContext context)
        {
            if (entity.ID != Guid.Empty)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Customers.Add(entity);
        }


        private void DeleteLogic(Guid id, FuelStationContext context)
        {
            var dbCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (dbCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Customers.Remove(dbCustomer);
        }

        private void UpdateLogic(Guid id, Customer entity, FuelStationContext context)
        {
            var dbCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (dbCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            dbCustomer.CardNumber = entity.CardNumber;
           
        }
    }
}
