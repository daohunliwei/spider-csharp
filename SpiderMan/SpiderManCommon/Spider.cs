using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace SpiderManCommon
{
    public class Spider
    {
        public static string GetWeb(string url)
        {
            try
            {
                HtmlWeb html = new HtmlWeb();
                HtmlDocument htmldoc = html.Load(url, "GET");
                return htmldoc.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
