using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gourmet.Data.Models;

public class Ordenes
{
	public int OrdenId { get; set; }

	public double Total { get; set; }

	public DateTime Fecha { get; set; }

	[ForeignKey("Productos")]
	public int ProductoId { get; set; }
	public Productos? Productos { get; set; }

	public enum Estado
	{
		Iniciado,
		Proceso,
		Finalizado
	}

}
