using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("controller")]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListViewModel>> Get()
        {
            var result = await _transactionRepo.GetAllAsync();
            return result.Select(x => new TransactionListViewModel
            {
                ID = x.ID,
                CustomerID = x.ID,
                EmployeeID = x.ID,
                Date = x.Date
               
            });
        }
        [HttpGet("{id}")]
        public async Task<TransactionEditViewModel> Get(Guid id)
        {
            TransactionEditViewModel model = new();
            if (id != null)
            {
                var existing = await _transactionRepo.GetByIdAsync(id);
                model.ID = existing.ID;
                model.CustomerID = existing.CustomerID;
                model.EmployeeID = existing.EmployeeID;
                model.Date = existing.Date;
            }

            return model;
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _transactionRepo.DeleteAsync(id);
        }



        [HttpPost]
        public async Task Post(TransactionEditViewModel transaction)
        {
            var newTransaction = new Transaction()
            {
                ID = transaction.ID,
                CustomerID = transaction.CustomerID,
                EmployeeID = transaction.EmployeeID,
                Date = transaction.Date,
            };

            await _transactionRepo.AddAsync(newTransaction);
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionEditViewModel transaction)
        {
            var itemToUpdate = await _transactionRepo.GetByIdAsync(transaction.ID);
            if (itemToUpdate == null) return NotFound();

            itemToUpdate.CustomerID = transaction.CustomerID;
            itemToUpdate.EmployeeID = transaction.EmployeeID;
            itemToUpdate.Date = transaction.Date;

            await _transactionRepo.UpdateAsync(transaction.ID, itemToUpdate);

            return Ok();
        }

    }
}
