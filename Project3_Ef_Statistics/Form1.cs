using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Ef_Statistics
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		MyProject3Entities db= new MyProject3Entities();
		private void Form1_Load(object sender, EventArgs e)
		{
			//Kategori Sayısı
			int categoryCount = db.TblCategory.Count();
			lblCategoryCount.Text = categoryCount.ToString();

			//Ürün Sayısı
			int productCount = db.TblProduct.Count();
			lblProductCount.Text = productCount.ToString();

			//Müşteri Sayısı
			int customerCount=db.TblCustomer.Count();
			lblCustomerCount.Text= customerCount.ToString();

			//Sipraiş Sayısı
			int orderCount=db.TblOrder.Count();
			lblOrderCount.Text= orderCount.ToString();

			//Toplam Stok Sayısı
			var productOrderSum = db.TblProduct.Sum(x=>x.ProductStock);
			lblProducStockSum.Text= productOrderSum.ToString();

			//Ortalama Ürün Fiyatı
			var productAvarage = db.TblProduct.Average(x=>x.ProductPrice);
			lblProductAvarage.Text= productAvarage.ToString()+" ₺";

			//Toplam Meyve Stoğu
			var productFruitStock=db.TblProduct.Where(x=>x.ProductCategoryId==1).Sum(x=>x.ProductStock);
			lblProductFruitSum.Text=productFruitStock.ToString();	

			//Gazozun İşlem Hacmi
			var productSodaStock=db.TblProduct.Where(x=>x.ProductName=="Gazoz").Select(x=>x.ProductStock).FirstOrDefault();
			var productSodaPrice = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(x => x.ProductPrice).FirstOrDefault();
			var productSodaTotalPrice = productFruitStock * productSodaPrice;
			lblProductSodaTotalPrice.Text= productSodaTotalPrice.ToString() + " ₺"; ;

			//Stok Sayısı 100`den az olan ürünler
			var productStock = db.TblProduct.Where(x => x.ProductStock < 100).Count();
			lblProductStockSmallerThen100.Text= productStock.ToString();

			//Durumu Aktif Olan Sebze Stoğu
			var productDrinkTrueStatus=db.TblProduct.Where(x=>x.ProductCategoryId == (db.TblCategory.Where(s=>s.CategoryName=="İçecek").Select(c=>c.CategoryId).FirstOrDefault())).Where(t=>t.ProductSatus==true).Sum(z=>z.ProductStock);
			lblProductCountByCategoryDrinkAndStatusTrue.Text= productDrinkTrueStatus.ToString();

			//Türkiye`den yapılan Siparişler
			var productOrderFromTurkey = db.TblOrder.Where(x=>x.TblCustomer.CustomerCountry=="Türkiye").Sum(x=>x.Count);
			lblOrderCountFromTurkeyByEf.Text= productOrderFromTurkey.ToString();

			//Türkiye`den yapılan Sipraişler(sql query)
			var productOrderFromTurkeyBySql = db.Database.SqlQuery<int>("select sum(Count) from TblOrder where OrderCustomerId In(select CustomerId from TblCustomer where TblCustomer.CustomerCountry = 'Türkiye')").FirstOrDefault();
			lblOrderCountFromTurkeyBySql.Text=productOrderFromTurkeyBySql.ToString();

			//Kategorisi Meyve Olanların Toplam Satış Fiyatı (sql query)
			var productOrderCategoryByMeyve = db.Database.SqlQuery<decimal>("select sum(o.TotalPrice) from TblOrder o join TblProduct p on o.OrderProductId=p.ProductCategoryId join TblCategory c on p.ProductCategoryId=c.CategoryId where c.CategoryName='Meyve'").FirstOrDefault();
			lblProductCategoryByMeyve.Text= productOrderCategoryByMeyve.ToString() + " ₺";

			//Kategorisi Meyve Olanların Toplam Satış Fiyatı (EF)
			var productOrderCategoryByMeyveEf = (from o in db.TblOrder
												 join p in db.TblProduct on o.OrderProductId equals p.ProductId
												 join c in db.TblCategory on p.ProductCategoryId equals c.CategoryId
												 where c.CategoryName == "Meyve"
												 select o.TotalPrice
												).Sum();
			lblProductCategoryByMeyveEf.Text = productOrderCategoryByMeyveEf.ToString()+" ₺";


			//Son Eklenen Ürünün İsmi
			var lastProductName = db.TblProduct.OrderByDescending(x => x.ProductId).Select(x=>x.ProductName).FirstOrDefault();
			lblLastProductName.Text= lastProductName.ToString();

			//Son Eklenen Ürünün kategorisi
			var lastProductCategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(x => x.ProductCategoryId).FirstOrDefault();
			var lastProductCategoryNAME =db.TblCategory.Where(x=>x.CategoryId==lastProductCategoryId).Select(y=>y.CategoryName).FirstOrDefault();
			lblLastProductCategoryName.Text= lastProductCategoryNAME.ToString();

			//Aktif Ürün Sayısı
			var productStatusTrue=db.TblProduct.Where(x=>x.ProductSatus == true).Count();
			lblProductStatusTrue.Text= productStatusTrue.ToString();

			//Toplam Kola Stok Satışlarından Kazanılan Para
			var totalColaStock = db.TblProduct.Where(x=>x.ProductName=="Kola").Select(y=>y.ProductStock).FirstOrDefault();
			var totalPrice = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductPrice).FirstOrDefault();

			var total=Convert.ToInt32(totalColaStock)*Convert.ToInt32(totalPrice);
			lblTotalColaPrice.Text= total+" ₺";

			//Son İşlemi Yapan Kişi
			var lastOrderCustomerId=db.TblOrder.OrderByDescending(x=>x.OrderCustomerId).Select(x=>x.OrderProductId).FirstOrDefault();
			var lastOrderCustomerName=db.TblCustomer.Where(x=>x.CustomerId==lastOrderCustomerId).Select(y=>y.CustomerName).FirstOrDefault();
			lblLastOrderCustomerName.Text=lastOrderCustomerName.ToString();

			//Kaç Farklı Ülke var
			var countryCount = db.TblCustomer.Select(x => x.CustomerCountry).Distinct().Count();
			lblCountryCount.Text= countryCount.ToString();



		}

	}
}
