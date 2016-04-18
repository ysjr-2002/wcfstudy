using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace ConsoleWebHttpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceReference1.CaseClient client = new ServiceReference1.CaseClient();
            //client.AddCase();
            //Console.WriteLine("call over");
            //var sw = Stopwatch.StartNew();
            //var buffer = client.GetBuffer();
            //sw.Stop();
            //Console.WriteLine("buffer length:" + buffer.Length + " " + sw.ElapsedMilliseconds);
            //Console.WriteLine(client.State);
            //Console.Read();
            //WebClient web = new WebClient();
            //web.BaseAddress =

            var url = "http://localhost:8899/testservice/Sub?x=1&y=1";
            var web = WebRequest.Create(url);
            var response = (HttpWebResponse)web.GetResponse();
            var stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            var txt = reader.ReadToEnd();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(txt);
            var val = doc.FirstChild.InnerText;
        }
    }
}
