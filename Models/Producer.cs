using AppModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppModel.Models
{
    public class Producer
    {
        public Producer()
        {
            Computers = new HashSet<Computer>();
        }

        [Key]
        public int ProducerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int YearFounded { get; set; }

        public virtual ICollection<Computer> Computers { get; set; }
    }
}
