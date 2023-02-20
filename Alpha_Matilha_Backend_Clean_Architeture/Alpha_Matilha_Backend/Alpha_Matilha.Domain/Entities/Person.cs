using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Domain.Entities
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
    }
}
