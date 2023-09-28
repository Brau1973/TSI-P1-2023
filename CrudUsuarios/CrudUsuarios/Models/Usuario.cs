using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "text")] // Esto define el campo 'Nombre' como tipo 'text'
    public string Nombre { get; set; }

    public DateTime FechaNacimiento { get; set; }
}
