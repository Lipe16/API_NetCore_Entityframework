using API_UNICIV.models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_UNICIV.Data
{
    public class EditoraMap : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.HasKey(t => t.id);
            builder.Property(t => t.nome).HasMaxLength(150).IsRequired();
            builder.Property(t => t.descricao).IsRequired(false);

            builder.ToTable("editoras");
        }
    }
}
