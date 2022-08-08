using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        // GET: api/<InventoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InventoryController>/apple
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return "value";
        }

        // POST api/<InventoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //If the resource identifier is "/inventory"

            //The input can be a single entry or multiple.
                //▪ Handle updates and creation of documents based on inventory store.
        }

        // PUT api/<InventoryController>/5
        [HttpPut("{name}")]
        public void Put(int id, [FromBody] string value)
        {
            //If the resource identifier is "/inventory/itemname"

            //Update the entry if found.

            //Create new record if not found
        }

        // DELETE api/<InventoryController>/apple
        [HttpDelete("{name}")]
        public void Delete(int id)
        {
            //If the resource identifier is "/inventory/itemname", the named item is deleted
        }
    }
}
