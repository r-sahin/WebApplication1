using WebApplication1.ManuelCQRS.Commands.Requests;
using WebApplication1.ManuelCQRS.Commands.Responses;
using WebApplication1.Models;

namespace WebApplication1.ManuelCQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest request)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(x => x.Id == request.Id);
            if (product != null)
            {
                ApplicationDbContext.ProductList.Remove(product);
            }
            return new DeleteProductCommandResponse
            {
                IsSuccess=true
            };
        }
    }
}
