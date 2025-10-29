using MediatR;
using WebApplication1.MediatR_CQRS.Commands.Requests;
using WebApplication1.MediatR_CQRS.Commands.Responses;
using WebApplication1.Models;

namespace WebApplication1.MediatR_CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();

            ApplicationDbContext.ProductList.Add(new()
            {
                Id = id,
                CreatedTime = DateTime.Now,
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity
            });

            return new CreateProductCommandResponse
            {
                Id = id,
                IsSuccess = true
            };
        }
    }
}
