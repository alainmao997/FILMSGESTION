
using GestionFilms.Modeles;


namespace GestionFilms.IServices
{
    internal interface IPersonnesService
    {
        List<Personne> ObtenirListePersonnes();
        Personne ObtenirPersonne(int pId);

        void AjouterPersonne(Personne pPersonne);
        void ModifierPersonne(Personne pPersonne);
        void SupprimerPersonne(int pId);
    }
}
