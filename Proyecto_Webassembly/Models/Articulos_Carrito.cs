using System.ComponentModel.DataAnnotations;

public class Articulos_Carrito
{ 
    [Key]
    public int ArticulosId { get; set; }

    public  int CarritoId { get; set; }
    public int ProductoId { get; set; }

    public int  Cantidad { get; set; }

}