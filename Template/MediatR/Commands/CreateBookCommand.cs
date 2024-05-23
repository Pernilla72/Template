namespace Template.MediatR.Commands;
//Ett kommando för att initiera skapandet av en ny bok, med hjälp av ID
public class CreateBookCommand : IRequestWrapper<Book>
{
    public required int Id { get; set; }
    public string Title { get; set; }

    public Author Author { get; set; }

    public int NumberOfPages { get; set; }

    public bool IsAvailable { get; set; }

    public string Genre { get; set; }

    public CreateBookCommand(int id)
    {
        Id = id;
        Title = Title;
       Author = Author;
        NumberOfPages = NumberOfPages;
        IsAvailable = true;
       Genre = Genre;
    }
}