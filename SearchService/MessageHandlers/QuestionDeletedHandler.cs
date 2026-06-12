using Contracts;
using SearchService.Models;
using Typesense;

namespace SearchService.MessageHandlers;

public static class QuestionDeletedHandler
{
    public static async Task Handle(QuestionDeleted message, ITypesenseClient client)
    {
        await client.DeleteDocument<SearchQuestion>("questions", message.QuestionId);
    }
}
