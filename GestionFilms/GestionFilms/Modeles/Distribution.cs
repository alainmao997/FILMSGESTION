using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFilms.Modeles
{
    public class Distribution
    {
        private string? _nomPersonnage;
        private DateTime _debutEmploi;
        private DateTime _finEmploi;
        private float _cachet;


        public string NomPersonnage
        {
            get 
            {
                if (_nomPersonnage == null)
                     return "Donnez un nom au personnage"; 
                return _nomPersonnage;
            }
            set { _nomPersonnage = value; }
        }

        public DateTime DebutEmploi
        {
            get { return _debutEmploi; }
            set { _debutEmploi = value; }
        }

        public DateTime FinEmploi
        {
            get { return _finEmploi; }
            set { _finEmploi = value; }
        }

        public float Cachet
        {
            get { return _cachet; }
            set { _cachet = value; }
        }
    }
}
