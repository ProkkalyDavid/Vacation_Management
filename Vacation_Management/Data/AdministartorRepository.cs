using Vacation_Management.Model;

namespace Vacation_Management.Data
{
    public class AdministartorRepository : IAdministartorRepository
    {
        List<Administrator> administrators;

        public AdministartorRepository()
        {
            administrators = new List<Administrator>();
        }

        public void Create(Administrator administrator)
        {
            administrators.Add(administrator);
        }
        public IEnumerable<Administrator> Read()
        {
            return administrators;
        }
        public Administrator Read(string name)
        {
            return administrators.FirstOrDefault(t => t.Name == name);
        }
        public void Update(Administrator administrator)
        {
            var old = Read(administrator.Name);
            //promote, depromote, name, email
        }
        public void Delete(Administrator administrator)
        {
            var administratorToDelete = Read(administrator.Name);
            administrators.Remove(administratorToDelete);
        }
    }
}
