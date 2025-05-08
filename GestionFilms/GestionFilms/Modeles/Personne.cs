using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFilms.Modeles
{
    public class Personne
    {
        private int _id;
        private string? _nom;
        private string? _prenom;
        
        private string? _telephone;

        /// <summary>
        /// Contructeur par defaut
        /// </summary>
        public Personne()
        {

        }


        /// <summary>
        /// Constructeur recevant nom et prenom de la personne
        /// </summary>
        /// <param name="pNom"></param>
        /// <param name="pPrenom"></param>
        public Personne(string pNom, string pPrenom)
        {
            this._nom = pNom;
            this._prenom = pPrenom;
        }



        public int Id { get { return _id; } set { _id = value; } }
        public string Nom 
        { 
            get 
            { 
                if (_nom == null)
                    _nom = string.Empty;
                return _nom; 
            } 
            set 
            { 
                _nom = value; 
            } 
        }

        public string Prenom 
        { 
            get
            { 
                if (_prenom == null)    
                    _prenom = string.Empty;
               
              return _prenom; 
            } 
            set 
            { _prenom = value; 
            } 
        }

        

        public string Telephone 
        { 
            get 
            {
                if (_telephone == null)
                    return "() --- ----";
                return _telephone; 
            } 
            set
            { 
                _telephone = value; 
            }
        }
    }
}
