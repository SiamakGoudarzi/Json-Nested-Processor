using System;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace JasonSerializedDeserialized
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string json = "{ \"_status\":\"saved\", \"agentId\":\"guid-id-here\", \"data\":\"{\\\"price\\\":[\\\"3500\\\",\\\"4000\\\"],\\\"offerprice\\\":[\\\"3200\\\",\\\"3800\\\"],\\\"title\\\":\\\"Wireless Headphone Model X\\\",\\\"title_en\\\":\\\"Wireless Headphone Model X\\\",\\\"color\\\":[\\\"Black\\\",\\\"White\\\"],\\\"color_hex\\\":[\\\"#000000\\\",\\\"#ffffff\\\"],\\\"img\\\":\\\"https://example.com/image.jpg\\\",\\\"status\\\":\\\"valid\\\",\\\"availability\\\":\\\"marketable\\\"}\", \"fetchStrategyId\":1, \"id\":\"12345\", \"queuedAt\":\"1/2/2025 2:24:37 AM\", \"snapshotStrategyId\":4, \"stat\":\"{}\", \"status\":\"{\\\"status\\\":\\\"saved\\\"}\", \"targetId\":12345, \"taskId\":\"task-id-here\", \"timeStamp\":\"1/2/2025 2:24:37 AM\", \"updateAt\":\"1/2/2025 2:24:37 AM\" }";



            Product product = JsonConvert.DeserializeObject<Product>(json);
            var dataObject = JsonConvert.DeserializeObject<Data>(product.Data);
            dataObject.ProcessData();


            //Print minimum price 
            Console.WriteLine($"Minimum Price: {product.MinPrice}");

            //Print color, price und offer price information
            Console.WriteLine("Prices by color:");
            foreach (var entry in dataObject.PriceAndOfferpriceByColor)
            {
                Console.WriteLine($"Color: {entry.Key}, Price: {entry.Value.Item1}, Offer Price: {entry.Value.Item2}");
            }
          

            Console.ReadKey();
        }
    }
}
