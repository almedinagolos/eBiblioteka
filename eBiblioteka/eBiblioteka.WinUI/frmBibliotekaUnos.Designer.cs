
namespace eBiblioteka.WinUI
{
    partial class frmBibliotekaUnos
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
            this.label6 = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.brojTelTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.vrstaCombo = new System.Windows.Forms.ComboBox();
            this.potvrdaUnosaButton = new System.Windows.Forms.Button();
            this.gradCombo = new System.Windows.Forms.ComboBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime biblioteke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj telefona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vrsta biblioteke";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(101, 79);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(218, 20);
            this.nazivTextBox.TabIndex = 6;
            // 
            // brojTelTextBox
            // 
            this.brojTelTextBox.Location = new System.Drawing.Point(101, 168);
            this.brojTelTextBox.Name = "brojTelTextBox";
            this.brojTelTextBox.Size = new System.Drawing.Size(218, 20);
            this.brojTelTextBox.TabIndex = 7;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Location = new System.Drawing.Point(437, 79);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(218, 20);
            this.adresaTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(437, 168);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(218, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // vrstaCombo
            // 
            this.vrstaCombo.FormattingEnabled = true;
            this.vrstaCombo.Location = new System.Drawing.Point(437, 245);
            this.vrstaCombo.Name = "vrstaCombo";
            this.vrstaCombo.Size = new System.Drawing.Size(218, 21);
            this.vrstaCombo.TabIndex = 11;
            // 
            // potvrdaUnosaButton
            // 
            this.potvrdaUnosaButton.Location = new System.Drawing.Point(529, 310);
            this.potvrdaUnosaButton.Name = "potvrdaUnosaButton";
            this.potvrdaUnosaButton.Size = new System.Drawing.Size(126, 35);
            this.potvrdaUnosaButton.TabIndex = 12;
            this.potvrdaUnosaButton.Text = "Potvrda unosa";
            this.potvrdaUnosaButton.UseVisualStyleBackColor = true;
            this.potvrdaUnosaButton.Click += new System.EventHandler(this.potvrdaUnosaButton_Click);
            // 
            // gradCombo
            // 
            this.gradCombo.FormattingEnabled = true;
            this.gradCombo.Location = new System.Drawing.Point(101, 245);
            this.gradCombo.Name = "gradCombo";
            this.gradCombo.Size = new System.Drawing.Size(218, 21);
            this.gradCombo.TabIndex = 13;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmBibliotekaUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(759, 412);
            this.Controls.Add(this.gradCombo);
            this.Controls.Add(this.potvrdaUnosaButton);
            this.Controls.Add(this.vrstaCombo);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(this.brojTelTextBox);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBibliotekaUnos";
            this.Text = "frmBiblioteka";
            this.Load += new System.EventHandler(this.frmBibliotekaUnos_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox brojTelTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox vrstaCombo;
        private System.Windows.Forms.Button potvrdaUnosaButton;
        private System.Windows.Forms.ComboBox gradCombo;
        private System.Windows.Forms.ErrorProvider err;
    }
}