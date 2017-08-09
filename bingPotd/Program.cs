using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml;

namespace bingPotd
{
    class Program
    {
        [DllImport("User32", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uiAction, int uiParam,
        string pvParam, uint fWinIni);

        static void Main(string[] args)
        {

            XmlDocument xml = new XmlDocument();
            xml.Load("https://www.bing.com/HPImageArchive.aspx?format=xml&idx=0&n=1&mkt=it-It"); //Load NOT LoadXml

            XmlNodeList xmlnode = xml.GetElementsByTagName("urlBase");
            string prova = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            WebClient w1 = new WebClient();
            w1.DownloadFile("https://www.bing.com/" + xmlnode[0].InnerText + "_1920x1080.jpg", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\potd.jpg");
            //if false file not found
            SystemParametersInfo(0x0014, 0, Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\potd.jpg", 0x0001);
        }
    }
}
