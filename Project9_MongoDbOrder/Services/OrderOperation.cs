using MongoDB.Bson;
using MongoDB.Driver;
using Project9_MongoDbOrder.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDbOrder.Services
{
	public class OrderOperation
	{
		public void AddOrder(Order order)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();

			var document = new BsonDocument
			{
				{ "OrderCity", order.City},
				{ "District",order.District},
				{ "CustomerName",order.CustomerName},
				{ "TotalPrice" , order.TotalPrice}
			};
			orderCollection.InsertOne(document);
		}

		public List<Order> GetAllOrders()
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();

			var orders = orderCollection.Find(new BsonDocument()).ToList();

			List<Order> orderList = new List<Order>();

			foreach (var item in orders)
			{
				orderList.Add(new Order
				{
					OrderId = item["_id"].ToString(),
					CustomerName = item["CustomerName"].ToString(),
					District = item["District"].ToString(),
					City = item["OrderCity"].ToString(),
					TotalPrice = item["TotalPrice"].AsDecimal
				});
			}
			return orderList;
		}

		public void DeleteOrder(string orderId)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();
			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
			orderCollection.DeleteOne(filter);
		}

		public void UpdateOrder(Order order)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();
			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
			var updatedValue = Builders<BsonDocument>.Update
				.Set("CustomerName", order.CustomerName)
				.Set("OrderCity", order.City)
				.Set("District", order.District)
				.Set("TotalPrice", order.TotalPrice);
			orderCollection.UpdateOne(filter, updatedValue);
		}

		public Order GetById(string id)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

			var result=orderCollection.Find(filter).FirstOrDefault();
			if (result != null)
			{
				return new Order
				{
					
					City = result["OrderCity"].ToString(),
					District = result["District"].ToString(),
					TotalPrice = decimal.Parse(result["TotalPrice"].ToString()),
					CustomerName = result["CustomerName"].ToString()
				};
			}
			else
			{
				return null;
			}

		}
	}
}
