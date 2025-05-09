using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFilms.Modeles
{
    public class CarteCredit
    {
        private int _id;
        private string? _numeroCarteCredit;


        public int Id { get { return _id; } set { _id = value; } }
        public string? NumeroCarteCredit { get { return _numeroCarteCredit; } set { _numeroCarteCredit = value; } }
    }
}
