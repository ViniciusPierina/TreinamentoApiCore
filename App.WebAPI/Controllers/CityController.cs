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
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public ActionResult<List<CityDTO>> GetAll()
        {
            return Ok(_cityService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<CityDTO> GetById(Guid id)
        {
            var city = _cityService.Get(id);
            return Ok(city);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreateCityDTO createCityDTO)
        {
            try
            {
                _cityService.Save(createCityDTO);
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
        public ActionResult Put([FromBody] UpdateCityDTO updateCityDTO)
        {
            try
            {
                _cityService.Update(updateCityDTO);
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
                _cityService.Delete(id);
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
    }
}
