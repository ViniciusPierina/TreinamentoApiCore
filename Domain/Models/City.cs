using Core.Models;
using Domain.Enums;

namespace Domain.Models
{
    public class City : BaseModel
    {
        public string Name { get; set; }
        public State State { get; set; }
        public int Population { get; set; }
        public int FoundationYear { get; set; }
    }
}
