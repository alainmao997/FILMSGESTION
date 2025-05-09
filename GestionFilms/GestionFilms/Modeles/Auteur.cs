using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFilms.Modeles
{
    public class Auteur:Personne
    {
        /// <summary>
        /// Constructeur par défaut de l'auteur
        /// </summary>
        public Auteur()
        {

        }

        public Auteur(string pNom, string pPrenom):base(pNom, pPrenom)
        {

        }
    }
}
