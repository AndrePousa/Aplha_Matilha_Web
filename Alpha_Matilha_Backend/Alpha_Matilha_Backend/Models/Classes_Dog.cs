using System.ComponentModel.DataAnnotations;

namespace Alpha_Matilha_Backend.Models
{
    public class Classes_Dog
    {
        [Key]
        public int ID_Class { get; set; }

        public int ID_Dog { get; set; }

        public DateTime Registration_Class { get; set; }

        public byte Confirmed { get; set; }
    }
}
