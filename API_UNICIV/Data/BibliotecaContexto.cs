using API_UNICIV.models;
using Microsoft.EntityFrameworkCore;

namespace API_UNICIV.Data
{
    public class BibliotecaContexto : DbContext
    {
        public BibliotecaContexto(DbContextOptions<BibliotecaContexto> options) : base(options){ }
        public DbSet<Editora> editoras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EditoraMap());
        }
    }
}
