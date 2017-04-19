﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDay3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDay3Tests.Stub;

namespace UnitTestDay3.Tests
{
    [TestClass()]
    public class PTXTests
    {
        [TestMethod()]
        public void GetTest_傳入縣市和公車路線名稱_如果查的到資料_應回傳該路線的BusRouteDTO()
        {
            //arrange
            var Sut = new PTXStub(); //改成PTXStub
            var City = "Taipei";
            var RouteName = "307";

            //API應該回傳的結果
            var sb = new System.Text.StringBuilder(12766);
            sb.AppendLine(@"[{""RouteUID"":""TPE16111"",""RouteID"":""16111"",""RouteName"":{""Zh_tw"":""307"",""En"":""307""},""KeyPattern"":false,""SubRouteUID"":""TPE157462"",""SubRouteID"":""157462"",""SubRouteName"":{""Zh_tw"":""307莒光經板橋前站"",""En"":""307""},""Direction"":0,""Stops"":[{""StopUID"":""TPE15294"",""StopID"":""15294"",""StopName"":{""Zh_tw"":""莊敬里"",""En"":""Zhuangjing Li""},""StopBoarding"":0,""StopSequence"":1,""StopPosition"":{""PositionLat"":25.0650329589844,""PositionLon"":121.565574645996}},{""StopUID"":""TPE15296"",""StopID"":""15296"",""StopName"":{""Zh_tw"":""新益里"",""En"":""Xinyi Li""},""StopBoarding"":0,""StopSequence"":2,""StopPosition"":{""PositionLat"":25.0620059967041,""PositionLon"":121.56616973877}},{""StopUID"":""TPE15298"",""StopID"":""15298"",""StopName"":{""Zh_tw"":""民生國中"",""En"":""Minsheng Junior High School""},""StopBoarding"":0,""StopSequence"":3,""StopPosition"":{""PositionLat"":25.0596618652344,""PositionLon"":121.567924499512}},{""StopUID"":""TPE15299"",""StopID"":""15299"",""StopName"":{""Zh_tw"":""新東里"",""En"":""Xindong Li""},""StopBoarding"":0,""StopSequence"":4,""StopPosition"":{""PositionLat"":25.0578899383545,""PositionLon"":121.569030761719}},{""StopUID"":""TPE15300"",""StopID"":""15300"",""StopName"":{""Zh_tw"":""發電所"",""En"":""Power Sta.""},""StopBoarding"":0,""StopSequence"":5,""StopPosition"":{""PositionLat"":25.0557422637939,""PositionLon"":121.569465637207}},{""StopUID"":""TPE15301"",""StopID"":""15301"",""StopName"":{""Zh_tw"":""南松山(塔悠)"",""En"":""Nansongshan""},""StopBoarding"":0,""StopSequence"":6,""StopPosition"":{""PositionLat"":25.0519313812256,""PositionLon"":121.570152282715}},{""StopUID"":""TPE15302"",""StopID"":""15302"",""StopName"":{""Zh_tw"":""南松山(南京)"",""En"":""Nansongshan""},""StopBoarding"":0,""StopSequence"":7,""StopPosition"":{""PositionLat"":25.0515155792236,""PositionLon"":121.569061279297}},{""StopUID"":""TPE15303"",""StopID"":""15303"",""StopName"":{""Zh_tw"":""南京公寓(捷運南京三民)"",""En"":""Nanjing Apartment(MRT Nanjing Sanmin)""},""StopBoarding"":0,""StopSequence"":8,""StopPosition"":{""PositionLat"":25.0514755249023,""PositionLon"":121.566452026367}},{""StopUID"":""TPE15304"",""StopID"":""15304"",""StopName"":{""Zh_tw"":""南京三民路口"",""En"":""Nanjing   Sanmin Intersection""},""StopBoarding"":0,""StopSequence"":9,""StopPosition"":{""PositionLat"":25.0515594482422,""PositionLon"":121.561126708984}},{""StopUID"":""TPE15305"",""StopID"":""15305"",""StopName"":{""Zh_tw"":""南京寧安街口"",""En"":""NanJing-NingAn Intersection""},""StopBoarding"":0,""StopSequence"":10,""StopPosition"":{""PositionLat"":25.051607131958,""PositionLon"":121.555244445801}},{""StopUID"":""TPE15306"",""StopID"":""15306"",""StopName"":{""Zh_tw"":""南京敦化路口(小巨蛋)"",""En"":""Nanjing   Dunhua Intersection(Arena)""},""StopBoarding"":0,""StopSequence"":11,""StopPosition"":{""PositionLat"":25.0517673492432,""PositionLon"":121.549346923828}},{""StopUID"":""TPE15307"",""StopID"":""15307"",""StopName"":{""Zh_tw"":""捷運南京復興站"",""En"":""MRT Nanjing Fuxing Station""},""StopBoarding"":0,""StopSequence"":12,""StopPosition"":{""PositionLat"":25.0518646240234,""PositionLon"":121.544425964355}},{""StopUID"":""TPE15308"",""StopID"":""15308"",""StopName"":{""Zh_tw"":""南京龍江路口"",""En"":""Nanjing   Longjiang Intersection""},""StopBoarding"":0,""StopSequence"":13,""StopPosition"":{""PositionLat"":25.0519790649414,""PositionLon"":121.540771484375}},{""StopUID"":""TPE15309"",""StopID"":""15309"",""StopName"":{""Zh_tw"":""南京建國路口"",""En"":""Nanjing   Jianguo Intersection""},""StopBoarding"":0,""StopSequence"":14,""StopPosition"":{""PositionLat"":25.0520095825195,""PositionLon"":121.537246704102}},{""StopUID"":""TPE15310"",""StopID"":""15310"",""StopName"":{""Zh_tw"":""捷運松江南京站"",""En"":""MRT Songjiang Nanjing Stop""},""StopBoarding"":0,""StopSequence"":15,""StopPosition"":{""PositionLat"":25.052074432373,""PositionLon"":121.533363342285}},{""StopUID"":""TPE15311"",""StopID"":""15311"",""StopName"":{""Zh_tw"":""南京吉林路口"",""En"":""Nanjing   Jilin Intersection""},""StopBoarding"":0,""StopSequence"":16,""StopPosition"":{""PositionLat"":25.0520973205566,""PositionLon"":121.529403686523}},{""StopUID"":""TPE15312"",""StopID"":""15312"",""StopName"":{""Zh_tw"":""南京林森路口"",""En"":""Nanjing   Linsen Intersection""},""StopBoarding"":0,""StopSequence"":17,""StopPosition"":{""PositionLat"":25.052209854126,""PositionLon"":121.525680541992}},{""StopUID"":""TPE15313"",""StopID"":""15313"",""StopName"":{""Zh_tw"":""中山市場"",""En"":""ZhongShan Market""},""StopBoarding"":0,""StopSequence"":18,""StopPosition"":{""PositionLat"":25.0512638092041,""PositionLon"":121.522018432617}},{""StopUID"":""TPE15314"",""StopID"":""15314"",""StopName"":{""Zh_tw"":""行政院"",""En"":""Executive Yuan""},""StopBoarding"":0,""StopSequence"":19,""StopPosition"":{""PositionLat"":25.0465602874756,""PositionLon"":121.519760131836}},{""StopUID"":""TPE15315"",""StopID"":""15315"",""StopName"":{""Zh_tw"":""臺北車站(忠孝)"",""En"":""Taipei Main Sta. (Zhongxiao)""},""StopBoarding"":0,""StopSequence"":20,""StopPosition"":{""PositionLat"":25.046516418457,""PositionLon"":121.516815185547}},{""StopUID"":""TPE15316"",""StopID"":""15316"",""StopName"":{""Zh_tw"":""中華路北站"",""En"":""Zhonghua Rd. N. Stop""},""StopBoarding"":0,""StopSequence"":21,""StopPosition"":{""PositionLat"":25.0457744598389,""PositionLon"":121.509178161621}},{""StopUID"":""TPE15317"",""StopID"":""15317"",""StopName"":{""Zh_tw"":""捷運西門站"",""En"":""MRT Ximen Sta.""},""StopBoarding"":0,""StopSequence"":22,""StopPosition"":{""PositionLat"":25.0425281524658,""PositionLon"":121.508232116699}},{""StopUID"":""TPE15318"",""StopID"":""15318"",""StopName"":{""Zh_tw"":""小南門"",""En"":""Xiaonanmen""},""StopBoarding"":0,""StopSequence"":23,""StopPosition"":{""PositionLat"":25.0381145477295,""PositionLon"":121.506851196289}},{""StopUID"":""TPE15319"",""StopID"":""15319"",""StopName"":{""Zh_tw"":""聯合醫院和平院區"",""En"":""Hoping Hospital""},""StopBoarding"":0,""StopSequence"":24,""StopPosition"":{""PositionLat"":25.0364627838135,""PositionLon"":121.506385803223}},{""StopUID"":""TPE15320"",""StopID"":""15320"",""StopName"":{""Zh_tw"":""大埔街"",""En"":""Dapu St.""},""StopBoarding"":0,""StopSequence"":25,""StopPosition"":{""PositionLat"":25.0321769714355,""PositionLon"":121.504524230957}},{""StopUID"":""TPE15321"",""StopID"":""15321"",""StopName"":{""Zh_tw"":""莒光派出所"",""En"":""Juguang Police Substation""},""StopBoarding"":0,""StopSequence"":26,""StopPosition"":{""PositionLat"":25.0314102172852,""PositionLon"":121.502983093262}},{""StopUID"":""TPE15322"",""StopID"":""15322"",""StopName"":{""Zh_tw"":""萬大路"",""En"":""Wanda Rd.""},""StopBoarding"":0,""StopSequence"":27,""StopPosition"":{""PositionLat"":25.0300426483154,""PositionLon"":121.500450134277}},{""StopUID"":""TPE15323"",""StopID"":""15323"",""StopName"":{""Zh_tw"":""西藏路口"",""En"":""Xizang Rd. Entrance""},""StopBoarding"":0,""StopSequence"":28,""StopPosition"":{""PositionLat"":25.0280418395996,""PositionLon"":121.500282287598}},{""StopUID"":""TPE15324"",""StopID"":""15324"",""StopName"":{""Zh_tw"":""德昌街口"",""En"":""Dechang St. Entrance""},""StopBoarding"":0,""StopSequence"":29,""StopPosition"":{""PositionLat"":25.0255146026611,""PositionLon"":121.500205993652}},{""StopUID"":""TPE15325"",""StopID"":""15325"",""StopName"":{""Zh_tw"":""萬大國小"",""En"":""Wanda Elementary School""},""StopBoarding"":0,""StopSequence"":30,""StopPosition"":{""PositionLat"":25.0240383148193,""PositionLon"":121.500099182129}},{""StopUID"":""TPE15326"",""StopID"":""15326"",""StopName"":{""Zh_tw"":""果菜市場"",""En"":""Wholesale Fruit and Vegetable Market""},""StopBoarding"":0,""StopSequence"":31,""StopPosition"":{""PositionLat"":25.0198040008545,""PositionLon"":121.497436523438}},{""StopUID"":""TPE15327"",""StopID"":""15327"",""StopName"":{""Zh_tw"":""華中橋"",""En"":""Huazhong Bridge""},""StopBoarding"":0,""StopSequence"":32,""StopPosition"":{""PositionLat"":25.0031890869141,""PositionLon"":121.496505737305}},{""StopUID"":""TPE15328"",""StopID"":""15328"",""StopName"":{""Zh_tw"":""連城景平路"",""En"":""Liancheng   Jingping Rd.""},""StopBoarding"":0,""StopSequence"":33,""StopPosition"":{""PositionLat"":24.9996032714844,""PositionLon"":121.496124267578}},{""StopUID"":""TPE15329"",""StopID"":""15329"",""StopName"":{""Zh_tw"":""連城板南路"",""En"":""Liancheng Bannan Rd.""},""StopBoarding"":0,""StopSequence"":34,""StopPosition"":{""PositionLat"":24.9982566833496,""PositionLon"":121.494895935059}},{""StopUID"":""TPE15330"",""StopID"":""15330"",""StopName"":{""Zh_tw"":""台貿一村"",""En"":""Taimao Village 1""},""StopBoarding"":0,""StopSequence"":35,""StopPosition"":{""PositionLat"":24.9967308044434,""PositionLon"":121.492218017578}},{""StopUID"":""TPE15331"",""StopID"":""15331"",""StopName"":{""Zh_tw"":""連城錦和路口"",""En"":""Liancheng Jinhe Rd. Entrance""},""StopBoarding"":0,""StopSequence"":36,""StopPosition"":{""PositionLat"":24.9964542388916,""PositionLon"":121.490203857422}},{""StopUID"":""TPE15332"",""StopID"":""15332"",""StopName"":{""Zh_tw"":""連城中正路口"",""En"":""Liancheng Zhongzheng Rd. Entrance""},""StopBoarding"":0,""StopSequence"":37,""StopPosition"":{""PositionLat"":24.9963359832764,""PositionLon"":121.486465454102}},{""StopUID"":""TPE15333"",""StopID"":""15333"",""StopName"":{""Zh_tw"":""連城路"",""En"":""Liancheng Rd.""},""StopBoarding"":0,""StopSequence"":38,""StopPosition"":{""PositionLat"":24.996000289917,""PositionLon"":121.483306884766}},{""StopUID"":""TPE15334"",""StopID"":""15334"",""StopName"":{""Zh_tw"":""中和高中"",""En"":""Zhonghe High School""},""StopBoarding"":0,""StopSequence"":39,""StopPosition"":{""PositionLat"":24.9959468841553,""PositionLon"":121.481140136719}},{""StopUID"":""TPE15335"",""StopID"":""15335"",""StopName"":{""Zh_tw"":""員山派出所"",""En"":""Yuanshan Police Substation""},""StopBoarding"":0,""StopSequence"":40,""StopPosition"":{""PositionLat"":24.99827003479,""PositionLon"":121.481094360352}},{""StopUID"":""TPE15336"",""StopID"":""15336"",""StopName"":{""Zh_tw"":""積穗國中"",""En"":""Jisui Junior High School""},""StopBoarding"":0,""StopSequence"":41,""StopPosition"":{""PositionLat"":25.0006008148193,""PositionLon"":121.481338500977}},{""StopUID"":""TPE15337"",""StopID"":""15337"",""StopName"":{""Zh_tw"":""員山"",""En"":""Yuanshan""},""StopBoarding"":0,""StopSequence"":42,""StopPosition"":{""PositionLat"":25.0034675598145,""PositionLon"":121.481048583984}},{""StopUID"":""TPE15339"",""StopID"":""15339"",""StopName"":{""Zh_tw"":""板橋監理站"",""En"":""Banqiao Motor Vehicle Supervision Sta.""},""StopBoarding"":0,""StopSequence"":44,""StopPosition"":{""PositionLat"":25.0060024261475,""PositionLon"":121.475952148438}},{""StopUID"":""TPE15340"",""StopID"":""15340"",""StopName"":{""Zh_tw"":""環球購物中心"",""En"":""Globall Mall""},""StopBoarding"":0,""StopSequence"":45,""StopPosition"":{""PositionLat"":25.0063800811768,""PositionLon"":121.473487854004}},{""StopUID"":""TPE15382"",""StopID"":""15382"",""StopName"":{""Zh_tw"":""國泰街口"",""En"":""Guotai St. Entrance""},""StopBoarding"":0,""StopSequence"":46,""StopPosition"":{""PositionLat"":25.0068264007568,""PositionLon"":121.470764160156}},{""StopUID"":""TPE15383"",""StopID"":""15383"",""StopName"":{""Zh_tw"":""電信訓練所"",""En"":""Telecommunications Training Center""},""StopBoarding"":0,""StopSequence"":47,""StopPosition"":{""PositionLat"":25.0079650878906,""PositionLon"":121.467613220215}},{""StopUID"":""TPE15384"",""StopID"":""15384"",""StopName"":{""Zh_tw"":""民族區運路口"",""En"":""Minzu   Quyun  Intersection""},""StopBoarding"":0,""StopSequence"":48,""StopPosition"":{""PositionLat"":25.0086421966553,""PositionLon"":121.465667724609}},{""StopUID"":""TPE153797"",""StopID"":""153797"",""StopName"":{""Zh_tw"":""深丘里"",""En"":""Shenqiu Li""},""StopBoarding"":0,""StopSequence"":49,""StopPosition"":{""PositionLat"":25.0094738006592,""PositionLon"":121.465240478516}},{""StopUID"":""TPE153798"",""StopID"":""153798"",""StopName"":{""Zh_tw"":""新北市政府(新府路)"",""En"":""Taipei County Hall""},""StopBoarding"":0,""StopSequence"":50,""StopPosition"":{""PositionLat"":25.0119476318359,""PositionLon"":121.464515686035}},{""StopUID"":""TPE15385"",""StopID"":""15385"",""StopName"":{""Zh_tw"":""板橋公車站"",""En"":""Banqiao Gong Station""},""StopBoarding"":0,""StopSequence"":51,""StopPosition"":{""PositionLat"":25.0129299163818,""PositionLon"":121.462341308594}},{""StopUID"":""TPE59444"",""StopID"":""59444"",""StopName"":{""Zh_tw"":""萬坪公園"",""En"":""Wanping Park""},""StopBoarding"":0,""StopSequence"":52,""StopPosition"":{""PositionLat"":25.0134696960449,""PositionLon"":121.460578918457}},{""StopUID"":""TPE15386"",""StopID"":""15386"",""StopName"":{""Zh_tw"":""北門街"",""En"":""Beimen St.""},""StopBoarding"":0,""StopSequence"":53,""StopPosition"":{""PositionLat"":25.01123046875,""PositionLon"":121.456787109375}},{""StopUID"":""TPE15387"",""StopID"":""15387"",""StopName"":{""Zh_tw"":""板橋區戶政事務所"",""En"":""Banciao Household Registry""},""StopBoarding"":0,""StopSequence"":54,""StopPosition"":{""PositionLat"":25.0128936767578,""PositionLon"":121.456321716309}},{""StopUID"":""TPE15388"",""StopID"":""15388"",""StopName"":{""Zh_tw"":""育樂中心"",""En"":""Receration Center""},""StopBoarding"":0,""StopSequence"":55,""StopPosition"":{""PositionLat"":25.0152111053467,""PositionLon"":121.456649780273}},{""StopUID"":""TPE15389"",""StopID"":""15389"",""StopName"":{""Zh_tw"":""大庭新村"",""En"":""Dating New Village""},""StopBoarding"":0,""StopSequence"":56,""StopPosition"":{""PositionLat"":25.0173778533936,""PositionLon"":121.456420898438}},{""StopUID"":""TPE15390"",""StopID"":""15390"",""StopName"":{""Zh_tw"":""和平一村"",""En"":""Heping Village 1""},""StopBoarding"":0,""StopSequence"":57,""StopPosition"":{""PositionLat"":25.0190048217773,""PositionLon"":121.455657958984}},{""StopUID"":""TPE15391"",""StopID"":""15391"",""StopName"":{""Zh_tw"":""社后"",""En"":""Shehou""},""StopBoarding"":0,""StopSequence"":58,""StopPosition"":{""PositionLat"":25.0207233428955,""PositionLon"":121.454933166504}},{""StopUID"":""TPE15392"",""StopID"":""15392"",""StopName"":{""Zh_tw"":""板橋國中(435藝文特區)"",""En"":""Banqiao Jr. High School (435 Art Center)""},""StopBoarding"":0,""StopSequence"":59,""StopPosition"":{""PositionLat"":25.0225009918213,""PositionLon"":121.454376220703}},{""StopUID"":""TPE15394"",""StopID"":""15394"",""StopName"":{""Zh_tw"":""名來新城"",""En"":""Minglai New Village""},""StopBoarding"":0,""StopSequence"":60,""StopPosition"":{""PositionLat"":25.0261306762695,""PositionLon"":121.454521179199}}],""UpdateDate"":""2017-04-19"",""UpdateTime"":""2017-04-19T01:09:11+08:00""}]");

            //設定CallAPI回傳結果
            Sut.CallAPIResult = sb.ToString();

            var expected = "307";
            //act
            var actual = Sut.Get(City, RouteName);

            //assert
            Assert.AreEqual(actual.Name, expected);
        }
    }
}