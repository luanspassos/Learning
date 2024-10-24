namespace Learning
{
    internal class Program
    {
        private static void DoJob()
        {
            Thread.Sleep(1000);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Task t = new Task(DoJob);
            t.Start();

            Task t2 = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                }
            });

            Console.ReadKey();
        }
    }
}
