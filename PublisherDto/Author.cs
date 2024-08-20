namespace AutoMapDemo.Publisher;

public class AuthorDto : IPublisherDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
}