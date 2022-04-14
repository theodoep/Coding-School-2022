using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("controller")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        //private readonly IEntityRepo<Commenter> _commenterRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListViewModel>> Get()
        {
            var result = await _employeeRepo.GetAllAsync();
            return result.Select(x => new EmployeeListViewModel
            {
                ID = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                EmployeeType = x.EmployeeType,
                HireDateEnd = x.HireDateEnd,
                HireDateStart = x.HireDateStart,
                SalaryPerMonth = x.SalaryPerMonth
            });
        }
        [HttpGet("{id}")]
        public async Task<EmployeeEditViewModel> Get(Guid id)
        {
            EmployeeEditViewModel model = new();
            if (id != null)
            {
                var existing = await _employeeRepo.GetByIdAsync(id);
                model.ID = existing.ID;
                model.Name = existing.Name;
                model.Surname = existing.Surname;
                model.EmployeeType = existing.EmployeeType;
                model.SalaryPerMonth = existing.SalaryPerMonth;
                model.HireDateStart = existing.HireDateStart;
                model.HireDateEnd = existing.HireDateEnd;


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
            await _employeeRepo.DeleteAsync(id);
        }



        [HttpPost]
        public async Task Post(EmployeeEditViewModel employee)
        {
            var newEmployee = new Employee()
            {
                ID = employee.ID,
                Surname = employee.Surname,
                Name = employee.Name,
                EmployeeType = employee.EmployeeType,
                SalaryPerMonth = employee.SalaryPerMonth,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,


            };
            //foreach (var comment in customer.Comments)
            //{
            //    newCustomer.Comments.Add(new CustomerComment(comment.Text)
            //    {
            //        CommenterId = comment.CommenterId
            //    });
            //}
            await _employeeRepo.AddAsync(newEmployee);
        }

        [HttpPut]
        public async Task<ActionResult> Put(EmployeeEditViewModel employee)
        {
            var itemToUpdate = await _employeeRepo.GetByIdAsync(employee.ID);
            if (itemToUpdate == null) return NotFound();

            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
            itemToUpdate.EmployeeType = employee.EmployeeType;
            itemToUpdate.HireDateStart = employee.HireDateStart;
            itemToUpdate.HireDateEnd = employee.HireDateEnd;   
            itemToUpdate.SalaryPerMonth = employee.SalaryPerMonth;

            //itemToUpdate.Comments = customer.Comments.Select(comment => new CustomerComment(comment.Text)
            //{
            //    Id = comment.Id,
            //    CommenterId = comment.CommenterId
            //}).ToList();

            await _employeeRepo.UpdateAsync(employee.ID, itemToUpdate);

            return Ok();
        }
    }
}
