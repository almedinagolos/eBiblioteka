
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
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
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
            this.nazivText.TextChanged += new System.EventHandler(this.nazivText_TextChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(678, 415);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(99, 33);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.AllowUserToAddRows = false;
            this.dgvKnjige.AllowUserToDeleteRows = false;
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Opis,
            this.GodinaIzdavanja,
            this.Slika,
            this.Uredi,
            this.Obriši,
            this.Aktivan});
            this.dgvKnjige.Location = new System.Drawing.Point(12, 44);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.ReadOnly = true;
            this.dgvKnjige.RowTemplate.Height = 100;
            this.dgvKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKnjige.Size = new System.Drawing.Size(765, 365);
            this.dgvKnjige.TabIndex = 4;
            this.dgvKnjige.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKnjige_CellContentClick);
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // GodinaIzdavanja
            // 
            this.GodinaIzdavanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GodinaIzdavanja.DataPropertyName = "GodinaIzdavanja";
            this.GodinaIzdavanja.HeaderText = "Godina izdavanja";
            this.GodinaIzdavanja.Name = "GodinaIzdavanja";
            this.GodinaIzdavanja.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Slika.Width = 126;
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
            this.ClientSize = new System.Drawing.Size(806, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazivText);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvKnjige);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKnjige";
            this.Text = "frmKnjige";
            this.Load += new System.EventHandler(this.frmKnjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivText;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaIzdavanja;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn Obriši;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
    }
}