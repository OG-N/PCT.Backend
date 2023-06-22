using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;
using PCT.Backend.Entities;

namespace PCT.Backend.Utils
{
    public static class MiddlewareAdapter
    {
        public static ServiceBusClient client = new ServiceBusClient("Endpoint=sb://gscih-dev.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=Q9JB5dtPzAeBSRcnlf+PxEj1MQbEjpaeL+ASbCzVV7g=");

        public static async void PostLocationToMiddleWare(Location location)
        {
            try
            {
                var json = JsonConvert.SerializeObject(location);
                ServiceBusSender sender = client.CreateSender("location");
                await PostContentToMiddleware(client, sender, json);
                Console.WriteLine("Location " + location.Name + ": posted successfully to middleware");
            }
            catch (Exception e)
            {
                Console.WriteLine("Location " + location.Name + ": " + e.Message);
            }
        }

        public static async void PostCarrierToMiddleWare(Carrier carrier)
        {
            try
            {
                var json = JsonConvert.SerializeObject(carrier);
                ServiceBusSender sender = client.CreateSender("carrier");
                await PostContentToMiddleware(client, sender, json);
                Console.WriteLine("Carrier " + carrier.Name + ": posted successfully to middleware");
            }
            catch (Exception e)
            {
                Console.WriteLine("Carrier " + carrier.Name + ": " + e.Message);
            }
        }

        public static async void PostProductToMiddleWare(Product product)
        {
            try
            {
                var json = JsonConvert.SerializeObject(product);
                ServiceBusSender sender = client.CreateSender("product");
                await PostContentToMiddleware(client, sender, json);
                Console.WriteLine("Product " + product.Name + ": posted successfully to middleware");
            }
            catch (Exception e)
            {
                Console.WriteLine("Product " + product.Name + ": " + e.Message);
            }
        }

        public static async void PostVendorToMiddleWare(Vendor vendor)
        {
            try
            {
                var json = JsonConvert.SerializeObject(vendor);
                ServiceBusSender sender = client.CreateSender("vendor");
                await PostContentToMiddleware(client, sender, json);
                Console.WriteLine("Vendor " + vendor.Name + ": posted successfully to middleware");
            }
            catch (Exception e)
            {
                Console.WriteLine("Vendor " + vendor.Name + ": " + e.Message);
            }
        }

        private static async Task<string> PostContentToMiddleware(ServiceBusClient client, ServiceBusSender sender, string content)
        {
            try
            {
                using (ServiceBusMessageBatch message = await sender.CreateMessageBatchAsync())
                {
                    message.TryAddMessage(new ServiceBusMessage(content));
                    try
                    {
                        await sender.SendMessagesAsync(message);
                    }
                    finally
                    {
                        await sender.DisposeAsync();
                        await client.DisposeAsync();
                    }
                }
                return "content posted successfully";
            }
            catch
            {
                throw;
            }
        }
    }
}
