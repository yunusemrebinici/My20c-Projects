using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_13WeatherApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://yahoo-weather5.p.rapidapi.com/weather?location=istanbul&format=json&u=f"),
				Headers =
	{
		{  "x-rapidapi-key", "3c6d0fcd2bmshf14440917df7f17p16a024jsn1677367d9162" },
		{ "x-rapidapi-host", "yahoo-weather5.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var json=JObject.Parse(body);
				var location = json["location"]["city"].ToString();
				
				var windSpeed = json["current_observation"]["wind"]["speed"].ToString();
				var humidity = json["current_observation"]["atmosphere"]["humidity"].ToString();
				var fahrenheit = json["current_observation"]["condition"]["temperature"].ToString();
				var waterStatus = json["current_observation"]["condition"]["text"].ToString();
				var s = 1.8;
				decimal celcius = (decimal.Parse(fahrenheit) - 32) / decimal.Parse(s.ToString());
				lblCelcius.Text = Convert.ToInt32(celcius).ToString();
				
				lblWind.Text = windSpeed.ToString();
				lblHumidty.Text = humidity.ToString();
				lblWeatherStatus.Text= waterStatus.ToString();

				lblLocation.Text=location.ToString();
			}
			ArrayList list = new ArrayList();
			list.Add("Cloudy");
			list.Add("Sunny");
			list.Add("Snow");
			list.Add("Rain");
			list.Add("Mostly Sunny");
			list.Add("Partly Cloudy");
			list.Add("Showers");
			string filePath = @"C:\Users\yunus\Desktop\C# 20 PROJE\My20c#Projects\Project_13WeatherApp\image\";
			string fileName = "";
			foreach (var item in list)
			{
				if (lblWeatherStatus.Text==item.ToString())
				{
					fileName = lblWeatherStatus.Text+".png";					
					pictureBox1.ImageLocation = filePath + fileName;
					break;
				}
			  
            }
			
		}
	}
}
