using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Aplication.DTOs
{
    internal class Classes_DogDTO
    {
        public int ID_Class { get; set; }

        public int ID_Dog { get; set; }

        public DateTime Registration_Class { get; set; }

        public byte Confirmed { get; set; }
    }
}
