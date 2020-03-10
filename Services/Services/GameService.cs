using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using Services.DTOs;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _repository;
        private readonly IMapper _mapper;
        private readonly IBus _bus;

        public GameService(IGameRepository repository, IMapper mapper, IBus bus)
        {
            _repository = repository;
            _mapper = mapper;
            _bus = bus;
        }

        public void Delete(Guid id)
        {
            _bus.SendCommand(new RemoveGameCommand(id));
        }

        public IEnumerable<GameDTO> FindGameByReleaseYear(int year)
        {
            IEnumerable<Game> entityList = _repository.FindGameByReleaseYear(year);
            List<GameDTO> entityDTOList = new List<GameDTO>();
            foreach (Game entity in entityList)
            {
                entityDTOList.Add(_mapper.Map<GameDTO>(entity));
            }
            return entityDTOList;
        }

        public IEnumerable<GameDTO> FindGames()
        {
            IEnumerable<Game> entityList = _repository.FindAllGames();
            List<GameDTO> entityDTOList = new List<GameDTO>();
            foreach (Game entity in entityList)
            {
                entityDTOList.Add(_mapper.Map<GameDTO>(entity));
            }
            return entityDTOList;
        }

        public GameDTO Get(Guid id)
        {
            var model = _repository.Find(id);
            if (model != null)
            {
                return _mapper.Map<GameDTO>(model);
            }
            return null;
        }

        public IEnumerable<GameDTO> GetAll()
        {
            IEnumerable<Game> entityList = _repository.Get();
            List<GameDTO> entityDTOList = new List<GameDTO>();
            foreach (Game entity in entityList)
            {
                entityDTOList.Add(_mapper.Map<GameDTO>(entity));
            }
            return entityDTOList;
        }

        public void Save(CreateGameDTO model)
        {
            if (model != null)
            {
                var game = _mapper.Map<CreateGameCommand>(model);
                _bus.SendCommand(game);
            }
        }

        public void Update(UpdateGameDTO model)
        {
            if (model != null)
            {
                var game = _mapper.Map<UpdateGameCommand>(model);
                _bus.SendCommand(game);
            }
        }
    }
}
