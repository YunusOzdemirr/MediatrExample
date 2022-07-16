using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatrExample.Med.Commands;
using MediatrExample.Med.Queries;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatrExample.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/values
        [HttpGet("[action]")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            return Ok(await mediator.Send(query));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery();
            return Ok(await mediator.Send(query));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}

