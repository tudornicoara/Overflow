using System.Text.RegularExpressions;
using Contracts;
using Typesense;

namespace SearchService.MessageHandlers;

public static class QuestionUpdatedHandler
{
    public static async Task Handle(QuestionUpdated message, ITypesenseClient client)
    {
        await client.UpdateDocument("questions", message.QuestionId, new
        {
            message.Title,
            Content = StripHtml(message.Content),
            Tags = message.Tags.ToArray()
        });
    }

    private static string StripHtml(string content) =>
        Regex.Replace(content, "<.*?>", string.Empty);
}
