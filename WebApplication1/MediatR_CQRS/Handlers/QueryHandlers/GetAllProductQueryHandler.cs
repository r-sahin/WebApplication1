using MediatR;
using WebApplication1.MediatR_CQRS.Queries.Requests;
using WebApplication1.MediatR_CQRS.Queries.Responses;
using WebApplication1.Models;

namespace WebApplication1.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return ApplicationDbContext.ProductList.Select(x => new GetAllProductQueryResponse
            {
                CreatedTime = x.CreatedTime,
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity,
            }).ToList();
        }
    }
}
