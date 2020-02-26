using Domain.Enums;

namespace Services.DTOs
{
    public class CreateCityDTO : BaseDTO
    {
        public string Name { get; set; }
        public State State { get; set; }
        public int Population { get; set; }
        public int FoundationYear { get; set; }
    }
}
