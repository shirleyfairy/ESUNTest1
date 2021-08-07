using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESUNTest1.Models
{
    public class ESUNTestDB
    {
        ESUNTestEntities db = new ESUNTestEntities();

        public void Create(string statisticYear, string according, string siteId, string marriageTp, 
            string femaleAge, string maleAge, string marryPair)
        {
            //新增一筆Content資料物件
            MarriageInfo infodata = new MarriageInfo();
            //設定新增的值
            infodata.statistic_yyy = statisticYear;
            infodata.according = according;
            infodata.site_id = siteId;
            infodata.marriage_type = marriageTp;
            infodata.female_age = femaleAge;
            infodata.male_age = maleAge;
            infodata.marry_pair = marryPair;

            //將資料加入Content資料表中
            //db.Contents.Add(NewData);
            Create(infodata);
            //儲存資料度變更
            db.SaveChanges();
        }

        //新增資料
        public void Create(MarriageInfo infodata)
        {
            //將資料加入Contnet資料表中
            db.MarriageInfo.Add(infodata);
            //儲存資料庫變更
            db.SaveChanges();
        }

        //刪除資料
        public bool Delete(string statisticYear, string according, string siteId, string marriageTp,
            string femaleAge, string maleAge)
        {
            //取得編號的資料
            MarriageInfo DeleteData = db.MarriageInfo.Find(statisticYear,
                                                           according,
                                                           siteId,
                                                           marriageTp,
                                                           femaleAge,
                                                           maleAge);
            //判斷是否有資料
            if (DeleteData != null)
            {
                //將資料從Content資料表中移除
                db.MarriageInfo.Remove(DeleteData);
                //儲存資料並變更
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;//回傳失敗
            }
        }

    }
}