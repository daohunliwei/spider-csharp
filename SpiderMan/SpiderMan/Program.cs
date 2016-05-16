using SpiderManCommon;
using System;
using System.IO;
namespace SpiderMan
{
    class Program
    {
        static void Main(string[] args)
        {
            string html=SpiderManCommon.Spider.GetWeb("http://www.baidu.com");
            Console.WriteLine(html);
            Console.ReadLine();
        }
    }
}
