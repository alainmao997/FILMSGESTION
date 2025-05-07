using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFilms.Modeles
{
    public class Clients:Personnes
    {
        private DateTime _dateInscription;
        private string? _courriel;
        private string? _password;

        public DateTime DateInscription {  get { return _dateInscription; } set { _dateInscription = value; } }
        
        public string Courriel 
        {  get 
            { 
                if (_courriel == null)
                    return "defaut@gmail.com";
                return _courriel; 
            
            } 
            set 
            { 
                _courriel = value;
            }
        }
       
        public string  Password 
        { 
            get 
            { 
                if (_password == null)
                   return "mot de passe"; 
             return _password;
            
            } 
            set 
            { 
                _password = value; 
            } 
        }
    }
}
