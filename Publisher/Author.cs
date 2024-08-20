namespace AutoMapDemo.Publisher;

public class Author : IPublisher
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
}