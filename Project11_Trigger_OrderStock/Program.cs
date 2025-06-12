using Project11_Trigger_OrderStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project11_Trigger_OrderStock
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyProject11Entities context = new MyProject11Entities();

			string number;
			Console.WriteLine("### Sipariş Stok Sistemi");
			Console.WriteLine();
			Console.WriteLine("1-ürün Listesi");
			Console.WriteLine("2-Sipariş Listesi");
			Console.WriteLine("3-Kasa Durumu");
			Console.WriteLine("4-Yeni Ürün Satışı");
			Console.WriteLine("5-İşlem Sayacı");
			Console.WriteLine();
			Console.WriteLine("------------------------");

			Console.Write("Lütfen Yapmak istediğiniz İşlemi Seçin: :");
			number = Console.ReadLine();
			Console.WriteLine();

			if (number == "1")
			{
                Console.WriteLine("Ürün Listesi");
                Console.WriteLine("------------");
                Console.WriteLine();
                var values = context.TblProduct.ToList();
				foreach (var item in values)
				{
					Console.WriteLine(item.ProductId + " - " +item.ProductName+" -Stok Sayısı: "+item.ProductStock+" -Fiyatı: "+item.ProductPrice+" TL");
				}
			}
			if (number=="2")
			{
                Console.WriteLine("Sipariş Listesi");
                Console.WriteLine("---------------");
                Console.WriteLine();
                var values = context.TblOrder.ToList();
				
				foreach (var item in values)
				{
					var productName = context.TblProduct.Where(x => x.ProductId == item.ProductId).Select(y => y.ProductName).FirstOrDefault();
					Console.WriteLine(item.OrderId+"- Müşteri: "+item.Customer+" - Ürün Adı: "+productName+" - Adet: "+item.Quantity +" - Adet Fiyatı: "+item.UnitPrice+" - Toplam Fiyat: "+item.TotalPrice);
                }

			}
			if (number=="3")
			{
				var values = context.TblCashRegister.Select(x=>x.Ballance).FirstOrDefault();
                Console.WriteLine("Kasa Durumu");
                Console.WriteLine("---------");
                Console.WriteLine("Kasa: "+values);
            }
			if (number=="4")
			{
                Console.WriteLine("Yeni Ürün Satışı");
                Console.WriteLine("-----------------");
                Console.WriteLine();
                Console.WriteLine("Müşteri Adını Giriniz: ");
                string CustomerName=Console.ReadLine();
				Console.WriteLine("Ürün Id Giriniz: ");
				int productId = int.Parse(Console.ReadLine());
				var productName = context.TblProduct.Where(x => x.ProductId == productId).Select(y => y.ProductName).FirstOrDefault();
				Console.WriteLine("Adet Sayısını Giriniz: ");
				int quantity=int.Parse(Console.ReadLine());
				var unitPrice=context.TblProduct.Where(x=>x.ProductId==productId).Select(y=>y.ProductPrice).FirstOrDefault();
				decimal totalPrice=quantity*decimal.Parse(unitPrice.ToString());

                Console.WriteLine();
                Console.WriteLine("Sipariş Bilgileri");
                Console.WriteLine("------------------");
                Console.WriteLine();
				Console.WriteLine("Müşteri Adı: "+CustomerName);
				Console.WriteLine("Ürün Adı: "+productName);
                Console.WriteLine("Toplam Fiyat "+totalPrice);
                
				TblOrder order=new TblOrder();
				order.Customer = CustomerName;
				order.ProductId = productId;
				order.Quantity = quantity;
				order.UnitPrice = decimal.Parse(unitPrice.ToString());
				order.TotalPrice = totalPrice;
				context.TblOrder.Add(order);
				context.SaveChanges();

            }
			if (number=="5")
			{
				var value=context.TblProcess.Select(x=>x.Process).FirstOrDefault();
                Console.WriteLine("Toplam İşlem Sayısı: "+value);
            }

			Console.ReadLine();
		}
	}
}
