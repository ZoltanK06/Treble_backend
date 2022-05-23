using Treble_backend.Core.ProjectAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Treble_backend.Infrastructure.Data.Config;

public class ToDoConfiguration : IEntityTypeConfiguration<ToDoItem>
{
  public void Configure(EntityTypeBuilder<ToDoItem> builder)
  {
    builder.Property(t => t.Title)
        .IsRequired();
  }
}
