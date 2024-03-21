using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Divine
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Pantheon Pantheon { get; set; }
        public int PantheonId { get; set; }

    }
}
