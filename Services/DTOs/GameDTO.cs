using Domain.Enums;
using Domain.Models;
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
        public City City { get; set; }
        public Guid CityId { get; set; }
    }
}
