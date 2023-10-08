using Vacation_Management.Model;

namespace Vacation_Management.Data
{
    public interface IEmployeeRepository
    {
        void Create(Employee employee);
        void Delete(Employee employee);
        IEnumerable<Employee> Read();
        Employee Read(string name);
        void Update(Employee employee);
    }
}