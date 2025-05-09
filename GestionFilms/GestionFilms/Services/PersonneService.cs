
using GestionFilms.IServices;
using GestionFilms.Modeles;

namespace GestionFilms.Services
{
    public class PersonneService : IPersonnesService
    {
        private List<Personne> _personnes;

        /// <summary>
        /// Constructeur du service qui initialise la liste ou est rsauvegardé la personne
        /// </summary>
        public PersonneService()
        {
            _personnes = new List<Personne>();
        }

        /// <summary>
        /// Inscrire une personne
        /// </summary>
        /// <param name="personne"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AjouterPersonne(Personne personne)
        {
            
              if (personne == null)
              {
                throw new ArgumentNullException(nameof(personne), "Une perssonne ne doit pas être null");
              }
              _personnes.Add(personne);
           
        }


        /// <summary>
        /// Modifie les informations d'une personne
        /// </summary>
        /// <param name="personne"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void ModifierPersonne(Personne personne)
        {
            if(personne == null)
            {
                throw new ArgumentNullException(nameof(personne), "La presonne ne peut pas être nulle");
            }
            var unePersonne = _personnes.FirstOrDefault(p=>p.Id == personne.Id);
            if (unePersonne == null)
            {
                throw new ArgumentNullException(nameof(unePersonne), "Cette personne n'esxiste pas");
            }

            unePersonne.Nom = personne.Nom;
            unePersonne.Prenom = personne.Prenom;
            unePersonne.Telephone = personne.Telephone;
           
        }

        /// <summary>
        /// Obtenir toutes les personnes incrites
        /// </summary>
        /// <returns></returns>
        public List<Personne> ObtenirListePersonnes()
        {
            return this._personnes;
        }

        /// <summary>
        /// Obtenir une personne à partir de son identifiant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="KeyNotFoundException"></exception>
        public Personne ObtenirPersonne(int id)
        {
            if (id < 0)
                throw new ArgumentException("L'identifiant doit être un nombre positif.", nameof(id));

            var personne = _personnes.FirstOrDefault(p => p.Id == id);

            if(personne == null)
                throw new KeyNotFoundException("Aucune personne trouvée avec l'ID {id}.");

            return personne;
        }

        /// <summary>
        /// Supprimer le compte d'une personne
        /// </summary>
        /// <param name="pId"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void SupprimerPersonne(int pId)
        {
            var unePersonne = _personnes.FirstOrDefault(p => p.Id == pId);
            if(unePersonne == null) 
            { 
                throw new ArgumentNullException(nameof(unePersonne), "Aucune personne trouvée");
            }

            _personnes.Remove(unePersonne);

        }
    }
}
