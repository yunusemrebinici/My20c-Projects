using Project5_DapperNorthwind.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.Repositories.CategoryRepo
{
	public class CategoryRepository : ICategoryRepository
	{
		public Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteCategoryAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<ResultCategoryDto>> GetByIdCategoryAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<ResultCategoryDto>> GettAllCategoryAsync()
		{
			throw new NotImplementedException();
		}

		public Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
		{
			throw new NotImplementedException();
		}
	}
}
