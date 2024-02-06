using AppModel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppModel.Models
{
    public class Computer
    {
        public Computer()
        {
            ComputerProcessors = new HashSet<ComputerProcessor>();
        }

        [Key]
        public int ComputerId { get; set; }

        public string ComputerName { get; set;}

        public int MemoryRam { get; set; }

        public int MemoryDisk { get; set; }

        public string GraphicsCard { get; set; }
        public DateTime DateOfProduction { get; set; }

        public int? ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public virtual Producer? Producer { get; set; }
        public virtual ICollection<ComputerProcessor> ComputerProcessors { get; set; }
    }
}
