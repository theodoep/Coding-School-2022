using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class ItemRepo : IEntityRepo<Item>
    {
        private readonly FuelStationContext context;



        public ItemRepo(FuelStationContext dbContext)
        {
            context = dbContext;
        }


        public async Task AddAsync(Item entity)
        {

            AddLogic(entity, context);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            DeleteLogic(id, context);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await context.Items.ToListAsync();
        }

        public async Task<Item?> GetByIdAsync(Guid id)
        {
            return await context.Items.SingleOrDefaultAsync(item => item.ID == id);
        }

        public async Task UpdateAsync(Guid id, Item entity)
        {
            UpdateLogic(id, entity, context);
            await context.SaveChangesAsync();
        }





        private void AddLogic(Item entity, FuelStationContext context)
        {
            if (entity.ID != Guid.Empty)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Items.Add(entity);
        }


        private void DeleteLogic(Guid id, FuelStationContext context)
        {
            var dbItem = context.Items.SingleOrDefault(item => item.ID == id);
            if (dbItem is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Items.Remove(dbItem);
        }

        private void UpdateLogic(Guid id, Item entity, FuelStationContext context)
        {
            var dbItem = context.Items.SingleOrDefault(item => item.ID == id);
            if (dbItem is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            dbItem.Code = entity.Code;
            dbItem.Description = entity.Description;
            dbItem.ItemType = entity.ItemType;
            dbItem.Price = entity.Price;
            dbItem.Cost = entity.Cost;

        }
    }
}
