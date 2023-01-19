using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Alpha_Matilha_Backend.Models
{
    public class Address_Person
    {
        [Key]
        public int ID_Address { get; set; }

        public int ID_Person { get; set; }

        public string Name_Street { get; set; }

        public int Number_Home { get; set; }

        public string District { get; set; }

        public string Zip_Code { get; set; }

        public string City { get; set; }

        public string UF { get; set; }
    }
}

