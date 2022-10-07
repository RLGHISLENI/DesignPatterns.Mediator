namespace DesignPatterns.Mediator.Domain.Commands.Customer
{
    public class CustomerResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? Date { get; set; }
    }
}
