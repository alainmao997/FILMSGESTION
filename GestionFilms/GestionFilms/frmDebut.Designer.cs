namespace GestionFilms
{
    partial class frmDebut
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnValiderDebut = new System.Windows.Forms.Button();
            this.rbnAbonne = new System.Windows.Forms.RadioButton();
            this.rbnPasAbonne = new System.Windows.Forms.RadioButton();
            this.lblTitreChoixStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValiderDebut
            // 
            this.btnValiderDebut.BackColor = System.Drawing.SystemColors.Control;
            this.btnValiderDebut.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValiderDebut.Location = new System.Drawing.Point(176, 266);
            this.btnValiderDebut.Name = "btnValiderDebut";
            this.btnValiderDebut.Size = new System.Drawing.Size(232, 85);
            this.btnValiderDebut.TabIndex = 0;
            this.btnValiderDebut.Text = "VALIDER";
            this.btnValiderDebut.UseVisualStyleBackColor = false;
            this.btnValiderDebut.Click += new System.EventHandler(this.btnValiderDebut_Click);
            // 
            // rbnAbonne
            // 
            this.rbnAbonne.AutoSize = true;
            this.rbnAbonne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbnAbonne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbnAbonne.Location = new System.Drawing.Point(233, 157);
            this.rbnAbonne.Name = "rbnAbonne";
            this.rbnAbonne.Size = new System.Drawing.Size(100, 30);
            this.rbnAbonne.TabIndex = 1;
            this.rbnAbonne.TabStop = true;
            this.rbnAbonne.Text = "Client";
            this.rbnAbonne.UseVisualStyleBackColor = true;
            // 
            // rbnPasAbonne
            // 
            this.rbnPasAbonne.AutoSize = true;
            this.rbnPasAbonne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbnPasAbonne.Location = new System.Drawing.Point(233, 199);
            this.rbnPasAbonne.Name = "rbnPasAbonne";
            this.rbnPasAbonne.Size = new System.Drawing.Size(106, 30);
            this.rbnPasAbonne.TabIndex = 2;
            this.rbnPasAbonne.TabStop = true;
            this.rbnPasAbonne.Text = "Autres";
            this.rbnPasAbonne.UseVisualStyleBackColor = true;
            // 
            // lblTitreChoixStatus
            // 
            this.lblTitreChoixStatus.AutoSize = true;
            this.lblTitreChoixStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitreChoixStatus.Location = new System.Drawing.Point(176, 78);
            this.lblTitreChoixStatus.Name = "lblTitreChoixStatus";
            this.lblTitreChoixStatus.Size = new System.Drawing.Size(337, 26);
            this.lblTitreChoixStatus.TabIndex = 3;
            this.lblTitreChoixStatus.Text = "CHOISISSEZ VOTRE STATUS";
            // 
            // frmDebut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.lblTitreChoixStatus);
            this.Controls.Add(this.rbnPasAbonne);
            this.Controls.Add(this.rbnAbonne);
            this.Controls.Add(this.btnValiderDebut);
            this.Name = "frmDebut";
            this.Text = "GESTION DES FILMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnValiderDebut;
        private RadioButton rbnAbonne;
        private RadioButton rbnPasAbonne;
        private Label lblTitreChoixStatus;
    }
}