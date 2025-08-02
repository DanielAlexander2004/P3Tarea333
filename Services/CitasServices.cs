using System;
using Microsoft.EntityFrameworkCore;
using P3Tarea3.Context;
using P3Tarea3.Interfaces;
using P3tarea333;

namespace P3Tarea3.Services
{
	public class CitasServices : ICitas
	{
		private readonly P3Context context;
		public CitasServices(P3Context Context)
		{
			this.context = Context;
		}
		public string SetCitas(Citas model)
		{
			context.Citas.Add(model);
			context.SaveChanges();
			return "Registro insertado";
		}
	}
}
