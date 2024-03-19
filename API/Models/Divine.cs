using System.ComponentModel.DataAnnotations;

    namespace API.Models
    {
        public class Divine
        {
            public int id { get; set; }

            public string name { get; set; }
        
            public string description { get; set; }
        
            public List<Divine> aliases { get; set; }

            public Pantheon pantheon { get; set; }

        }
    }
