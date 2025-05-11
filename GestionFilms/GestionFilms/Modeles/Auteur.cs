using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFilms.Modeles
{
    public class Auteur:Personne
    {
        private Distribution? _distribution;
        /// <summary>
        /// Constructeur par défaut de l'auteur
        /// </summary>
        public Auteur()
        {

        }

        /// <summary>
        /// Constructeur avec un nom et un prénom
        /// </summary>
        /// <param name="pNom"></param>
        /// <param name="pPrenom"></param>
        public Auteur(string pNom, string pPrenom):base(pNom, pPrenom)
        {

        }

        public Distribution? Distribution
        {
            get { return _distribution; }
            set { _distribution = value; }

        }
    }
}
