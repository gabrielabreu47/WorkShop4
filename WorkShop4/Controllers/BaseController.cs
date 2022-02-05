using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop4.Bl.Dto;
using WorkShop4.Model.Entities;
using WorkShop4.Services;

namespace WorkShop4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("aplication/json")]
    public class BaseController<T,TDto> : ControllerBase where T : BaseEntity where TDto : BaseDto
    {
        protected readonly IBaseService<T, TDto> _baseService;

        public BaseController(IBaseService<T,TDto> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var entities = _baseService.Get();

            return Ok(entities);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
            var dto = await _baseService.GetById(id);

            if (dto is null) return NotFound("Not Found");

            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TDto dto)
        {
            var dtoAdded = await _baseService.Create(dto);

            if (dtoAdded is null) return BadRequest();

            return Ok(dtoAdded);
        }

        [HttpPut("Update/{id}")]
        
        public async Task<IActionResult> Update([FromRoute]int id ,[FromBody] TDto dto)
        {

            var dtoUpdated = await _baseService.Update(id, dto);

            if (dtoUpdated is null) return NotFound("mmg");

            return Ok(dtoUpdated);

        }

        [HttpDelete ("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deleted = await _baseService.Delete(id);

            if (!deleted) return NotFound("Eso no existe");

            return Ok();
        }

    }
}
