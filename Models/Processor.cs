using System.ComponentModel.DataAnnotations;

namespace AppModel.Models
{
    public class Processor
    {
        public Processor() {
            ComputerProcessor = new HashSet<ComputerProcessor>();
        }

        [Key]
        public int ProcessorId { get; set; }
        public string Name { get; set; }
        public string Series { get; set; }
        public string Socket { get; set; }
        public float CoreClockGHz { get; set; }
        public int NumberofCores { get; set; }

        public virtual ICollection<ComputerProcessor> ComputerProcessor { get; set; }
    }
}
