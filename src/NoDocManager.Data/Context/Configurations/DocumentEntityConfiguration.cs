using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoDocManager.Abstractions.Models;

namespace NoDocManager.Data.Context.Configurations;

public class DocumentEntityConfiguration : BaseEntityConfiguration<Document>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Document> builder)
    {
        builder.ToTable("Documents");

        builder.Property(o => o.Title);
        builder.Property(o => o.FileLocation);
    }
}
