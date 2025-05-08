
using GestionFilms.IServices;
using GestionFilms.Modeles;

namespace GestionFilms.Services
{
    public class PersonneService : IPersonnesService
    {
        private List<Personne> _personnes;

        public PersonneService()
        {
            _personnes = new List<Personne>();
        }
        public void AjouterPersonne(Personne personne)
        {
            throw new NotImplementedException();
        }

        public void ModifierPersonne(Personne personne)
        {
            throw new NotImplementedException();
        }

        public List<Personne> ObtenirListePersonnes()
        {
            return this._personnes;
        }

        public Personne ObtenirPersonne(int id)
        {
            if (id < 0)
                throw new ArgumentException("L'identifiant doit être un nombre positif.", nameof(id));

            var personne = _personnes.FirstOrDefault(p => p.Id == id);

            if(personne == null)
                throw new KeyNotFoundException($"Aucune personne trouvée avec l'ID {id}.");

            return personne;
        }

        public void SupprimerPersonne(Personne personne)
        {
            throw new NotImplementedException();
        }
    }
}
