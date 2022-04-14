using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        //private readonly IEntityRepo<Commenter> _commenterRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListViewModel>> Get()
        {
            var result = await _customerRepo.GetAllAsync();
            return result.Select(x => new CustomerListViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                CardNumber = x.CardNumber
            });
        }
        [HttpGet("{id}")]
        public async Task<CustomerEditViewModel> Get(Guid id)
        {
            CustomerEditViewModel model = new();
            if (id != Guid.Empty)
            {
                var existing = await _customerRepo.GetByIdAsync(id);
                model.ID = existing.ID;
                model.Name = existing.Name;
                model.Surname = existing.Surname;
                model.CardNumber = existing.CardNumber;
               
                //model.Comments = existing.Comments.Select(comment => new CustomerEditCommentViewModel
                //{
                //    Id = comment.Id,
                //    Text = comment.Text,
                //    CommenterId = comment.CommenterId
                //}).ToList();
            }

            //var commenters = await _commenterRepo.GetAllAsync();
            //model.Commenters = commenters.Select(x => new CustomerEditCommenterViewModel
            //{
            //    Id = x.Id,
            //    Name = x.Name
            //}).ToList();

            return model;
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _customerRepo.DeleteAsync(id);
        }



        [HttpPost]
        public async Task Post(CustomerEditViewModel customer)
        {
            var newCustomer = new Customer()
            {
                ID = customer.ID,
                Surname = customer.Surname,
                Name = customer.Name,
                CardNumber = customer.CardNumber,
                

            };
            //foreach (var comment in customer.Comments)
            //{
            //    newCustomer.Comments.Add(new CustomerComment(comment.Text)
            //    {
            //        CommenterId = comment.CommenterId
            //    });
            //}
            await _customerRepo.AddAsync(newCustomer);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CustomerEditViewModel customer)
        {
            var itemToUpdate = await _customerRepo.GetByIdAsync(customer.ID);
            if (itemToUpdate == null) return NotFound();

            itemToUpdate.Name = customer.Name;
            itemToUpdate.Surname = customer.Surname;
            itemToUpdate.CardNumber = customer.CardNumber;

            //itemToUpdate.Comments = customer.Comments.Select(comment => new CustomerComment(comment.Text)
            //{
            //    Id = comment.Id,
            //    CommenterId = comment.CommenterId
            //}).ToList();

            await _customerRepo.UpdateAsync(customer.ID, itemToUpdate);

            return Ok();
        }
    }
}


