namespace ProducerConsumer
{
    using System;
    using System.Threading;
    using System.Collections.Concurrent;

    class Program
    {
        static void Main(string[] args)
        {
            var messages = new BlockingCollection<string>(5); // Limita la capacidad a 5 mensajes
            var producer = new Thread(() =>
            {
                Console.WriteLine("----- Producing messages -----");
                for (int i = 1; i <= 10; i++)
                {
                    messages.Add($"Message {i}");
                    Console.WriteLine($"[Producer]: Message {i}");
                    Thread.Sleep(50); // Simulate time taken to produce a message
                }
                messages.CompleteAdding();
                //Console.WriteLine("----- All messages have been produced. -----");
            });
            
            var consumer1 = new Thread(() => ConsumeMessages(messages));
            consumer1.Name = "Consumer 1";
            var consumer2 = new Thread(() => ConsumeMessages(messages));
            consumer2.Name = "Consumer 2";

            Task.Run(() => producer.Start());
            Task.Run(() => consumer1.Start());
            Task.Run(() => consumer2.Start());

            Task.WaitAll(
                Task.Run(() => producer.Join()),
                Task.Run(() => consumer1.Join()),
                Task.Run(() => consumer2.Join())
            );

            Console.WriteLine("Processing complete. Press any key to exit.");
            Console.ReadKey();
        }

        public static void ConsumeMessages(BlockingCollection<string> messages)
        {
            try
            {
                int count = 0;
                foreach (var message in messages.GetConsumingEnumerable())
                {
                    Thread.Sleep(1000); // Simulate processing time
                    Console.WriteLine($"[{Thread.CurrentThread.Name}]: Consumed: {message}");
                    count++;
                }
                Console.WriteLine($"----- {Thread.CurrentThread.Name} has consumed {count} messages -----");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}