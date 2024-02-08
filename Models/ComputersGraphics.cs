using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppModel.Models
{
    public class ComputersGraphics
    {
    
            [Key]
            public int Id { get; set; }

            public int ComputerId { get; set; }
            public int GraphicsId { get; set; }

            [ForeignKey("ComputerId")]
            public virtual Computer Computer { get; set; }

            [ForeignKey("GraphicsId")]
            public virtual Graphics Graphics { get; set; }
    }
}
