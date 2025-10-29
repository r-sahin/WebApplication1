using MediatR;
using WebApplication1.MediatR_CQRS.Queries.Responses;

namespace WebApplication1.MediatR_CQRS.Queries.Requests
{
    public class GetAllProductQueryRequest:IRequest<List<GetAllProductQueryResponse>>
    {
    }
}
