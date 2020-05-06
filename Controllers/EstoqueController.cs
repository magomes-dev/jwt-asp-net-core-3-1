using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PixForce.Dtos;
using PixForce.Dtos.Param;
using PixForce.Entities;
using PixForce.Helpers;
using PixForce.Services;

namespace PixForce.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        private IEstoqueService _estoqueService;
        private IMapper _mapper;

        public EstoqueController(
            IEstoqueService estoqueService,
            IMapper mapper
            )
        {
            _estoqueService = estoqueService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Register([FromBody]EstoqueParamDto dto)
        {
            if (!dto.QtdEstoque.HasValue)
            {
                dto.QtdEstoque = 0;
            }

            var estoque = _mapper.Map<Estoque>(dto);

            try
            {
                _estoqueService.Create(estoque);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var itens = _estoqueService.GetAll();
            var dto = _mapper.Map<IList<EstoqueDto>>(itens);
            return Ok(dto);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var estoque = _estoqueService.GetById(id);
            var dto = _mapper.Map<EstoqueDto>(estoque);
            return Ok(dto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]EstoqueParamDto dto)
        {
            var estoque = _mapper.Map<Estoque>(dto);
            estoque.Id = id;



            try
            {
                _estoqueService.Update(estoque);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _estoqueService.Delete(id);
            return Ok();
        }

    }
}