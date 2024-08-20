namespace AutoMapDemo.Publisher;

public class PublisherDto : IPublisherDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Founded { get; set; }
}