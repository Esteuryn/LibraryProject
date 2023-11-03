using Library.Domain.Entities;
using Library.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibroRepository libroRepository;

        public LibroController(ILibroRepository libroRepository)
        {
            this.libroRepository = libroRepository;
        }

        // GET: api/<LibroController>
        [HttpGet]
        public IEnumerable<Libro> Get()
        {
           var libros = this.libroRepository.GetLibros();
            return libros;
        }
       
        // GET api/<LibroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LibroController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LibroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LibroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
