using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;

namespace Calculateur_Loterie
{
    class Program
    {
        static void Main(string[] args)
        {
            Step1(); // Récupération des ariches 2004 - 2017 (stockage fichiers .txt) --> Si les fichiers existe déjà, passer cette étape
            Step2(); // Analyse des chiffres les plus utilisés --> Si les calculs ont déjà été réalisés et stockés, passer cette étape
            Step3(); // Filtrer les combinaisons impossibles
            Step4(); // Affichage des données (combinaisons)

            Step5(); // Optionnel : Affichage et sauvegarge des derniers tirages pour les prendre en compte --> Dans les fichier txt


            Console.WriteLine("\r\nTerminé");
            Console.Read();
        }

        public static void Step1()
        {
            Calculateur_Loterie.Historique2004 H2004 = new Calculateur_Loterie.Historique2004();
            Calculateur_Loterie.Historique2005 H2005 = new Calculateur_Loterie.Historique2005();
            Calculateur_Loterie.Historique2006 H2006 = new Calculateur_Loterie.Historique2006();
            Calculateur_Loterie.Historique2007 H2007 = new Calculateur_Loterie.Historique2007();
            Calculateur_Loterie.Historique2008 H2008 = new Calculateur_Loterie.Historique2008();
            Calculateur_Loterie.Historique2009 H2009 = new Calculateur_Loterie.Historique2009();
            Calculateur_Loterie.Historique2010 H2010 = new Calculateur_Loterie.Historique2010();
            Calculateur_Loterie.Historique2011 H2011 = new Calculateur_Loterie.Historique2011();
            Calculateur_Loterie.Historique2012 H2012 = new Calculateur_Loterie.Historique2012();
            Calculateur_Loterie.Historique2013 H2013 = new Calculateur_Loterie.Historique2013();
            Calculateur_Loterie.Historique2014 H2014 = new Calculateur_Loterie.Historique2014();
            Calculateur_Loterie.Historique2015 H2015 = new Calculateur_Loterie.Historique2015();
            Calculateur_Loterie.Historique2016 H2016 = new Calculateur_Loterie.Historique2016();
            Calculateur_Loterie.Historique2017 H2017 = new Calculateur_Loterie.Historique2017();

            H2004.RecuperationHistorique();
            H2005.RecuperationHistorique();
            H2006.RecuperationHistorique();
            H2007.RecuperationHistorique();
            H2008.RecuperationHistorique();
            H2009.RecuperationHistorique();
            H2010.RecuperationHistorique();
            H2011.RecuperationHistorique();
            H2012.RecuperationHistorique();
            H2013.RecuperationHistorique();
            H2014.RecuperationHistorique();
            H2015.RecuperationHistorique();
            H2016.RecuperationHistorique();
            H2017.RecuperationHistorique();
        }

        public static void Step2()
        {

        }

        public static void Step3()
        {

        }

        public static void Step4()
        {

        }

        public static void Step5()
        {

        }
    }
}
