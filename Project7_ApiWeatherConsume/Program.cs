#region Menü_Başlangıcı
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

Console.WriteLine("Api Consume Projesine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
Console.WriteLine();
Console.WriteLine("1-Şehir Listesini Getirin");
Console.WriteLine("2-Şehir ve hava durumu Getirin");
Console.WriteLine("3-Yeni Şehir Ekleme İşlemi");
Console.WriteLine("4-Şehir Silme İşlemi");
Console.WriteLine("5-Şehir Güncelleme İşlemi");
Console.WriteLine("6-ID`ye Göre Şehir Getirme İşlemi");
Console.WriteLine();
Console.WriteLine("Tercihiniz");
#endregion

string number;
number = Console.ReadLine();

if (number=="1")
{
	string url = "https://localhost:7277/api/Weathers";
	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response= await client.GetAsync(url);
		string responseBody = await response.Content.ReadAsStringAsync();
		JArray jArray = JArray.Parse(responseBody);
		foreach (var item in jArray)
		{
			string cityName = item["cityName"].ToString();
            Console.WriteLine($"Şehir: {cityName}");
        }
	}
}
if (number=="2")
{
	string url = "https://localhost:7277/api/Weathers";
	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response= await client.GetAsync(url);
		string responseBody= await response.Content.ReadAsStringAsync();
		JArray jArray= JArray.Parse(responseBody);
		foreach (var item in jArray)
		{
			string cityName = item["cityName"].ToString();
			string temp = item["temp"].ToString();
			string country = item["country"].ToString();
			Console.WriteLine("Şehir: "+cityName+" Sıcaklık: "+temp+" Ülke: "+country);
            Console.WriteLine("----------------------------");
        }
	}
}
if (number=="3")
{
	string url = "https://localhost:7277/api/Weathers";
	Console.WriteLine("Şehir Ekleme Alanı");
    Console.WriteLine();
	string cityName, country, detail;
	decimal temp;
    Console.WriteLine("Şehir İsmi Giriniz :");
	cityName=Console.ReadLine();
    Console.WriteLine("Ülke İsmi Giriniz");
    country=Console.ReadLine();
    Console.WriteLine("Detay Giriniz");
	detail=Console.ReadLine();
    Console.WriteLine("Sıcaklığı Giriniz");
	temp=decimal.Parse(Console.ReadLine());

	var newWeatherCity = new
	{
		Cityname = cityName,
		Country = country,
		Detail = detail,
		Temp= temp
	};
	using (HttpClient client = new HttpClient())
	{
		string json=JsonConvert.SerializeObject(newWeatherCity);
		StringContent content = new StringContent(json, Encoding.UTF8,"application/json");
		HttpResponseMessage response=await client.PostAsync(url, content);
		response.EnsureSuccessStatusCode();
		
	}

}
if (number == "4")
{
	Console.WriteLine("Şehir Silme Alanı");
	string url = "https://localhost:7277/api/Weathers?id=";
    Console.Write("Silmek İstediğimiz İd Değerini Giriniz: ");
	int id = int.Parse(Console.ReadLine());

	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response=await client.DeleteAsync(url+id);
		response.EnsureSuccessStatusCode();
	}
}
if (number == "5")
{
	string url = "https://localhost:7277/api/Weathers";
	Console.WriteLine("Şehir Güncelleme Alanı");
	string cityName, country, detail;
	decimal temp;
	int id;
	Console.WriteLine("İd Giriniz");
	id = int.Parse(Console.ReadLine());
	Console.WriteLine("Şehir İsmi Giriniz :");
	cityName = Console.ReadLine();
	Console.WriteLine("Ülke İsmi Giriniz");
	country = Console.ReadLine();
	Console.WriteLine("Detay Giriniz");
	detail = Console.ReadLine();
	Console.WriteLine("Sıcaklığı Giriniz");
	temp = decimal.Parse(Console.ReadLine());
	
	var updateWeather = new
	{
		CityId=id,
		CityName=cityName,
		Country=country,
		Detail=detail,
		Temp=temp
	};
	using (HttpClient client = new HttpClient())
	{
		string json = JsonConvert.SerializeObject(updateWeather);
		StringContent content= new StringContent(json,Encoding.UTF8,"application/json");
		HttpResponseMessage response = await client.PutAsync(url, content);
		response.EnsureSuccessStatusCode();
	}
}
if (number == "6")
{
	Console.WriteLine("Id`ye Göre Şehir Getirme Alanı");
    Console.WriteLine();
    Console.WriteLine("Şehir İd Giriniz");
	int id = int.Parse(Console.ReadLine());
    Console.WriteLine();
    string url = "https://localhost:7277/api/Weathers/GetByIdWeatherCity?id=";
	
	using (HttpClient client = new HttpClient())
	{
		HttpResponseMessage response = await client.GetAsync(url+id);
		response.EnsureSuccessStatusCode();
		string responseBody=await response.Content.ReadAsStringAsync();
		JObject weatherCityObject = JObject.Parse(responseBody);
		string cityName = weatherCityObject["cityName"].ToString();
		string detail = weatherCityObject["detail"].ToString();
		string country = weatherCityObject["country"].ToString();
		decimal temp = decimal.Parse(weatherCityObject["temp"].ToString());
        Console.WriteLine("Girmiş Olduğunuz İd değerine göre bilgiler");

        Console.WriteLine("Şehir: "+cityName+"| Ülke: "+country+"| Detay: "+detail+"| Sıcaklık: "+temp);
    }

}
Console.ReadLine();