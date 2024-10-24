namespace Learning
{
    internal class Program
    {
        private static void DoJob()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Thread.Sleep(2000);
        }
        static void Main(string[] args)
        {
            Task t = new Task(DoJob);
            t.Start();
            t.Wait();

            Task t2 = Task.Run(() => DoJob());
            t2.Wait();

            Task.Run(() => DoJob()).Wait();

            Task.Factory.StartNew(DoJob);

            Console.ReadKey();
        }
    }
}
