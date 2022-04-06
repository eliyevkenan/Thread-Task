using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp75
{
    internal class Shop
    {
        public List<Order> orders=new List<Order>();
        public void AddOrder(Order order)
        {
            if (order==null)
            {
                throw new Exception("Xeta");
            }
            orders.Add(order);
        }
        public void RemoveOrderByNo(int? no)
        {
            if (no==null)
            {
                throw new Exception("xeta");
            }
            var result = orders.Find(x => x.No == no);
            if (result==null)
            {
                throw new Exception("Xeta");
            }
            orders.Remove(result);
            
        }
        public List<Order> FilteredOrderByPrice(int min,int max)
        {
            var result=orders.FindAll(x=>x.TotalAmount>min && x.TotalAmount<max);
            if (result.Count == 0)
            {
                throw new Exception("Xeta");
            }   
            return result;
        }
        public double GetOrdersAvg()
        {
            if (orders.Count!=0)
            {
                double sum = 0;
                foreach (var item in orders)
                {
                    sum += item.TotalAmount;
                }
                sum /= orders.Count;
                return sum;
            }
            return 0; 
        }
        public Double GetOrdersAvg(DateTime time)
        {
            var result = orders.FindAll(x => x.CreatedAt > time);
            double sum = 0;
            foreach (var order in result)
            {
                sum = sum + order.TotalAmount;
            }
            return sum/result.Count;
        }
    }
}
