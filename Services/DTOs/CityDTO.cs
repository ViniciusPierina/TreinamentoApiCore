using Domain.Enums;
using System;

namespace Services.DTOs
{
    public class CityDTO : BaseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
        public int Population { get; set; }
        public int FoundationYear { get; set; }
    }
}
