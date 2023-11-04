using Library.Domain.Entities;
using Library.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;



namespace Library.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumeroCorrelativoController : ControllerBase
    {
        private readonly INumeroCorrelativoRepository numeroCorrelativoRepository;

        public NumeroCorrelativoController(INumeroCorrelativoRepository numeroCorrelativoRepository)
        {
            this.numeroCorrelativoRepository = numeroCorrelativoRepository;
        }

        [HttpGet("GetNumeroCorrelativos")]
        public IActionResult GetNumeroCorrelativos()
        {
            var correlativos = numeroCorrelativoRepository.GetEntities();
            return Ok(correlativos);
        }

        [HttpGet("GetNumeroCorrelativo/{id}")]
        public IActionResult GetNumeroCorrelativo(int id)
        {
            var correlativo = numeroCorrelativoRepository.GetNumeroCorrelativo(id);
            if (correlativo == null)
            {
                return NotFound();
            }
            return Ok(correlativo);
        }

        [HttpPost("SaveNumeroCorrelativo")]
        public IActionResult SaveNumeroCorrelativo([FromBody] NumeroCorrelativo correlativo)
        {
            numeroCorrelativoRepository.Save(correlativo);
            return CreatedAtAction(nameof(GetNumeroCorrelativo), new { id = correlativo.IdNumeroCorrelativo }, correlativo);
        }

        [HttpPut("UpdateNumeroCorrelativo/{id}")]
        public IActionResult UpdateNumeroCorrelativo(int id, [FromBody] NumeroCorrelativo correlativo)
        {
            if (id != correlativo.IdNumeroCorrelativo)
            {
                return BadRequest();
            }

            numeroCorrelativoRepository.Update(correlativo);
            return NoContent();
        }

        [HttpDelete("RemoveNumeroCorrelativo/{id}")]
        public IActionResult RemoveNumeroCorrelativo(int id)
        {
            var correlativo = numeroCorrelativoRepository.GetNumeroCorrelativo(id);
            if (correlativo == null)
            {
                return NotFound();
            }

            numeroCorrelativoRepository.Remove(correlativo);
            return NoContent();
        }
    }
}
