using ESUNTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESUNTest1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ESUNTest()
        {
            APIUtil api = new APIUtil();
            String apiStr = api.GetGEsunStrData();
            JsonData apiModel = api.GetEsunModel();
            RecordsData[] recDatas = apiModel.Result.Records;
            ESUNTestDB esunDB = new ESUNTestDB();
            int recordCnt = recDatas.Count();
            Console.WriteLine(recordCnt);
            ViewBag.Message += "<tr><th>" + recDatas[0].Year + "</th>"
                            + "<th>" + recDatas[0].According + "</th>"
                            + "<th>" + recDatas[0].Site + "</th>"
                            + "<th>" + recDatas[0].MarriageTp + "</th>"
                            + "<th>" + recDatas[0].Female + "</th>"
                            + "<th>" + recDatas[0].Male + "</th>"
                            + "<th>" + recDatas[0].MarryPair + "</th></tr>";
            for (int i=1;i< recDatas.Count(); i++)
            {
                ViewBag.Message += "<tr><td>" + recDatas[i].Year + "</td>"
                            + "<td>" + recDatas[i].According + "</td>"
                            + "<td>" + recDatas[i].Site + "</td>"
                            + "<td>" + recDatas[i].MarriageTp + "</td>"
                            + "<td>" + recDatas[i].Female + "</td>"
                            + "<td>" + recDatas[i].Male + "</td>"
                            + "<td>" + recDatas[i].MarryPair + "</td></tr>";
            }
            
            return View();
        }

        private MarriageInfo transferModel(RecordsData record)
        {
            MarriageInfo info = new MarriageInfo();
            info.statistic_yyy = record.Year;
            info.according = record.According;
            info.site_id = record.Site;
            info.marriage_type = record.MarriageTp;
            info.female_age = record.Female;
            info.male_age = record.Male;
            info.marry_pair = record.MarryPair;

            return info;
        }
    }
}