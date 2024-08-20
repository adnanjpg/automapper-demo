// See https://aka.ms/new-console-template for more information

using AutoMapDemo;
using AutoMapDemo.Publisher;
using AutoMapper;

Console.WriteLine("Hello, World!");

var mapper = new MapperConfiguration(cfg =>
{
    // Book only has IPublisher, while BookDto has Publisher and Author
    // we want to insert either Publisher or Author into IPublisher
    cfg.CreateMap<BookDto, Book>()
        .ForMember(dest => dest.Publisher,
            opt => opt.MapFrom(src => (IPublisher?)src.Publisher ?? src.Author))
        ;
}).CreateMapper();

var Dto = new BookDto
{
    Id = Guid.NewGuid(), Title = "Book Title",
    Publisher = new Publisher { Id = Guid.NewGuid(), Name = "Publisher Name", Founded = DateTime.Now }
};

var entity = mapper.Map<Book>(Dto);

Console.WriteLine($"publisher id: {entity.Publisher.Id}");