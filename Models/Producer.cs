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
            Name = "Default Producer Name";
            Address = "Default Address";
            Computers = new HashSet<Computer>();
        }

        [Key]
        public int ProducerId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(150, ErrorMessage = "Name cannot exceed 150 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Year Founded is required.")]
        [Range(1900, 2024, ErrorMessage = "Year Founded must be between 1900 and 2024.")]
        public int YearFounded { get; set; }

        public virtual ICollection<Computer> Computers { get; set; }
    }
}
