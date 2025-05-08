
using GestionFilms.Modeles;


namespace GestionFilms.IServices
{
    internal interface IPersonnesService
    {
        List<Personne> ObtenirListePersonnes();
        Personne ObtenirPersonne(int id);

        void AjouterPersonne(Personne personne);
        void ModifierPersonne(Personne personne);
        void SupprimerPersonne(Personne personne);
    }
}
