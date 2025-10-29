namespace WebApplication1.MediatR_CQRS.Commands.Responses
{
    public class CreateProductCommandResponse
    {
        public bool IsSuccess { get; set; }
        public Guid Id { get; set; }
    }
}
