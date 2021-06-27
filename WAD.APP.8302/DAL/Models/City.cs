using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class City
    {
        [Key]
        [Range(0, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Population { get; set; }

        [Required]
        public string Mayor { get; set; }

        [Required]
        public bool IsCapital { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}