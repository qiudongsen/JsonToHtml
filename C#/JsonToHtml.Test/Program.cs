using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JsonToHtml.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = null;
            using (StreamReader rs = new StreamReader("a.json"))
            {
                json = rs.ReadLine();
            }

            //string html = JsonToHtml.JsonHtml.GetHtml(json);

            JToken token = JObject.Parse(json).GetValue("cells");

            JArray arr = JArray.Parse(token.ToString());

            JToken fir = arr[0];

            JObject obj = JObject.Parse(fir.ToString());

            JArray carr = JArray.Parse(obj.GetValue("ncells").ToString());

            string html = JsonToHtml.JsonHtml.GetHtmlFromJsonArray(carr);

            Console.WriteLine(html);
            Console.ReadKey();
        }
    }
}
