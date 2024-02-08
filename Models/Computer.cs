using AppModel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppModel.Models
{
    public class Computer
    {
        public Computer()
        {
            Name = "Default Computer Name";
            Processor = "Default Processor";
            DateOfProduction = new DateTime(2024, 1, 1);
            ComputersGraphics = new HashSet<ComputersGraphics>();
        }

        [Key]
        public int ComputerId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set;}

        [Required(ErrorMessage = "MemoryRam is required.")]
        [Range(1, 256, ErrorMessage = "Memory RAM must be between 1 and 256 GB.")]
        public int MemoryRam { get; set; }

        [Required(ErrorMessage = "MemoryDisk is required.")]
        [Range(128, 8192, ErrorMessage = "Memory Disk must be between 128 and 8192 GB.")]
        public int MemoryDisk { get; set; }

        [Required(ErrorMessage = "Processor is required.")]
        [StringLength(50, ErrorMessage = "Processor cannot exceed 50 characters.")]
        public string Processor { get; set; }

        [Required(ErrorMessage = "Date of Production is required.")]
        [DataType(DataType.Date)]
        public DateTime DateOfProduction { get; set; }

        public int? ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public virtual Producer? Producer { get; set; }
        public virtual ICollection<ComputersGraphics> ComputersGraphics { get; set; }
    }
}
