using System;
using System.Threading.Tasks;

namespace introtoasynmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Staring in Main method");
            Run();
            Console.WriteLine("Ending in Main method");
        }
        static async void Run()
        {
            Task<int> r = Worker();
            await r;
            Console.WriteLine("The result is " + r.Result);
        }
        static Task<int> Worker()
        {
            return Task<int>.Factory.StartNew(() =>
            {
                int counter = 0;
                for (int i = 0; i < 100000; i++)
                {
                    counter += i;
                }
                return counter;
            });
        }
    }
}
