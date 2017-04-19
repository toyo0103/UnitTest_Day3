using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDay3;

namespace UnitTestDay3Tests.Stub
{
    public class PTXStub :PTX
    {
        /// <summary>
        /// 用來模擬API回傳的Json Result
        /// </summary>
        public string CallAPIResult;
        protected override string CallAPI(string city, string routeName)
        {
            if (!string.IsNullOrEmpty(CallAPIResult))
            {
                return CallAPIResult;
            }

            return  base.CallAPI(city, routeName);
        }
    }
}
