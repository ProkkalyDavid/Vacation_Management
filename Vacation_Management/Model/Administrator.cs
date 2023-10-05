using System.ComponentModel.DataAnnotations;

namespace Vacation_Management.Model
{
    public class Administrator
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
