using Data.Entities;

namespace Laboratorium3___Employee.Models
{
    public class EmployeeMapper
    {
        public static EmployeeEntity GetEntityFromModel(Employee contact)
        {
            return new EmployeeEntity()
            {
                EmployeeId = contact.Id,
                Pesel = contact.Pesel,
                Name = contact.Name,
                Surname = contact.Surname,
                EmploymentDate = contact.EmploymentDate,
                SackingDate = contact.SackingDate,
                Position = (int)contact.Position,
                Department = (int)contact.Department
            };
        }

        public static Employee GetModelFromEntity(EmployeeEntity entity)
        {
            return new Employee()
            {
                Id = entity.EmployeeId,
                Pesel = entity.Pesel,
                Name = entity.Name,
                Surname = entity.Surname,
                EmploymentDate = entity.EmploymentDate,
                SackingDate = entity.SackingDate,
                Position = (Positions)entity.Position,
                Department = (Departments)entity.Department
            };
        }
    }
}
