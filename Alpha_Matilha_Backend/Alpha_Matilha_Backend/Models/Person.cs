using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Alpha_Matilha_Backend.Models
{
    public class Person
    {
        [Key]
        public int ID_Person { get; set; }
        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public string Whatsapp { get; set; }
        public int Classification { get; set; }

        public DateTime Registration_Date { get; set; }

        public char SEX { get; set; }

        public Person()
        {
            Dog = new Collection<Dog>();
        }

        public ICollection<Dog> Dog { get; set; }
    }
}
