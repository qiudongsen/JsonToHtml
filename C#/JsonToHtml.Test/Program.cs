using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

            string html = JsonToHtml.JsonHtml.GetHtml(json);

            Console.WriteLine(html);
            Console.ReadKey();
        }
    }
}
