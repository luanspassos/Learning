namespace Learning
{
    internal class Program
    {
        private static void DoJob()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Task t = new Task(DoJob);
            t.Start();

            Console.ReadKey();

        }
    }
}
