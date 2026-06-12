using Contracts;
using Typesense;

namespace SearchService.MessageHandlers;

public static class AnswerCountUpdatedHandler
{
    public static async Task Handle(AnswerCountUpdated message, ITypesenseClient client)
    {
        await client.UpdateDocument("questions", message.QuestionId,
            new { message.AnswerCount });
    }
}
