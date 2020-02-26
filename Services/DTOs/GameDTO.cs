using Domain.Enums;
using System;

namespace Services.DTOs
{
    public class GameDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GameType Type { get; set; }
        public int ReleaseYear { get; set; }
    }
}
