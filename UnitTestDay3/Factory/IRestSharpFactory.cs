using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDay3.NetTools;

namespace UnitTestDay3.Factory
{
    /// <summary>
    /// 製作IRestSharp的工廠
    /// </summary>
    internal class IRestSharpFactory
    {
        /// <summary>
        /// 此屬性只供UnitTest注入
        /// </summary>
        internal static IRestSharp _IRestSharpForUnitTest;

        internal static IRestSharp Generate()
        {
            //如果這個值不為Null,則表示單元測試所注入,直接回傳
            if (_IRestSharpForUnitTest != null)
            {
                return _IRestSharpForUnitTest;
            }

            //產生實體
            return new MyRestSharp();
        }
    }
}
