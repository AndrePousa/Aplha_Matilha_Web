using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Aplication.DTOs
{
    internal class DogDTO
    {
        public int ID_Dog { get; set; }

        public int? ID_Client { get; set; }

        public int? ID_Trainer { get; set; }

        public string? Name { get; set; }

        public string? Breed { get; set; }

        public int? Age { get; set; }

        public DateTime? Start_Training { get; set; }

        public string? Note { get; set; }

        public bool? Active { get; set; }

        public DateTime? End_Of_The_Contract { get; set; }

        public string? ImagemUrl { get; set; }
    }
}
