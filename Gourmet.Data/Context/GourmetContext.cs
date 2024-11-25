using Gourmet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gourmet.Data.Context;

public class GourmetContext(DbContextOptions<GourmetContext> options) : DbContext(options)
{
	public DbSet<Carritos> Carritos { get; set; }
	public DbSet<MetodosPago> MetodosPagos { get; set; }
	public DbSet<Ordenes> Ordenes { get; set; }
	public DbSet<Productos> Productos { get; set; }
	public DbSet<Usuarios> Usuarios { get; set; }
}
