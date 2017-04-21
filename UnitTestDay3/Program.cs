using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnitTestDay3.NetTools;

namespace UnitTestDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            //new PTX時變成要帶入呼叫API的實體
            var PTXFunction = new PTX();

            var Result = PTXFunction.Get("Taipei","307");

            Console.Write(JsonConvert.SerializeObject(Result));

            Console.ReadKey();
        }
    }
}
