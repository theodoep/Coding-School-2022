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
            context.Todos.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            using var context = new EmployeeAppContext();
            var foundTodo = context.Todos.SingleOrDefault(emp => emp.Id == id);
            if (foundTodo is null)
                return;

            context.Todos.Remove(foundTodo);
            await context.SaveChangesAsync();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            using var context = new EmployeeAppContext();
            return context.Todos.ToList();
        }

        public Employee? GetById(int id)
        {
            using var context = new EmployeeAppContext();
            return context.Todos.Where(todo => todo.Id == id).SingleOrDefault();
        }

        public Employee? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id, Employee entity)
        {
            using var context = new EmployeeAppContext();
            var foundTodo = context.Todos.Include(todo => todo.Detail).SingleOrDefault(todo => todo.Id == id);
            if (foundTodo is null)
                return;
            if (!foundTodo.Finished && entity.Finished)
            {
                foundTodo.Detail.FinishDate = DateTime.Now;
            }
            foundTodo.Finished = entity.Finished;
            foundTodo.Title = entity.Title;
            await context.SaveChangesAsync();
        }

        public Task Update(Guid id, Employee entity)
        {
            throw new NotImplementedException();
        }

        List<Employee> IEntityRepo<Employee>.GetAll()
        {
            throw new NotImplementedException();
        }
    }



}
