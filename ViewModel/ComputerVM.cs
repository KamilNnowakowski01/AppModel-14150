using AppModel.Models;

namespace AppModel.ViewModels
{
    public class ComputerVM
    {
        public Computer? Computer { get; set; }
        public int[]? GraphicsIds { get; set; }
        public ICollection<Graphics> Graphics { get; set; }
        public ICollection<Producer> Producers { get; set; }
        public ComputerVM()
        {
            Graphics = new HashSet<Graphics>();
            Producers = new HashSet<Producer>();
        }

    }
}
