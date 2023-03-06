using System.ComponentModel.DataAnnotations;

public class Productos
{
    [Key]
    public int ProductoId { get; set; }

    public string  Titulo { get; set; } = string.Empty;
    
    public string   Descripcion { get; set; } = string.Empty;

    public string  UrlImagen { get; set; } = string.Empty;

    public  int   Cantidad { get; set; }
    public int  CategoriaId { get; set; }

    public decimal Precio { get; set; }

    
}