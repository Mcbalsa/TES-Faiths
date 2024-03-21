using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    namespace API.Models
    {
        public class Divine
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int id { get; set; }

            public string name { get; set; }
        
            public string description { get; set; }
        
            public List<Divine> aliases { get; set; }

            public Pantheon pantheon { get; set; }

        }
    }
