using Library.Domain.Entities;
using Library.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoPrestamoController : ControllerBase
    {
        private readonly IEstadoPrestamorRepository estadoPrestamorRepository;

        public EstadoPrestamoController(IEstadoPrestamorRepository estadoPrestamorRepository)
        {
            this.estadoPrestamorRepository = estadoPrestamorRepository;
        }

        // GET: api/<EstadoPrestamoController>
        [HttpGet]
        public IEnumerable<EstadoPrestamo> Get()
        {
           var estadoprestamo = this.estadoPrestamorRepository.GetEstadoPrestamos(); ;
            return estadoprestamo;
        }

        // GET api/<EstadoPrestamoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EstadoPrestamoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EstadoPrestamoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EstadoPrestamoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
