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
        }
        static void Main(string[] args)
        {
            DoJob();
        }
    }
}
