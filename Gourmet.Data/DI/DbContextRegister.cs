using Gourmet.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gourmet.Data.DI;

public static class DbContextRegister
{
	public static IServiceCollection RegisterDbContextFactory(this IServiceCollection services)
	{
		services.AddDbContextFactory<GourmetContext>(o => o.UseSqlServer("Name=SqlConStr"));
		return services;
	}
}
