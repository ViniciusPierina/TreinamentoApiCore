using Domain.Enums;

namespace Services.DTOs
{
    public class CreateGameDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public GameType Type { get; set; }
        public int ReleaseYear { get; set; }
    }
}
