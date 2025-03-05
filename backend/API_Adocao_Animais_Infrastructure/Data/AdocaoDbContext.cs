using Microsoft.EntityFrameworkCore;
using API_Adocao_Animais.Domain.Entities;

public class AdocaoDbContext : DbContext
{
    public AdocaoDbContext(DbContextOptions<AdocaoDbContext> options) : base(options) { }

    public DbSet<Animal> Animais { get; set; }
    public DbSet<Adotante> Adotantes { get; set; }
    public DbSet<Abrigo> Abrigos { get; set; } // Adicionando DbSet para Abrigos

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Animal>().HasDiscriminator<string>("Tipo")
            .HasValue<Cachorro>("Cachorro")
            .HasValue<Gato>("Gato");

        modelBuilder.Entity<Abrigo>().HasData(
            new Abrigo { Id = 1, Nome = "Abrigo Central", Endereco = "Rua Principal, 123" }
        );

        modelBuilder.Entity<Cachorro>().HasData(
            new Cachorro { Id = 1, Nome = "Rex", Idade = 3, AbrigoId = 1 }
        );

        modelBuilder.Entity<Gato>().HasData(
            new Gato { Id = 2, Nome = "Mia", Idade = 2, AbrigoId = 1 }
        );
    }
}
