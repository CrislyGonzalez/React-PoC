using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PoC.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PoC.Controllers
{
	[Route("api/[controller]")]
	[EnableCors("DefaultCorsPolicyName")]
	public class MetersController : Controller
    {

		private readonly DataAccess _context;

		public MetersController(DataAccess context)
		{
			_context = context;
		}


		// GET: api/<controller>
		[HttpGet]
        public List<Meter> Get()
        {
			return _context.Meter.ToList();
		}

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
		{
			var meter = this._context.Meter.SingleOrDefault(ct => ct.IdTrip == id);
			if (meter != null)
			{
				return Ok(meter);
			}
			else
			{
				return NotFound();
			}
		}

		// POST api/<controller>
		[HttpPost]
        public IActionResult Post([FromBody]Meter meter)
        {
			this._context.Meter.Add(meter);
			this._context.SaveChanges();
			return Created($"Meter/{meter}", meter);
		}


		// PUT api/<controller>/5
		[HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
