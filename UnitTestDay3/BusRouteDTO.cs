using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDay3
{
    /// <summary>
    /// 巴士路線
    /// </summary>
    public class BusRouteDTO
    {
        /// <summary>
        /// 路線名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 巴士站列表
        /// </summary>
        public List<BusStop> BusStops { get; set; }

        /// <summary>
        /// 巴士站
        /// </summary>
        public class BusStop
        {
            /// <summary>
            /// 站名
            /// </summary>
            public string Name { get; set; }

            public string ID { get; set; }
        }
    }
}
