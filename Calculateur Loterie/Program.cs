using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;
using System.Xml;

namespace Calculateur_Loterie
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Euromillion */

            Step1(); // Récupération des ariches 2004 - 2017 (stockage fichiers txt)
            Step2(); // Analyse des chiffres les plus utilisés


            Console.WriteLine("\r\nTerminé");
            Console.Read();
        }

        public static void Step1()
        {
            var html = @"https://www.euro-millions.com/fr/archive-resultats-2016";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
            Console.WriteLine("Balise : " + node.Name + "\n" + node.OuterHtml);

            var node2 = htmlDoc.DocumentNode.SelectSingleNode("//body");
            Console.WriteLine("Balise : " + node2.Name + "\n" + node2.OuterHtml);
        }
        public static void Step2()
        {

        }
    }
}
