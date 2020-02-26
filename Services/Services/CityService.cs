using System;
using System.Collections.Generic;
using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using Services.DTOs;
using Services.Services.Interfaces;

namespace Services.Services
{
    public class CityService : ICityService
    {
        private readonly IRepository<City> _repository;
        private readonly IMapper _mapper;
        private readonly IBus _bus;

        public CityService(IRepository<City> repository, IMapper mapper, IBus bus)
        {
            _repository = repository;
            _mapper = mapper;
            _bus = bus;
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new RemoveCityCommand(id));
        }

        public CityDTO Get(Guid id)
        {
            var model = _repository.Find(id);
            if (model != null)
                return _mapper.Map<CityDTO>(model);

            return null;
        }

        public IEnumerable<CityDTO> GetAll()
        {
            IEnumerable<City> entityList = _repository.Get();
            List<CityDTO> entityDTOList = new List<CityDTO>();
            foreach (City entity in entityList)
            {
                entityDTOList.Add(_mapper.Map<CityDTO>(entity));
            }
            return entityDTOList;
        }

        public void Save(CreateCityDTO model)
        {
            var city = _mapper.Map<CreateCityCommand>(model);
            _bus.SendCommand(city);
        }

        public void Update(UpdateCityDTO model)
        {
            var city = _mapper.Map<UpdateCityCommand>(model);
            _bus.SendCommand(city);
        }
    }
}
