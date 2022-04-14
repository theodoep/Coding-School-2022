using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        private readonly FuelStationContext context;

        public TransactionRepo(FuelStationContext dbContext)
        {
            context = dbContext;
        }

        public async Task AddAsync(Transaction entity)
        {
            AddLogic(entity, context);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            DeleteLogic(id, context);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await context.Transactions.ToListAsync();
        }

        public async Task<Transaction?> GetByIdAsync(Guid id)
        {
            return await context.Transactions.SingleOrDefaultAsync(transaction => transaction.ID == id);
        }

        public async Task UpdateAsync(Guid id, Transaction entity)
        {
            UpdateLogic(id, entity, context);
            await context.SaveChangesAsync();
        }

        private void AddLogic(Transaction entity, FuelStationContext context)
        {
            if (entity.ID != null)
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            context.Transactions.Add(entity);
        }
        private void DeleteLogic(Guid id, FuelStationContext context)
        {
            var dbTransaction = context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (dbTransaction is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            context.Transactions.Remove(dbTransaction);
        }
        private void UpdateLogic(Guid id, Transaction entity, FuelStationContext context)
        {
            var dbTransaction = context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (dbTransaction is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            dbTransaction.Date = entity.Date;
            dbTransaction.CustomerID = entity.CustomerID;
            dbTransaction.EmployeeID = entity.EmployeeID;
        }
    }
}
