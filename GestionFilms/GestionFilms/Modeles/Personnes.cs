using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFilms.Modeles
{
    public class Personnes
    {
        private int _id;
        private string _nom;
        private string _prenom;
        
        private string _telephone;


        public int Id { get { return _id; } set { _id = value; } }
        public string Nom { get { return _nom; } set { _nom = value; } }

        public string Prenom { get { return _prenom; } set { _prenom = value; } }

        

        public string Telephone { get { return _telephone; } set { _telephone = value; } }
    }
}
