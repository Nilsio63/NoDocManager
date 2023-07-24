using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NoDocManager.Data.Abstractions.Repositories;
using NoDocManager.Data.Context;
using NoDocManager.Data.Repositories;

namespace NoDocManager.Data.Extensions;

public static class DataServiceCollectionExtensions
{
    public static IServiceCollection AddDataServices(this IServiceCollection services)
    {
        return services
            .AddDbContextPool<NoDocManagerContext>(opt =>
            {
                SqliteConnection con = new("DataSource=file::memory:;Pooling=false");
                con.Open();
                opt.UseSqlite(con);
            })
            .AddTransient<IDocumentRepository, DocumentRepository>();
    }
}
