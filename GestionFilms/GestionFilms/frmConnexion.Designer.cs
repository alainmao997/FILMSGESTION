namespace GestionFilms
{
    partial class frmConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblMotPasse = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblTitreConnexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNom.ForeColor = System.Drawing.Color.Black;
            this.lblNom.Location = new System.Drawing.Point(65, 161);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(186, 26);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom utilisateur :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(287, 156);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(269, 31);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(287, 225);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(269, 31);
            this.txtPrenom.TabIndex = 2;
            // 
            // lblMotPasse
            // 
            this.lblMotPasse.AutoSize = true;
            this.lblMotPasse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMotPasse.Location = new System.Drawing.Point(65, 227);
            this.lblMotPasse.Name = "lblMotPasse";
            this.lblMotPasse.Size = new System.Drawing.Size(153, 26);
            this.lblMotPasse.TabIndex = 3;
            this.lblMotPasse.Text = "Mot de passe:";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValider.Location = new System.Drawing.Point(287, 301);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(269, 79);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // lblTitreConnexion
            // 
            this.lblTitreConnexion.AutoSize = true;
            this.lblTitreConnexion.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitreConnexion.Location = new System.Drawing.Point(263, 56);
            this.lblTitreConnexion.Name = "lblTitreConnexion";
            this.lblTitreConnexion.Size = new System.Drawing.Size(293, 38);
            this.lblTitreConnexion.TabIndex = 5;
            this.lblTitreConnexion.Text = "CONNECTEZ-VOUS !";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitreConnexion);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblMotPasse);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "frmConnexion";
            this.Text = "FORMULAIRE DE CONNEXION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNom;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private Label lblMotPasse;
        private Button btnValider;
        private Label lblTitreConnexion;
    }
}