using AutoMapDemo.Publisher;

namespace AutoMapDemo;

public class BookDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public IPublisherDto Publisher { get; set; }
}