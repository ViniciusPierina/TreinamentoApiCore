using AutoMapper;
using Core.CQRS;
using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using System;

namespace Domain.Handlers.Commands
{
    public class GameCommandHandler : IHandler<CreateGameCommand>,
        IHandler<UpdateGameCommand>,
        IHandler<RemoveGameCommand>
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GameCommandHandler(IGameRepository gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }
        public void Handle(CreateGameCommand Message)
        {
            if (Message != null)
            {
                var game = _mapper.Map<Game>(Message);
                game.CreationDate = DateTime.Now;
                _gameRepository.Add(game);
            }
        }

        public void Handle(UpdateGameCommand Message)
        {
            if (Message != null)
            {
                var game = _mapper.Map<Game>(Message);
                _gameRepository.Update(game);
            }
        }

        public void Handle(RemoveGameCommand Message)
        {
            var game = _gameRepository.Find(Message.Id);
            if (game != null)
            {
                _gameRepository.Remove(Message.Id);
            }
        }
    }
}
