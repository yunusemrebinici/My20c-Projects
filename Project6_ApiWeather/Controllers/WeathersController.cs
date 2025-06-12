using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Context;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WeathersController : ControllerBase
	{
		WeatherContext context=new WeatherContext();

		[HttpGet]
		public IActionResult WeatherCityList()
		{
			var values=context.Cities.ToList();

			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateWeatherCity(City city)
		{
			context.Cities.Add(city);
			context.SaveChanges();
			return Ok("Şehir Eklendi");
		}
		[HttpDelete]
		public IActionResult DeleteWeatherCity(int id)
		{
			var value =context.Cities.Find(id);
			context.Cities.Remove(value);
			context.SaveChanges();
			return Ok("Silme İşlemi Başarılı");
		}
		[HttpPut]
		public IActionResult UpdateWeatherCity(City city)
		{
			var values =context.Cities.Find(city.CityId);
			values.CityName = city.CityName;
			values.Country=city.Country;
			values.Detail = city.Detail;
			values.Temp=city.Temp;
			context.SaveChanges();
			return Ok("Güncelleme Başarılı");
		}
		[HttpGet("GetByIdWeatherCity")]
		public IActionResult GetByIdWeatherCity(int id)
		{
			var value=context.Cities.Find(id);
			return Ok(value);
		}
		[HttpGet("TotalCityCount")]
		public IActionResult TotalCityCount()
		{
			var value =context.Cities.Count();	
			return Ok(value);
		}
		[HttpGet("MaxTempCity")]
		public IActionResult MaxTempCity()
		{
			var value = context.Cities.Where(x => x.Temp ==(context.Cities.Max(y=>y.Temp))).FirstOrDefault();
			return Ok(value);
														
		}
		[HttpGet("MinTempCity")]
		public IActionResult MinTempCity()
		{
			var value =context.Cities.OrderBy(x => x.Temp).FirstOrDefault();
			return Ok(value);	
		}
	}
}
