using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RocketPizza.Models;
using RocketPizza.Services;

namespace RocketPizza.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase {
        public PizzaController()
        {
            
        }

        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

        // GET by Id

        // POST

        // PUT

        // DELETE
    }
}