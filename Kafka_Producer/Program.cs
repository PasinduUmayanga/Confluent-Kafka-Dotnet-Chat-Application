using Confluent.Kafka;
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        var conf = new ProducerConfig
        {
            //BootstrapServers = "localhost:9092",
            BootstrapServers = "172.20.2.8:9092",
        };
        string val = string.Empty;
        while (val != "test")
        {
            Console.WriteLine("Producer -->");
            val = Console.ReadLine();
            //Action<DeliveryReport<Null, string>> handler = r =>
            //    Console.WriteLine(!r.Error.IsError
            //        ? $"Delivered message to {r.TopicPartitionOffset}"
            //        : $"Delivery Error: {r.Error.Reason}");

            using (var p = new ProducerBuilder<Null, string>(conf).Build())
            {

                p.Produce("my-topic", new Message<Null, string> { Value = val });
                //p.Produce("my-topic", new Message<Null, string> { Value = val }, handler);


                // wait for up to 10 seconds for any inflight messages to be delivered.
                p.Flush(TimeSpan.FromSeconds(10));
            }
        }
    }
}