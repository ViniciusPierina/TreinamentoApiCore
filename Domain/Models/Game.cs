using Core.Models;
using Domain.Enums;

namespace Domain.Models
{
    public class Game : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public GameType Type { get; set; }
        public int ReleaseYear { get; set; }
    }
}
