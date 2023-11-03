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

        // GET: api/NumeroCorrelativo
        [HttpGet]
        public IEnumerable<NumeroCorrelativo> Get()
        {
            var correlativos = numeroCorrelativoRepository.GetEntities();
            return correlativos;
        }

        // GET: api/NumeroCorrelativo/5
        [HttpGet("{id}")]
        public ActionResult<NumeroCorrelativo> Get(int id)
        {
            var correlativo = numeroCorrelativoRepository.GetEntity(id);
            if (correlativo == null)
            {
                return NotFound();
            }
            return correlativo;
        }

        // POST: api/NumeroCorrelativo
        [HttpPost]
        public ActionResult<NumeroCorrelativo> Post([FromBody] NumeroCorrelativo correlativo)
        {   
            numeroCorrelativoRepository.Save(correlativo);
            return CreatedAtAction(nameof(Get), new { id = correlativo.IdNumeroCorrelativo }, correlativo);
        }

        // PUT: api/NumeroCorrelativo/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] NumeroCorrelativo correlativo)
        {
            if (id != correlativo.IdNumeroCorrelativo)
            {
                return BadRequest();
            }

            numeroCorrelativoRepository.Update(correlativo);
            return NoContent();
        }

        // DELETE: api/NumeroCorrelativo/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var correlativo = numeroCorrelativoRepository.GetEntity(id);
            if (correlativo == null)
            {
                return NotFound();
            }

            numeroCorrelativoRepository.Remove(correlativo);
            return NoContent();
        }
    }

}
