using System.ComponentModel.DataAnnotations;

namespace API.Models.DTO
{
    public class PantheonDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        // public List<Divine> Divines { get; set; }
    }
}
