using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;

namespace Calculateur_Loterie
{
    class Historique2006
    {
        public void RecuperationHistorique()
        {
            Console.WriteLine("###### HISTORIQUE 2006 ######");

            var html = @"https://www.euro-millions.com/fr/archive-resultats-2006";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);

            var node1 = htmlDoc.DocumentNode.SelectNodes("//ul[@class='balls']");

            using (StreamWriter sw = new StreamWriter(@"C:\Historique\2006.txt", true))
            {
                if (node1 != null)
                {
                    foreach (var node2 in node1)
                    {
                        var node3 = htmlDoc.DocumentNode.SelectNodes("//li[@class='ball']");
                        if (node3 != null)
                        {
                            foreach (var node4 in node3)
                            {
                                Console.WriteLine(node4.InnerText);
                                sw.Write(node4.InnerText + "\r\n");
                            }
                        }
                    }
                }

                sw.Close();
            }
        }
    }
}
