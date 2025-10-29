using MediatR;
using WebApplication1.MediatR_CQRS.Queries.Responses;

namespace WebApplication1.MediatR_CQRS.Queries.Requests
{
    public class GetByIdProductQueryRequest:IRequest<GetByIdProductQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
