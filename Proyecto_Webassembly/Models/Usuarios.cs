using System.ComponentModel.DataAnnotations;

public class Usuarios
{
    [Key]
    public int UsuarioId { get; set; }

    public string  NombreUsuario { get; set; } = string.Empty;

    public string  Nombre { get; set; } = string.Empty;

    public string Apellido { get; set; } =string.Empty;

    public string Email { get; set; } =string.Empty;

    public int Telefono { get; set; }





}