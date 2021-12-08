
namespace eBiblioteka.WinUI
{
    partial class frmKnjige
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
            this.nazivText = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvBiblioteke = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv:";
            // 
            // nazivText
            // 
            this.nazivText.Location = new System.Drawing.Point(70, 10);
            this.nazivText.Name = "nazivText";
            this.nazivText.Size = new System.Drawing.Size(163, 20);
            this.nazivText.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(632, 328);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(99, 33);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // dgvBiblioteke
            // 
            this.dgvBiblioteke.AllowUserToAddRows = false;
            this.dgvBiblioteke.AllowUserToDeleteRows = false;
            this.dgvBiblioteke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiblioteke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Adresa,
            this.Email,
            this.BrojTelefona,
            this.Uredi,
            this.Obriši,
            this.Aktivan});
            this.dgvBiblioteke.Location = new System.Drawing.Point(12, 44);
            this.dgvBiblioteke.Name = "dgvBiblioteke";
            this.dgvBiblioteke.ReadOnly = true;
            this.dgvBiblioteke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBiblioteke.Size = new System.Drawing.Size(719, 278);
            this.dgvBiblioteke.TabIndex = 4;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojTelefona.DataPropertyName = "BrojTelefona";
            this.BrojTelefona.HeaderText = "Broj Telefona";
            this.BrojTelefona.Name = "BrojTelefona";
            this.BrojTelefona.ReadOnly = true;
            // 
            // Uredi
            // 
            this.Uredi.HeaderText = "Uredi";
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            this.Uredi.Width = 60;
            // 
            // Obriši
            // 
            this.Obriši.HeaderText = "Obriši";
            this.Obriši.Name = "Obriši";
            this.Obriši.ReadOnly = true;
            this.Obriši.Text = "Obriši";
            this.Obriši.UseColumnTextForButtonValue = true;
            this.Obriši.Width = 60;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Width = 50;
            // 
            // frmKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazivText);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvBiblioteke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKnjige";
            this.Text = "frmKnjige";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivText;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvBiblioteke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn Obriši;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
    }
}