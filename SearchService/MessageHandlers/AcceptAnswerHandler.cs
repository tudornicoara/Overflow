using Contracts;
using Typesense;

namespace SearchService.MessageHandlers;

public static class AcceptAnswerHandler
{
    public static async Task Handle(AnswerAccepted message, ITypesenseClient client)
    {
        await client.UpdateDocument("questions", message.QuestionId,
            new { HasAcceptedAnswer = true });
    }
}
