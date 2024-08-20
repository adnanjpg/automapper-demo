// See https://aka.ms/new-console-template for more information

using AutoMapDemo;
using AutoMapper;

Console.WriteLine("Hello, World!");

var mapper = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<Book, BookDto>();
}).CreateMapper();