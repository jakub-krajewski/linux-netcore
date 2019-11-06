using System;
using System.Threading.Tasks;
namespace basicTests
{
    class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine("Wait for it... for a few seconds!");
            await Task.Delay(3000);
            Console.WriteLine("Hello World!");
        }
    }
}
