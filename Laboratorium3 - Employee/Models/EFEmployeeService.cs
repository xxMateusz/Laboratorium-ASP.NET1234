using Data.Entities;
using Data;

namespace Laboratorium3___Employee.Models
{
    public class EFEmployeeService : IEmployeeService
    {
        private readonly AppDbContext context;

        public EFEmployeeService(AppDbContext context)
        {
            this.context = context;
        }

        public int Add(Employee employee)
        {
            var entry = context.Employees.Add(EmployeeMapper.GetEntityFromModel(employee));
            context.SaveChanges();
            int id = entry.Entity.EmployeeId;
            return id;
        }

        public void Delete(int id)
        {
            EmployeeEntity? entity = context.Employees.Find(id);
            if (entity is null) throw new Exception();

            context.Employees.Remove(entity);
            context.SaveChanges();
        }

        public List<Employee> FindAll()
        {
            return context.Employees.Select(entity => EmployeeMapper.GetModelFromEntity(entity)).ToList();
        }

        public Employee? FindById(int id)
        {
            EmployeeEntity? entity = context.Employees.Find(id);

            return entity is null ? null : EmployeeMapper.GetModelFromEntity(entity);
        }

        public void Update(Employee employee)
        {
            context.Employees.Update(EmployeeMapper.GetEntityFromModel(employee));
            context.SaveChanges();
        }
    }
}
