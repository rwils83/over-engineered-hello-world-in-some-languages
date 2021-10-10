using System;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        async static Task Main(string[] args)
        {
            IHelloWorldController helloWorldController = new HelloWorldController();
            IOutputController outputController = new OutputController();

            string helloWorldString = await helloWorldController.GetHelloWorldStringAsync();
            outputController.Output(helloWorldString);
        }
    }

    interface IHelloWorldController
    {
        Task<string> GetHelloWorldStringAsync();
    }

    interface IOutputController
    {
        void Output(string value);
    }

    /// <summary>
    /// This class can retrieve the desired "Hello World!" value asynchronously by creating a new Thread via the Task.Run Method.
    /// </summary>
    class HelloWorldController : IHelloWorldController
    {
        private string getHelloWorld() { return "Hello World!"; }

        private Func<string> helloWorldFunc => getHelloWorld;

        public async Task<string> GetHelloWorldStringAsync()
        {
            return await Task.Run(helloWorldFunc);
        }
    }

    /// <summary>
    /// This class can output ANY string value you desire.
    /// </summary>
    class OutputController : IOutputController
    {
        public void Output(string value)
        {
            Console.WriteLine(value);
        }
    }
}
