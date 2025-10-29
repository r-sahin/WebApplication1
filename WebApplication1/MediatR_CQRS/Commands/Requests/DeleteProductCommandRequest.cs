using MediatR;
using WebApplication1.MediatR_CQRS.Commands.Responses;

namespace WebApplication1.MediatR_CQRS.Commands.Requests
{
    public class DeleteProductCommandRequest:IRequest<DeleteProductCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
