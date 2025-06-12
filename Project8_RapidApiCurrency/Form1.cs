using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8_RapidApiCurrency
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		decimal dollar, euro, sterlin;
		private async void Form1_Load(object sender, EventArgs e)
		{
			
		
			#region Dollar
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
				Headers =
	{
		{ "x-rapidapi-key", "3c6d0fcd2bmshf14440917df7f17p16a024jsn1677367d9162" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var json = JObject.Parse(body);
				var value = json["result"].ToString();
				lblDolar.Text = "Dolar: "+value;
				dollar = decimal.Parse(value);
				//Console.WriteLine(body);
			}
			#endregion

			#region Euro

			var client2 = new HttpClient();
			var request2 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
				Headers =
	{
		{ "x-rapidapi-key", "3c6d0fcd2bmshf14440917df7f17p16a024jsn1677367d9162" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response2 = await client2.SendAsync(request2))
			{
				response2.EnsureSuccessStatusCode();
				var body2 = await response2.Content.ReadAsStringAsync();
				var json2 = JObject.Parse(body2);
				var value2= json2["result"].ToString();
				lblEuro.Text = "Euro: "+value2;
				euro = decimal.Parse(value2);
				//Console.WriteLine(body);
			}


			#endregion

			#region Sterlin
			var client3 = new HttpClient();
			var request3 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
				Headers =
	{
		{ "x-rapidapi-key", "3c6d0fcd2bmshf14440917df7f17p16a024jsn1677367d9162" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response3 = await client3.SendAsync(request3))
			{
				response3.EnsureSuccessStatusCode();
				var body3 = await response3.Content.ReadAsStringAsync();
				var json3 = JObject.Parse(body3);
				var value3 = json3["result"].ToString();
				lblSterlin.Text = "Sterlin: "+value3;
				sterlin = decimal.Parse(value3);
				//Console.WriteLine(body);
			}

			#endregion

			txtSonuc.Enabled = false;

			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (rdbDolar.Checked==true)
			{
				txtSonuc.Text = Convert.ToString(int.Parse(txtBirim.Text) * dollar);
			}
			if (rdbEuro.Checked==true)
			{
				txtSonuc.Text = Convert.ToString(int.Parse(txtBirim.Text) * euro);
			}
			if (rdbSterlin.Checked==true)
			{
				txtSonuc.Text = Convert.ToString(int.Parse(txtBirim.Text) * sterlin);
			}
		}
	}
}
