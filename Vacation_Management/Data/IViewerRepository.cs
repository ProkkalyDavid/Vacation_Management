using Vacation_Management.Model;

namespace Vacation_Management.Data
{
    public interface IViewerRepository
    {
        void Create(Viewer viewer);
        void Delete(string name);
        IEnumerable<Viewer> Read();
        Viewer Read(string name);
        void Update(Viewer viewer);
    }
}