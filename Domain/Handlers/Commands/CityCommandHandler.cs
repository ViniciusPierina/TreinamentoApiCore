using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using System;

namespace Domain.Handlers.Commands
{
    public class CityCommandHandler : IHandler<CreateCityCommand>,
        IHandler<UpdateCityCommand>,
        IHandler<RemoveCityCommand>
    {
        private readonly IRepository<City> _repository;
        private readonly IMapper _mapper;
        public CityCommandHandler(IRepository<City> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public void Handle(CreateCityCommand Message)
        {
            if(Message != null)
            {
                var city = _mapper.Map<City>(Message);
                city.CreationDate = DateTime.Now;
                _repository.Add(city);
            }
        }
        public void Handle(UpdateCityCommand Message)
        {
            if(Message != null)
            {
                var city = _mapper.Map<City>(Message);
                _repository.Update(city);
            }
        }
        public void Handle(RemoveCityCommand Message)
        {
            var city = _repository.Find(Message.Id);
            if(city != null)
            {
                _repository.Remove(Message.Id);
            }
        }
    }
}
