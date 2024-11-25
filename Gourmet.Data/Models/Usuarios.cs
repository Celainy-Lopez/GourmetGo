using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gourmet.Data.Models;

public class Usuarios
{
	[Key]
	public int UsuarioId { get; set; }

	[Required(ErrorMessage = "Debe ingresar un nombre")]
	[StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
	[RegularExpression(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+$", ErrorMessage = "El nombre solo debe contener letras.")]
	public string Nombres { get; set; }

	[Required(ErrorMessage = "Debe ingresar una contraseña")]
	[StringLength(20, MinimumLength = 8, ErrorMessage = "La contraseña debe tener entre 8 y 20 caracteres.")]
	[RegularExpression(@"^(?=.*[!@#$%^&*(),.?""':{}|<>])+", ErrorMessage = "La contraseña debe incluir al menos un carácter especial.")]
	public string Password { get; set; }

	public string FotoPerfil { get; set; }

	public string Rol { get; set; }

	[ForeignKey("UsuarioId")]
	public ICollection<Productos> Productos { get; set; } = new List<Productos>();

	[ForeignKey("Orden")]
	public int OrdenId { get; set; }
	public Ordenes? Orden { get; set; }
}
