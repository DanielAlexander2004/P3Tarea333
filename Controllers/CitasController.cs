using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using P3Tarea3.Interfaces;
using P3tarea333;

namespace P3Tarea3.Controllers
{

	public class CitasController : Controller
	{
		private readonly ICitas citas;

		public CitasController(ICitas citas)
		{
			this.citas = citas;
		}

		[HttpPost("Set-Cliente")]
		public string SetCitas(Citas model)
		{
			return citas.SetCitas(model);

		}
	}
	/*agregando */

}