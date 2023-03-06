using System.ComponentModel.DataAnnotations;

public class Categoria_Productos
{    [Key]
    public int CategoriaId { get; set; }

    public string   Nombre { get; set; } = string.Empty;
}