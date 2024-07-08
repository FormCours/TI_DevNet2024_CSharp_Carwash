using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Carwash.Models
{
    public class Voiture
    {
        public string Marque { get; private init; }
        public string Modele { get; private init; }
        public string Couleur { get; private init; }
        public string Plaque { get; private init; }

        public Voiture(string marque, string modele, string couleur, string plaque)
        {
            Marque = marque;
            Modele = modele;
            Couleur = couleur;
            Plaque = plaque;
        }
    }
}
