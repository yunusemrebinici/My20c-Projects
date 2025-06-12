using Project4_CodeFirst_Movie.DAL.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_CodeFirst_Movie.DAL.Context
{
	public class Context:DbContext
	{
		public DbSet<Movie> Movies { get; set;}

		public DbSet<Category> Categories { get; set;}
	}
}
