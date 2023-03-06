using Microsoft.EntityFrameworkCore;

public class Contexto: DbContext
{
    public DbSet<Productos> productos  { get; set; }
    public DbSet<Carrito> Carritos  { get; set; }
    public DbSet<Articulos_Carrito> Articulos_Carritos  { get; set; }
    public DbSet<Categoria_Productos> Categoria_Productos  { get; set; }
    public DbSet<Usuarios> Usuarios  { get; set; }

    public Contexto (DbContextOptions <Contexto> options): base(options) 
    {
        
    }
}