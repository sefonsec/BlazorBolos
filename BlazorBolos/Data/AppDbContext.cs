using Microsoft.EntityFrameworkCore;

namespace BlazorBolos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Bolo> Bolos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bolo>().HasData(
                new Bolo
                {
                    Id = 1,
                    Nome = "Bolo1",
                    Descricao = "Bolo1",
                    Preco = 23.45m,
                    ImagemUrl = "https://macoratti.net/Imagens/bolos/bolo_banana.jpg"
                },
                new Bolo
                {
                    Id = 2,
                    Nome = "Bolo2",
                    Descricao = "Bolo2",
                    Preco = 21.15m,
                    ImagemUrl = "https://macoratti.net/Imagens/bolos/bolo_brigadeiro.jpg"
                },
                new Bolo
                {
                    Id = 3,
                    Nome = "Bolo3",
                    Descricao = "Bolo3",
                    Preco = 43.55m,
                    ImagemUrl = "https://macoratti.net/Imagens/bolos/bolo_chocolate.jpg"
                },
                new Bolo
                {
                    Id = 4,
                    Nome = "Bolo4",
                    Descricao = "Bolo4",
                    Preco = 34.75m,
                    ImagemUrl = "https://macoratti.net/Imagens/bolos/bolo_laranja.jpg"
                }
            );
        }
    }
}
