using Core.Models;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

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
