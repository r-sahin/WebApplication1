namespace WebApplication1.ManuelCQRS.Commands.Requests
{
    public class CreateProductCommandRequest
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
