using System.ComponentModel.DataAnnotations;

public class Carrito
{

    [Key]
    public int CarritoId { get; set; }
    
    public int UsuarioId { get; set; }

    

}