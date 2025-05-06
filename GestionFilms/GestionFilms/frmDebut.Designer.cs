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
            this.SuspendLayout();
            // 
            // btnValiderDebut
            // 
            this.btnValiderDebut.BackColor = System.Drawing.Color.LightGray;
            this.btnValiderDebut.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValiderDebut.Location = new System.Drawing.Point(273, 220);
            this.btnValiderDebut.Name = "btnValiderDebut";
            this.btnValiderDebut.Size = new System.Drawing.Size(163, 85);
            this.btnValiderDebut.TabIndex = 0;
            this.btnValiderDebut.Text = "VALIDER";
            this.btnValiderDebut.UseVisualStyleBackColor = false;
            this.btnValiderDebut.Click += new System.EventHandler(this.btnValiderDebut_Click);
            // 
            // rbnAbonne
            // 
            this.rbnAbonne.AutoSize = true;
            this.rbnAbonne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbnAbonne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbnAbonne.Location = new System.Drawing.Point(200, 121);
            this.rbnAbonne.Name = "rbnAbonne";
            this.rbnAbonne.Size = new System.Drawing.Size(116, 30);
            this.rbnAbonne.TabIndex = 1;
            this.rbnAbonne.TabStop = true;
            this.rbnAbonne.Text = "Abonné";
            this.rbnAbonne.UseVisualStyleBackColor = true;
            // 
            // rbnPasAbonne
            // 
            this.rbnPasAbonne.AutoSize = true;
            this.rbnPasAbonne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbnPasAbonne.Location = new System.Drawing.Point(385, 121);
            this.rbnPasAbonne.Name = "rbnPasAbonne";
            this.rbnPasAbonne.Size = new System.Drawing.Size(157, 30);
            this.rbnPasAbonne.TabIndex = 2;
            this.rbnPasAbonne.TabStop = true;
            this.rbnPasAbonne.Text = "Pas Abonné";
            this.rbnPasAbonne.UseVisualStyleBackColor = true;
            // 
            // frmDebut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}