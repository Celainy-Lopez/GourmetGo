using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gourmet.Data.Models;

public class MetodosPago
{
	public enum TipoPago
	{
		Tarjeta,
		Efectivo
	}

	public int MetodoPagoId { get; set; }
	public TipoPago Tipo { get; set; }

}
