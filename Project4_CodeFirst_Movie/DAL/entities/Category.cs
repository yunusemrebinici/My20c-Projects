using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_CodeFirst_Movie.DAL.entities
{
	public class Category
	{
		public int CategoryId { get; set; }

		public string CategoryName { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
