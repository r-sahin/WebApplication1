using WebApplication1.ManuelCQRS.Commands.Requests;
using WebApplication1.ManuelCQRS.Commands.Responses;
using WebApplication1.Models;

namespace WebApplication1.ManuelCQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler
    {
        public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest request)
        {
            var id =Guid.NewGuid();

            ApplicationDbContext.ProductList.Add(new()
            {
                Id = id,
                CreatedTime = DateTime.Now,
                Name=request.Name,
                Price=request.Price,
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
