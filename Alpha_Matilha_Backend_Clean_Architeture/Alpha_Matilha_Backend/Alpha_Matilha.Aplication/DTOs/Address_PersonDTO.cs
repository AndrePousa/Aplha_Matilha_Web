using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Aplication.DTOs
{
    public class Address_PersonDTO
    {
        public int ID_Address { get; set; }

        public int ID_Person { get; set; }

        public string? Name_Street { get; set; }

        public int Number_Home { get; set; }

        public string? District { get; set; }

        public string? Zip_Code { get; set; }

        public string? City { get; set; }

        public string? UF { get; set; }
    }
}
