using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Text.RegularExpressions;


public class CarrosContext: DbContext
{
    public DbSet<Automovil> Auromoviles {get;set;}
    public DbSet<Marca> Marcas {get;set;}

    public CarrosContext(DbContextOptions<CarrosContext> options) :base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

        modelBuilder.Entity<Automovil>(automovil=> 
        {
            automovil.ToTable("Automovil");
            automovil.HasKey(p=> p.AutomovilId);
            automovil.Property(p=> p.Modelo).IsRequired().HasMaxLength(30);
            automovil.Property(p=> p.Descripcion).HasMaxLength(100);
            automovil.Property(p=> p.Precio).IsRequired();
            automovil.Property(p => p.Kilometraje).IsRequired();
            automovil.HasOne(p => p.Marca).WithMany(p => p.Automoviles).HasForeignKey(p => p.MarcaId);
        });

      
        modelBuilder.Entity<Marca>(marca=> 
        {
            marca.ToTable("Marca");
            marca.HasKey(p => p.MarcaId);
            marca.Property(p => p.Nombre).IsRequired().HasMaxLength(20);

        });

    }
}