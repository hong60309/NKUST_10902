using ConsoleApp.Services;
using Newtonsoft.Json.Linq;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //   var xmlService1 = new ImportXmlService();
            //
            // var datas = xmlService1.LoadFormFile(Utils.FilePath.GetFullPath("北捷站點.xml"));


            // Console.WriteLine(string.Format("分析完成，共有{0}筆資料", datas.Count));
            // datas.ForEach(x =>
            //  {
            //     Console.WriteLine(string.Format("編號 :{0} 名稱:{1}({2}) 描述:{3}", x.StationID, x.StationName?.Zh_tw, x.ExitName.Zh_tw, x.LocationDescription));
            // });


            // var jsonService = new ImportJsonService();


            //var jsonDatas = jsonService.LoadFormFile(Utils.FilePath.GetFullPath("高雄活動.txt"));

            //  Console.WriteLine(string.Format("分析完成，共有{0}筆資料", jsonDatas.Count));
            //  jsonDatas.ForEach(x =>
            //  {
            //     Console.WriteLine(string.Format("編號 :{0} 名稱:{1} 地點:{2}", x.PrgId,x.PrgName, x.OrgName));
            // });


            var jsonService = new ImportJsonService();


            ImportJsonService jsonService1 = jsonService;
            var jsonDatas = jsonService1.LoadFormFile(Utils.FilePath.GetFullPath("台南國中男女生人數.txt"));

            Console.WriteLine(string.Format("分析完成，共有{0}筆資料", jsonDatas.Count));
            jsonDatas.ForEach(x =>
            {
                Console.WriteLine(string.Format("學校 :{0} 性別:{1} 人數:{2}", x.School, x.Sex, x.Num));
            });
            Console.ReadKey();
        }
    }
}
