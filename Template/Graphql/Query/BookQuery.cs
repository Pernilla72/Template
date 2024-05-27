namespace Template.Graphql.Query;

//Detta är en Annotering, eller attribut. Används för att lägga till metadata till klasser, metoder, egenskaper etc.
//I detta fallet är det ett attribut från GraphQL, och används för att utöka en objektstyp, i detta fallet en query.
[ExtendObjectType("Query")]

//en fråga från användare eller liknande: en QUery innebär endast att information läses och ev presenteras tilbaks till användare.  
public class BookQuery 
{
    public async Task<Book> GetBook([Service] ISender mediator, int id)
    {
        return await mediator.Send(new GetBookQuery(id));
    }
}

