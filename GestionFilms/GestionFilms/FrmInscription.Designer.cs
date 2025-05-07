namespace GestionFilms
{
    partial class FrmInscription
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnFeminin = new System.Windows.Forms.RadioButton();
            this.rbtnMasculin = new System.Windows.Forms.RadioButton();
            this.lblSexe = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnValiderInscription = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSCRIVEZ-VOUS !";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(33, 71);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(74, 26);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(33, 123);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(107, 26);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prenom :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Controls.Add(this.lblPrenom);
            this.panel1.Location = new System.Drawing.Point(113, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 233);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "IDENTITE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 35);
            this.textBox1.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(154, 75);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(244, 35);
            this.txtNom.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnFeminin);
            this.panel2.Controls.Add(this.rbtnMasculin);
            this.panel2.Controls.Add(this.lblSexe);
            this.panel2.Location = new System.Drawing.Point(541, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 233);
            this.panel2.TabIndex = 4;
            // 
            // rbtnFeminin
            // 
            this.rbtnFeminin.AutoSize = true;
            this.rbtnFeminin.Location = new System.Drawing.Point(32, 119);
            this.rbtnFeminin.Name = "rbtnFeminin";
            this.rbtnFeminin.Size = new System.Drawing.Size(52, 30);
            this.rbtnFeminin.TabIndex = 2;
            this.rbtnFeminin.TabStop = true;
            this.rbtnFeminin.Text = "F";
            this.rbtnFeminin.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculin
            // 
            this.rbtnMasculin.AutoSize = true;
            this.rbtnMasculin.Location = new System.Drawing.Point(31, 74);
            this.rbtnMasculin.Name = "rbtnMasculin";
            this.rbtnMasculin.Size = new System.Drawing.Size(60, 30);
            this.rbtnMasculin.TabIndex = 1;
            this.rbtnMasculin.TabStop = true;
            this.rbtnMasculin.Text = "M";
            this.rbtnMasculin.UseVisualStyleBackColor = true;
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(71, 18);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(73, 26);
            this.lblSexe.TabIndex = 0;
            this.lblSexe.Text = "SEXE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbStatus);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Location = new System.Drawing.Point(724, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 233);
            this.panel3.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Employé",
            "Client"});
            this.cmbStatus.Location = new System.Drawing.Point(31, 76);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(182, 34);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(80, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 26);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "STATUS";
            // 
            // btnValiderInscription
            // 
            this.btnValiderInscription.Location = new System.Drawing.Point(369, 439);
            this.btnValiderInscription.Name = "btnValiderInscription";
            this.btnValiderInscription.Size = new System.Drawing.Size(298, 77);
            this.btnValiderInscription.TabIndex = 6;
            this.btnValiderInscription.Text = "VALIDER";
            this.btnValiderInscription.UseVisualStyleBackColor = true;
            // 
            // FrmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 582);
            this.Controls.Add(this.btnValiderInscription);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmInscription";
            this.Text = "FORMULAIRE D\'INSCRPTION";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblNom;
        private Label lblPrenom;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private TextBox txtNom;
        private Panel panel2;
        private RadioButton rbtnFeminin;
        private RadioButton rbtnMasculin;
        private Label lblSexe;
        private Panel panel3;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private Button btnValiderInscription;
    }
}