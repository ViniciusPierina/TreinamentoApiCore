using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GameDTO>> GetAll()
        {
            return Ok(_gameService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<GameDTO> GetById(Guid id)
        {
            var game = _gameService.Get(id);
            return Ok(game);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreateGameDTO createGameDTO)
        {
            try
            {
                _gameService.Save(createGameDTO);
                return Ok();
            }
            catch (Exception e)
            {
                string errors = e.Message;
                return ValidationProblem(new ValidationProblemDetails()
                {
                    Type = "Model Validation Error",
                    Detail = errors
                });
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] UpdateGameDTO updateGameDTO)
        {
            try
            {
                _gameService.Update(updateGameDTO);
                return Ok();
            }
            catch (Exception e)
            {
                string errors = e.Message;
                return ValidationProblem(new ValidationProblemDetails()
                {
                    Type = "Model Validation Error",
                    Detail = errors
                });
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                _gameService.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                string errors = e.Message;
                return ValidationProblem(new ValidationProblemDetails()
                {
                    Type = "Cannot delete",
                    Detail = errors
                });
            }
        }

        [HttpGet("ReleaseYear")]
        public ActionResult<IEnumerable<GameDTO>> FindGameByReleaseYear(int year)
        {
            return Ok(_gameService.FindGameByReleaseYear(year));
        }
    }
}
