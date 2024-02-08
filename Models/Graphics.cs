using System.ComponentModel.DataAnnotations;

namespace AppModel.Models
{
    public class Graphics
    {
        public Graphics()
        {
            Name = "Default Graphics Name";
            ConnectorType = "Default Connector";
            ComputersGraphics = new HashSet<ComputersGraphics>();
        }

        [Key]
        public int GraphicsId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "MemoryGB is required.")]
        [Range(1, 32, ErrorMessage = "Memory must be between 1 and 32 GB.")]
        public int MemoryGB { get; set; }

        [Required(ErrorMessage = "Connector Type is required.")]
        [StringLength(40, ErrorMessage = "ConnectorType cannot exceed 100 characters.")]
        public string ConnectorType { get; set; }

        [Required(ErrorMessage = "Core Clock MHz Type is required.")]
        [Range(512, 16384, ErrorMessage = "Core Clock must be between 512 and 16384 MHz.")]
        public int CoreClockMHz { get; set; }

        [Required(ErrorMessage = "Recommended Power W is required.")]
        [Range(60, 1000, ErrorMessage = "Recommended Power must be between 60 and 1000 W.")]
        public int RecommendedPower { get; set; }

        public virtual ICollection<ComputersGraphics> ComputersGraphics { get; set; }
    }
}
