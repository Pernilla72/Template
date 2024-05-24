namespace Template.Model;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }

    public Author? Author { get; set; }

    public int? NumberOfPages { get; set; }

    public bool IsAvailable { get; set; }

    public string? Genre { get; set; }
}

public class Author
{
 
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? Age { get; set; }

    public string? Nationality { get; set; }


    internal List<Book>? Books { get; set; } = new List<Book>();
    
}
public enum UserRole
{
    Unkonwn,
    Guest,
    Standard,
    Administrator
}
public class User
{
    public string? Name { get; set; }
    public UserRole? Role { get; set; }

    internal class TextMessage
    {
    }
} 

public class Email
{
    public string? EmailAddress { get; set; }
}

