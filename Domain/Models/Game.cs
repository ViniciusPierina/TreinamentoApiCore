using Core.Models;
using Domain.Enums;
using System;

namespace Domain.Models
{
    public class Game : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public GameType Type { get; set; }
        public int ReleaseYear { get; set; }
        public City City { get; set; }
        public Guid CityId { get; set; }
    }
}
