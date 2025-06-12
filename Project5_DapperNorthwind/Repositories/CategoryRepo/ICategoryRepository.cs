using Project5_DapperNorthwind.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.Repositories.CategoryRepo
{
	public interface ICategoryRepository
	{
		Task<List<ResultCategoryDto>> GettAllCategoryAsync();

		Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);

		Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);

		Task DeleteCategoryAsync(int id);

		Task<List<ResultCategoryDto>> GetByIdCategoryAsync(int id);
	}
}
