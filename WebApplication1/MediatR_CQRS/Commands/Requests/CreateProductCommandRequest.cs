using MediatR;
using WebApplication1.MediatR_CQRS.Commands.Responses;

namespace WebApplication1.MediatR_CQRS.Commands.Requests
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
