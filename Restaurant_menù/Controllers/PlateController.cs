using Microsoft.AspNetCore.Mvc;
using Restaurant_menù.Model;
using Restaurant_menù.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant_menù.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlateController : ControllerBase
    {
        private readonly IPlateRepository plateRepository;

        public PlateController(IPlateRepository plateRepository)
        {
            this.plateRepository= plateRepository;
        }


        // GET: api/<PlateController>
        [HttpGet]
        public IEnumerable<Plate> GetAll()          
        {
           return this.plateRepository.GetAllPlate();
        }


        [HttpGet]
        [Route("GetTypePlate")]
        public IEnumerable<Plate> GetTypePlate(string type)
        {
            return this.plateRepository.GetByType(type);
        }


        [HttpGet]
        [Route("GetPlateDownOfTenPrice")]
        public IEnumerable<Plate> GetByPrice()
        {
            return this.plateRepository.GetPlateByPrice();
        }


        // GET api/<PlateController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlateController>
        [HttpPost]
        [Route("Create")]
        public void Post([FromBody] Plate plate)
        {
            this.plateRepository.CreatePLate(plate);
        }

        // PUT api/<PlateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
