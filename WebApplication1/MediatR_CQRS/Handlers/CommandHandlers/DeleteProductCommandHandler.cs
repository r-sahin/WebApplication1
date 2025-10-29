using MediatR;
using WebApplication1.MediatR_CQRS.Commands.Requests;
using WebApplication1.MediatR_CQRS.Commands.Responses;
using WebApplication1.Models;

namespace WebApplication1.MediatR_CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(x => x.Id == request.Id);
            if (product != null)
            {
                ApplicationDbContext.ProductList.Remove(product);
            }
            return new DeleteProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
