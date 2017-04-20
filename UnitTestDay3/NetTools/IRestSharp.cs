using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDay3.NetTools
{
    public interface IRestSharp
    {
        /// <summary>
        /// 用Get的方法呼叫API
        /// </summary>
        /// <param name="url">Url</param>
        /// <returns>回傳的內容</returns>
        string Get(string url);
    }
}
