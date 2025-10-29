using WebApplication1.ManuelCQRS.Queries.Requests;
using WebApplication1.ManuelCQRS.Queries.Responses;
using WebApplication1.Models;

namespace WebApplication1.ManuelCQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse GetById(GetByIdProductQueryRequest request)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(x => x.Id == request.Id);

            return new GetByIdProductQueryResponse
            {
                CreatedTime=product.CreatedTime,
                Id=product.Id,
                Name=product.Name,
                Price=product.Price,
                Quantity = product.Quantity
            };
        }
    }
}
