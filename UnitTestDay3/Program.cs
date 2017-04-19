using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace UnitTestDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            var PTXFunction = new PTX();

            var Result = PTXFunction.Get("Taipei","307");

            Console.Write(JsonConvert.SerializeObject(Result));

            Console.ReadKey();
        }
    }
}
