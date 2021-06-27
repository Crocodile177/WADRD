using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Country
    {
        [Key]
        [Range(0, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string President { get; set; }

        [Required]
        public string Capital { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Founded { get; set; }

        [Required]
        public string Currency { get; set; }

        public virtual ICollection<City> City { get; set; }
    }

}