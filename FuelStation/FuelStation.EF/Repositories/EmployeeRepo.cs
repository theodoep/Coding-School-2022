using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {   

    private readonly FuelStationContext context;



    public EmployeeRepo(FuelStationContext dbContext)
    {
        context = dbContext;
    }


    public async Task AddAsync(Employee entity)
    {

        AddLogic(entity, context);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        DeleteLogic(id, context);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        return await context.Employees.ToListAsync();
    }

    public async Task<Employee?> GetByIdAsync(Guid id)
    {
        return await context.Employees.SingleOrDefaultAsync(emp => emp.ID == id);
    }

    public async Task UpdateAsync(Guid id, Employee entity)
    {
        UpdateLogic(id, entity, context);
        await context.SaveChangesAsync();
    }





    private void AddLogic(Employee entity, FuelStationContext context)
    {
        if (entity.ID != null)
            throw new ArgumentException("Given entity should not have Id set", nameof(entity));

        context.Employees.Add(entity);
    }


    private void DeleteLogic(Guid id, FuelStationContext context)
    {
        var dbEmployee = context.Employees.SingleOrDefault(emp => emp.ID == id);
        if (dbEmployee is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");

        context.Employees.Remove(dbEmployee);
    }

    private void UpdateLogic(Guid id, Employee entity, FuelStationContext context)
    {
        var dbEmployee = context.Employees.SingleOrDefault(emp => emp.ID == id);
        if (dbEmployee is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        dbEmployee.Name = entity.Name;
        dbEmployee.Surname = entity.Surname;
        dbEmployee.HireDateStart = entity.HireDateStart;
        dbEmployee.HireDateEnd = entity.HireDateEnd;
        dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;
        dbEmployee.EmployeeType = entity.EmployeeType;
    }
  }
}
