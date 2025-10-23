using GeometriaWebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeometriaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeometriaController : ControllerBase
    {

        static List<FiguraDto> figuraDtos = new List<FiguraDto> { new FiguraDto { Id=1,Ancho=25,Area=56, Tipo=4},new FiguraDto {Tipo=65,Area=33,Ancho=36,Id=352 } };
        // GET: api/<GeometriaController>
        [HttpGet]
        public IEnumerable<FiguraDto> Get()
        {
            return figuraDtos;
        }

        // GET api/<GeometriaController>/5
        [HttpGet("{id}")]
        public FiguraDto Get(int id)
        {
            return (from f in figuraDtos where f.Id == id select f).FirstOrDefault();
        }

        // POST api/<GeometriaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GeometriaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GeometriaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
