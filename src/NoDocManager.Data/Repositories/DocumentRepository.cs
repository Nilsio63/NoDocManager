using NoDocManager.Abstractions.Models;
using NoDocManager.Data.Abstractions.Repositories;
using NoDocManager.Data.Context;

namespace NoDocManager.Data.Repositories;

public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
{
    public DocumentRepository(NoDocManagerContext dbContext)
        : base(dbContext)
    {
    }
}
