namespace GestionFilms
{
    public partial class frmDebut : Form
    {
        public frmDebut()
        {
            InitializeComponent();
        }

        private void btnValiderDebut_Click(object sender, EventArgs e)
        {
            if (rbnAbonne.Checked)
            {
                frmConnexion formulaireConnexion = new frmConnexion();
                this.Hide();
                formulaireConnexion.Show();


            }

            else if (rbnPasAbonne.Checked)
                MessageBox.Show("Formulaire d'abonnement");
            else
                MessageBox.Show("Ëtes vous client ou pas ? Faites votre choix");
        }
    }
}