using WebApplication1.ManuelCQRS.Commands.Responses;
using WebApplication1.ManuelCQRS.Queries.Requests;
using WebApplication1.ManuelCQRS.Queries.Responses;
using WebApplication1.Models;

namespace WebApplication1.ManuelCQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAll(GetAllProductQueryRequest request)
        {
            return ApplicationDbContext.ProductList.Select(x=>new GetAllProductQueryResponse
            {
                CreatedTime=x.CreatedTime,
                Id=x.Id,
                Name=x.Name,
                Price=x.Price,
                Quantity=x.Quantity,
            }).ToList();
        }
    }
}
