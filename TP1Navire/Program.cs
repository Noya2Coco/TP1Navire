using System;

namespace TP1Navire
{
    class Program
    {
        static void Main(string[] args)
        {
            TesterInstanciations();

            Console.ReadKey();
        }

        public static void TesterInstanciations()
        {
            // déclaration de l'object unNvaire de la classe Navire
            Navire unNavire;
            // Instantiation
            unNavire = new Navire("IM09427639", "Copper Spirit", "Hydrocarbures", 156827);
            Affiche(unNavire);
            // Déclaration et instantiation d'un autre objet de la classe Navire
            Navire unAutreNavire = new Navire("IMO09839272", "MSC Isabella", "Porte-conteneurs", 197500);
            Affiche(unAutreNavire);
            // Nouvelle déclaration de l'autre navire
            unAutreNavire = new Navire("IMO08715871", "MSC Pilar");
            Affiche(unAutreNavire);
        }

        public static void Affiche(Navire navire)
        {
            Console.WriteLine("\n Identification :   {0} \n " +
                                 "Nom :              {1} \n " +
                                 "Type de frêt :     {2} \n " +
                                 "Quantité de frêt : {3} \n " +
                                 "_____________________________", navire.Imo, navire.Nom, navire.LibelleFret, navire.QteFretMaxi.ToString());
        }

        public static vois
    }
}
