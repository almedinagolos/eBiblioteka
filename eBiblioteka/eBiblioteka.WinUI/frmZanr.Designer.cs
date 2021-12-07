
namespace eBiblioteka.WinUI
{
    partial class frmZanr
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nazivText = new System.Windows.Forms.TextBox();
            this.dgvZanr = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(262, 194);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(99, 33);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv:";
            // 
            // nazivText
            // 
            this.nazivText.Location = new System.Drawing.Point(78, 9);
            this.nazivText.Name = "nazivText";
            this.nazivText.Size = new System.Drawing.Size(283, 20);
            this.nazivText.TabIndex = 12;
            // 
            // dgvZanr
            // 
            this.dgvZanr.AllowUserToAddRows = false;
            this.dgvZanr.AllowUserToDeleteRows = false;
            this.dgvZanr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZanr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Uredi,
            this.Obriši,
            this.Aktivan});
            this.dgvZanr.Location = new System.Drawing.Point(12, 44);
            this.dgvZanr.Name = "dgvZanr";
            this.dgvZanr.ReadOnly = true;
            this.dgvZanr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZanr.Size = new System.Drawing.Size(349, 144);
            this.dgvZanr.TabIndex = 11;
            this.dgvZanr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZanr_CellContentClick);
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
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
            // frmZanr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 245);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazivText);
            this.Controls.Add(this.dgvZanr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmZanr";
            this.Text = "frmZanr";
            this.Load += new System.EventHandler(this.frmZanr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivText;
        private System.Windows.Forms.DataGridView dgvZanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn Obriši;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
    }
}