namespace WebApplication1.ManuelCQRS.Queries.Responses
{
    public class GetAllProductQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
