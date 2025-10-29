using MediatR;
using WebApplication1.MediatR_CQRS.Queries.Requests;
using WebApplication1.MediatR_CQRS.Queries.Responses;
using WebApplication1.Models;

namespace WebApplication1.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(x => x.Id == request.Id);

            return new GetByIdProductQueryResponse
            {
                CreatedTime = product.CreatedTime,
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };
        }
    }
}
