using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using UnitTestDay3.NetTools;

namespace UnitTestDay3
{
    public class PTX
    {
        IRestSharp _MyRestSharp;

        /// <summary>
        /// Construct
        /// </summary>
        /// <param name="myRestSharp">外部注入呼叫API的實體</param>
        public PTX(IRestSharp myRestSharp)
        {
            //改由外部注入呼叫API的實體
            this._MyRestSharp = myRestSharp;
        }

        /// <summary>
        /// 取得巴士路線資料
        /// </summary>
        /// <param name="city">縣市名稱</param>
        /// <param name="routeName">巴士路線名稱</param>
        /// <returns></returns>
        public BusRouteDTO Get(string city,string routeName)
        {
            BusRouteDTO Result = null;

            //要呼叫的API Url
            string Url = string.Format($"http://ptx.transportdata.tw/MOTC/v2/Bus/StopOfRoute/City/{city}/{routeName}?%24top=1&%24format=JSON");

            var JsonResult = _MyRestSharp.Get(Url);

            if (!string.IsNullOrEmpty(JsonResult))
            {
                var APIResult = JsonConvert.DeserializeObject<List<PTXBusRouteResult>>(JsonResult);

                if (APIResult != null && APIResult.Count > 0)
                {
                    var Route = APIResult.First();
                    Result = new BusRouteDTO
                    {
                        Name = Route.RouteName.Zh_tw,
                        BusStops = new List<BusRouteDTO.BusStop>()
                    };

                    foreach (var stop in Route.Stops)
                    {
                        Result.BusStops.Add(new BusRouteDTO.BusStop
                        {
                            ID = stop.StopUID,
                            Name = stop.StopName.Zh_tw
                        });
                    }
                }
            }
    
            return Result;
        }
    }
}
