using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services.Interfaces
{
    public interface ICityService
    {
        void Save(CreateCityDTO model);
        void Update(UpdateCityDTO model);
        void Delete(Guid Id);
        CityDTO Get(Guid Id);
        IEnumerable<CityDTO> GetAll();
    }
}
