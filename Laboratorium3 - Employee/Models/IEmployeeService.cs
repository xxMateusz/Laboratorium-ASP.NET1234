namespace Laboratorium3___Employee.Models
{
    public interface IEmployeeService
    {
        int Add(Employee book);
        void Delete(int id);
        void Update(Employee book);
        List<Employee> FindAll();
        Employee? FindById(int id);
    }
}
