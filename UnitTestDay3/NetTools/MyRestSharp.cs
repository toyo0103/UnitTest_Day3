using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDay3.NetTools
{
    public class MyRestSharp : IRestSharp
    {
        /// <summary>
        /// 用Get的方法呼叫API
        /// </summary>
        /// <param name="url">Url</param>
        /// <returns>回傳的內容</returns>
        public string Get(string url)
        {
            //Use RestSharp Call API
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Content;
            }

            return string.Empty;
        }
    }
}
