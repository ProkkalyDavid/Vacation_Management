using System.Drawing;
using Vacation_Management.Model;

namespace Vacation_Management.Data
{
    public class ViewerRepository
    {
        List<Viewer> viewers;
        public ViewerRepository()
        {
            viewers = new List<Viewer>();
        }

        public void Create(Viewer viewer)
        {
            viewers.Add(viewer);
        }
        public IEnumerable<Viewer> Read()
        {
            return viewers;
        }
        public Viewer Read(string name)
        {
            return viewers.FirstOrDefault(t => t.Name == name);
        }
        public void Update(Viewer viewer)
        {
            var old = Read(viewer.Name);
            //promote, new email, name, etc
        }
        public void Delete(string name)
        {
            var viewer = Read(name);
            viewers.Remove(viewer);
        }
    }
}
