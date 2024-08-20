using AutoMapDemo.Publisher;

namespace AutoMapDemo;

public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public IPublisher Publisher { get; set; }
}