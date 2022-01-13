
namespace eBiblioteka.WinUI
{
    partial class frmClanUnos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.potvrdaUnosaButton = new System.Windows.Forms.Button();
            this.JMBGTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.DatumRodjenjaDtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.gradCombo = new System.Windows.Forms.ComboBox();
            this.bibliotekaCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rođenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(91, 93);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(218, 20);
            this.imeTextBox.TabIndex = 6;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(91, 154);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(218, 20);
            this.prezimeTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(449, 154);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(218, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // potvrdaUnosaButton
            // 
            this.potvrdaUnosaButton.Location = new System.Drawing.Point(541, 365);
            this.potvrdaUnosaButton.Name = "potvrdaUnosaButton";
            this.potvrdaUnosaButton.Size = new System.Drawing.Size(126, 23);
            this.potvrdaUnosaButton.TabIndex = 12;
            this.potvrdaUnosaButton.Text = "Potvrda unosa";
            this.potvrdaUnosaButton.UseVisualStyleBackColor = true;
            this.potvrdaUnosaButton.Click += new System.EventHandler(this.potvrdaUnosaButton_Click);
            // 
            // JMBGTextBox
            // 
            this.JMBGTextBox.Location = new System.Drawing.Point(91, 217);
            this.JMBGTextBox.Name = "JMBGTextBox";
            this.JMBGTextBox.Size = new System.Drawing.Size(218, 20);
            this.JMBGTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adresa:";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Location = new System.Drawing.Point(449, 217);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(218, 20);
            this.adresaTextBox.TabIndex = 15;
            // 
            // DatumRodjenjaDtp
            // 
            this.DatumRodjenjaDtp.Location = new System.Drawing.Point(449, 93);
            this.DatumRodjenjaDtp.Name = "DatumRodjenjaDtp";
            this.DatumRodjenjaDtp.Size = new System.Drawing.Size(200, 20);
            this.DatumRodjenjaDtp.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Grad:";
            // 
            // gradCombo
            // 
            this.gradCombo.FormattingEnabled = true;
            this.gradCombo.Location = new System.Drawing.Point(91, 266);
            this.gradCombo.Name = "gradCombo";
            this.gradCombo.Size = new System.Drawing.Size(218, 21);
            this.gradCombo.TabIndex = 18;
            // 
            // bibliotekaCombo
            // 
            this.bibliotekaCombo.FormattingEnabled = true;
            this.bibliotekaCombo.Location = new System.Drawing.Point(449, 266);
            this.bibliotekaCombo.Name = "bibliotekaCombo";
            this.bibliotekaCombo.Size = new System.Drawing.Size(218, 21);
            this.bibliotekaCombo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Biblioteka:";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(449, 320);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(218, 20);
            this.lozinkaTextBox.TabIndex = 25;
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(91, 320);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(218, 20);
            this.korisnickoImeTextBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Lozinka:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(88, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Korisničko ime:";
            // 
            // frmClanUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 460);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bibliotekaCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gradCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DatumRodjenjaDtp);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.JMBGTextBox);
            this.Controls.Add(this.potvrdaUnosaButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClanUnos";
            this.Text = "frmBiblioteka";
            this.Load += new System.EventHandler(this.frmClanUnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button potvrdaUnosaButton;
        private System.Windows.Forms.TextBox JMBGTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.DateTimePicker DatumRodjenjaDtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox gradCombo;
        private System.Windows.Forms.ComboBox bibliotekaCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}