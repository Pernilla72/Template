﻿namespace Template.Graphql.Query;

[ExtendObjectType("Query")]

//Denna klass innehåller mina GraphQl-frågor & en liten lista med användare för dessa frågor.
public class TestQuery
{
    //En beskrivning som skrivs ut i Banana Cake Pop under schema reference
    [GraphQLDescription("Skapar en bok med dessa attribut")]
    public Book GetBook()
    {
        return new Book
        {
            Id = 1,
            Title = "C# in depth",
            Author = new Model.Author
            {
                Name = "Måns Kallentoft",
                Age = 46
            },
            NumberOfPages = 400,
            IsAvailable = true,
            Genre = "Fiction"
        };
    }

    [GraphQLNonNullType]
    public Author GetAuthor()
    {
        return new()
        {
            Name = "Måns Kallentoft",
            Age = 46,
            Nationality = "Swedish"
        };
    }



    //MIn lilla "Lista" med användare och sen lite frågor om dessa.
    public List<User> _users = new List<User>
        {
            new User { Name = "Alice", Role = UserRole.Guest },
            new User { Name = "Bob", Role = UserRole.Administrator },
            new User { Name = "Fafafa", Role = UserRole.Standard },
            new User { Name = "Charlie", Role = UserRole.Guest },
            new User { Name = "Alicia", Role = UserRole.Administrator },
            new User { Name = "Ben", Role = UserRole.Standard },

    };


    [GraphQLDescription("hämta alla användare baserat på dess roll")]
    public List<User> GetUsers(UserRole role)
    {
        return _users.Where(user => user.Role == role).ToList();
    }



    [GraphQLDescription("hämta alla användare som finns registrerade")]
    public List<User> GetAllUsers()
    {
        return _users.ToList();
    }


    [GraphQLDescription("hämta första användaren av en viss specad roll")]
    public User? GetFirstUser(UserRole role)
    {
        var a = _users?.FirstOrDefault(user => user.Role == role) ?? null;
        return a;
    }


    [GraphQLDescription("skriva ut en test-mail")]
    public Email GetEmailAddress([GraphQLType(typeof(EmailAddressType))] string Email) =>
        new()
        {
            EmailAddress = "test@example.com"
        };
}
