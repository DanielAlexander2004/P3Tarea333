using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using P3tarea333;

namespace P3Tarea3.Context
{
	public class P3Context : DbContext
	{

		public P3Context(DbContextOptions<P3Context> db) : base(db)
		{


		}

		public DbSet<Citas> Citas { get; set; }
	}
}
