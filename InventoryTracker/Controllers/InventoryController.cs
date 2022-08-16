using InventoryTracking.business.Handlers.CreateInventoryItem;
using InventoryTracking.business.Handlers.DeleteInventoryItem;
using InventoryTracking.business.Handlers.UpdateInventoryItem;
using InventoryTracking.business.Models;
using MediatR;
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
        private readonly IMediator _mediator;
        public InventoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<InventoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InventoryController>/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return "value";
        }

        // POST api/<InventoryController>
        [HttpPost]
        public async Task<IActionResult> CreateInventoryItem(CreateInventoryItemRequest request)
        {
            var response = await this._mediator.Send(request);

            if (response.IsSuccessful)
            {
                return this.Ok(response);
            }
            return this.BadRequest(response.Message);
        }

        // PUT api/<InventoryController>/5
        [HttpPut("{name}")]
        public async Task<List<InventoryItemModel>> UpdateInventoryItem(UpdateInventoryItemRequest request)
        {
            return await _mediator.Send(request);
        }

        // DELETE api/<InventoryController>/5
        [HttpDelete("{name}")]
        public async Task<string> Delete(DeleteInventoryItemRequest request)
        {
            var _request = new DeleteInventoryItemRequest(request.ItemName);
            return await _mediator.Send(_request);
        }
    }
}
