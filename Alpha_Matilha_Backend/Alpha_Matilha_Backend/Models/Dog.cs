using System.ComponentModel.DataAnnotations;

namespace Alpha_Matilha_Backend.Models
{
    public class Dog
    {
        [Key]
        public int ID_Dog { get; set; }

        public int ID_Client { get; set; }

        public int ID_Trainer { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime Start_Training { get; set; }

        public string Note { get; set; }

        public byte Active { get; set; }

        public DateTime End_Of_The_Contract { get; set; }
    }

}
