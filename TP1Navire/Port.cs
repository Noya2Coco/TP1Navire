using System;
using System.Collections.Generic;
using System.Text;

namespace TP1Navire
{
    class Port<T>
    {
        private string nom;
        private int nbNaviresMax;
        private List<T> navires = new List<T>();

        public Port (string nom)
        {
            this.nom = nom;
            this.nbNaviresMax = 5;
        }

        public int NbNaviresMax { get => nbNaviresMax; set => nbNaviresMax = value; }


        private bool portPlein(Port port)
        {
            return !(port.nbNaviresMax == port.Count);
        }

        private bool portVide(Port port)
        {
            return (port.Count == 0);
        }

        public void EnregistrerArrivee(Navire navire)
        {
            if (!portPlein(this))
            {
                this.navires.Add(navire);
            }
            else
            {
                Console.WriteLine("Ajout impossible, le port est complet.");
            }
        }

        public void EnregistrerDepart(string imo)
        {
            if 
        }

        public bool EstPresent(string imo)
        {
            return this.navires.Contains(imo);
        }

        
    }
}
