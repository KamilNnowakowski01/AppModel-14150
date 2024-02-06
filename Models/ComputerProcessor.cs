using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppModel.Models
{
    public class ComputerProcessor
    {
        [Key]
        public int Id { get; set; }

        public int ComputerId { get; set; }
        public int ProcessorId { get; set; }

        [ForeignKey("ComputerId")]
        public virtual Computer Computer { get; set; }

        [ForeignKey("ProcessorId")]
        public virtual Processor Processor { get; set; }
    }
}
