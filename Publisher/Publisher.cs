namespace AutoMapDemo.Publisher;

public class Publisher : IPublisher
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Founded { get; set; }
}