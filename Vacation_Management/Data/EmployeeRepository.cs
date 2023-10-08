using Vacation_Management.Model;

namespace Vacation_Management.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> employees;

        public EmployeeRepository()
        {
            employees = new List<Employee>();
        }

        public void Create(Employee employee)
        {
            employees.Add(employee);
        }
        public IEnumerable<Employee> Read()
        {
            return employees;
        }
        public Employee Read(string name)
        {
            return employees.FirstOrDefault(t => t.Name == name);
        }
        public void Update(Employee employee)
        {
            var old = Read(employee.Name);
            //promote, depromote, name, email
        }
        public void Delete(Employee employee)
        {
            var employeeToDelete = Read(employee.Name);
            employees.Remove(employeeToDelete);
        }
    }
}
