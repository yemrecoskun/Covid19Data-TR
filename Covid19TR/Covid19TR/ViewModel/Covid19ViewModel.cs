using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Covid19TR
{
    public class Covid19ViewModel
    {
        public List<Covid19> Covid19Data { get; set; }
        public Covid19 CovidDay { get; set; }
        public Covid19 CovidTotal { get; set; }
        public string CovidDayinfected { get; set; }
        public string CovidDaytested { get; set; }
        public string CovidDayrecovered { get; set; }
        public string CovidDaydeceased { get; set; }
        public string CovidTotalinfected { get; set; }
        public string CovidTotalActiveinfected { get; set; }
        public string CovidTotaltested { get; set; }
        public string CovidTotalrecovered { get; set; }
        public string CovidTotaldeceased { get; set; }
        public string now { get; set; }
        public Covid19ViewModel()
        {
            //DependencyService.Get<>;
            WebClient c = new WebClient();
            string url = c.DownloadString("https://api.apify.com/v2/datasets/LYeOfHQwsv7FsfdGV/items?format=json&clean=1");
            JArray urldizi = JArray.Parse(url);
            Covid19Data = new List<Covid19>();
            CovidDay = new Covid19();
            Covid19 data1 = JsonConvert.DeserializeObject<Covid19>(urldizi[3].ToString());
            char[] DayChar = data1.lastUpdatedAtApify.ToCharArray();
            data1.lastUpdatedAtApify = (new string(DayChar, 0, 10));
            Covid19Data.Add(data1);
            for (int i = 4; i < urldizi.Count(); i++)
            {
                Covid19 data = JsonConvert.DeserializeObject<Covid19>(urldizi[i].ToString());
                DayChar = data.lastUpdatedAtApify.ToCharArray();
                data.lastUpdatedAtApify = (new string(DayChar, 0, 10));
                CovidTotal = data;
                if (data.lastUpdatedAtApify.ToString() != Covid19Data[Covid19Data.Count() - 1].lastUpdatedAtApify.ToString())
                {
                    Covid19Data.Add(data);
                }
            }
            char[] Char = CovidTotal.lastUpdatedAtApify.ToCharArray();
            now = (new string(Char, 0, 10));
            CovidDayinfected = (Convert.ToInt32(CovidTotal.infected) - Convert.ToInt32(Covid19Data[Covid19Data.Count() - 2].infected)).ToString();
            CovidDaytested = (Convert.ToInt32(CovidTotal.tested) - Convert.ToInt32(Covid19Data[Covid19Data.Count() - 2].tested)).ToString();
            CovidDayrecovered = (Convert.ToInt32(CovidTotal.recovered) - Convert.ToInt32(Covid19Data[Covid19Data.Count() - 2].recovered)).ToString();
            CovidDaydeceased = (Convert.ToInt32(CovidTotal.deceased) - Convert.ToInt32(Covid19Data[Covid19Data.Count() - 2].deceased)).ToString();
            CovidTotalinfected = CovidTotal.infected;
            CovidTotalActiveinfected = (Convert.ToInt32(CovidTotal.infected) - Convert.ToInt32(CovidTotal.deceased) - Convert.ToInt32(CovidTotal.recovered)).ToString();
            CovidTotaldeceased = CovidTotal.deceased;
            CovidTotalrecovered = CovidTotal.recovered;
            CovidTotaltested = CovidTotal.tested;
        }
        public Covid19ViewModel(string DayData)
        {
            WebClient c = new WebClient();
            string url = c.DownloadString("https://api.apify.com/v2/datasets/LYeOfHQwsv7FsfdGV/items?format=json&clean=1");
            JArray urldizi = JArray.Parse(url);
            CovidDay = new Covid19();
            List<Covid19> CovidList = new List<Covid19>();
            Covid19 data1 = JsonConvert.DeserializeObject<Covid19>(urldizi[0].ToString());
            char[] DayChar = data1.lastUpdatedAtApify.ToCharArray();
            data1.lastUpdatedAtApify = (new string(DayChar, 0, 10));
            CovidList.Add(data1);
            for (int i = 1; i < urldizi.Count(); i++)
            {
                Covid19 data = JsonConvert.DeserializeObject<Covid19>(urldizi[i].ToString());
                DayChar = data.lastUpdatedAtApify.ToCharArray();
                data.lastUpdatedAtApify = (new string(DayChar, 0, 10));
                CovidTotal = data;
                if (data.lastUpdatedAtApify.ToString() != CovidList[CovidList.Count() - 1].lastUpdatedAtApify.ToString())
                {
                    CovidList.Add(data);
                }
            }
            for (int i = 0; i < CovidList.Count(); i++)
            {
                if (DayData == CovidList[i].lastUpdatedAtApify)
                {
                    CovidDay.tested = (Convert.ToInt32(CovidList[i].tested) - Convert.ToInt32(CovidList[i-1].tested)).ToString();
                    CovidDay.infected = (Convert.ToInt32(CovidList[i].infected) - Convert.ToInt32(CovidList[i - 1].infected)).ToString();
                    CovidDay.deceased = (Convert.ToInt32(CovidList[i].deceased) - Convert.ToInt32(CovidList[i - 1].deceased)).ToString();
                    CovidDay.recovered = (Convert.ToInt32(CovidList[i].recovered) - Convert.ToInt32(CovidList[i - 1].recovered)).ToString();
                    break;
                }
            }

        }
    }
}
