using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
    {
        public class Pantheon
        {

            public int Id { get; set; }

            [StringLength(50)]
            public string Name { get; set; }

            //public List<Divine> Divines { get; set; }
    }
    }
