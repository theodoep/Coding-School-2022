using Classes.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public async Task Create(Employee entity)
        {
            using var context = new EmployeeContext();
            context.Employees.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new EmployeeContext();
            var foundEmployee = context.Employees.SingleOrDefault(emp => emp.ID == id);
            if (foundEmployee is null)
                return;

            context.Employees.Remove(foundEmployee);
            await context.SaveChangesAsync();
        }

       

        public List<Employee> GetAll()
        {
            using var context = new EmployeeContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(Guid id)
        {
            using var context = new EmployeeContext();
            return context.Employees.Where(emp => emp.ID == id).SingleOrDefault();
        }


        public async Task Update(Guid id, Employee entity)
        {
            using var context = new EmployeeContext();
            var foundEmployee = context.Employees.Include(emp => emp.Detail).SingleOrDefault(emp => emp.ID == id);
            if (foundEmployee is null)
                return;
            if (!foundEmployee.Finished && entity.Finished)
            {
                foundEmployee.Detail.FinishDate = DateTime.Now;
            }
            foundEmployee.Finished = entity.Finished;
            foundEmployee.Title = entity.Title;
            await context.SaveChangesAsync();
        }

       
    }



}
