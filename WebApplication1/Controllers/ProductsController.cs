using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.MediatR_CQRS.Commands.Requests;
using WebApplication1.MediatR_CQRS.Queries.Requests;
using WebApplication1.MediatR_CQRS.Queries.Responses;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(/*CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler*/ IMediator mediator) : ControllerBase
    {
        //[HttpGet]
        //public async Task<IActionResult> GetAll([FromQuery] GetAllProductQueryRequest request)
        //    => Ok(getAllProductQueryHandler.GetAll(request));

        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] CreateProductCommandRequest request)
        //    => Ok(createProductCommandHandler.CreateProduct(request));

        //[HttpGet("/GetById/{Id}")]
        //public async Task<IActionResult> GetById([FromRoute] GetByIdProductQueryRequest request)
        //    => Ok(getByIdProductQueryHandler.GetById(request));

        //[HttpDelete("/Delete/{Id}")]
        //public async Task<IActionResult> Delete([FromRoute] DeleteProductCommandRequest request)
        //    => Ok(deleteProductCommandHandler.DeleteProduct(request));

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProductQueryRequest request)
               => Ok(mediator.Send(request));

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductCommandRequest request)
            => Ok(mediator.Send(request));

        [HttpGet("/GetById/{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdProductQueryRequest request)
            => Ok(mediator.Send(request));

        [HttpDelete("/Delete/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProductCommandRequest request)
            => Ok(mediator.Send(request));
    }
}
