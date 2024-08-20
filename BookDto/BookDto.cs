using AutoMapDemo.Publisher;

namespace AutoMapDemo;

public class BookDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Publisher.Publisher? Publisher { get; set; }
    public Author? Author { get; set; }
}