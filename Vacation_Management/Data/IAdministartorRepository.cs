using Vacation_Management.Model;

namespace Vacation_Management.Data
{
    public interface IAdministartorRepository
    {
        void Create(Administrator administrator);
        void Delete(Administrator administrator);
        IEnumerable<Administrator> Read();
        Administrator Read(string name);
        void Update(Administrator administrator);
    }
}