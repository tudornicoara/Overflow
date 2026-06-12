using System.Text.RegularExpressions;
using Contracts;
using SearchService.Models;
using Typesense;

namespace SearchService.MessageHandlers;

public static class QuestionCreatedHandler
{
    public static async Task Handle(QuestionCreated message, ITypesenseClient client)
    {
        var created = new DateTimeOffset(message.Created).ToUnixTimeSeconds();

        var doc = new SearchQuestion
        {
            Id = message.QuestionId,
            Title = message.Title,
            Content = StripHtml(message.Content),
            CreatedAt = created,
            Tags = message.Tags.ToArray()
        };

        await client.CreateDocument("questions", doc);

        Console.WriteLine($"Created question with id {message.QuestionId}");
    }

    private static string StripHtml(string content) =>
        Regex.Replace(content, "<.*?>", string.Empty);
}
