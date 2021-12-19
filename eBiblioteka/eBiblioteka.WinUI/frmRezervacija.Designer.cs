
namespace eBiblioteka.WinUI
{
    partial class frmRezervacija
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
            this.imePrezimeText = new System.Windows.Forms.TextBox();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Knjiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Poništi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime ili prezime člana:";
            // 
            // imePrezimeText
            // 
            this.imePrezimeText.Location = new System.Drawing.Point(122, 12);
            this.imePrezimeText.Name = "imePrezimeText";
            this.imePrezimeText.Size = new System.Drawing.Size(609, 20);
            this.imePrezimeText.TabIndex = 10;
            this.imePrezimeText.TextChanged += new System.EventHandler(this.imePrezimeText_TextChanged);
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumRezervacije,
            this.Clan,
            this.Knjiga,
            this.Izdaj,
            this.Poništi,
            this.Aktivan});
            this.dgvRezervacije.Location = new System.Drawing.Point(12, 46);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.RowTemplate.Height = 25;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(719, 278);
            this.dgvRezervacije.TabIndex = 8;
            this.dgvRezervacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervacije_CellContentClick);
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
            // 
            // Clan
            // 
            this.Clan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Clan.DataPropertyName = "Clan";
            this.Clan.HeaderText = "Ime i prezime člana";
            this.Clan.Name = "Clan";
            this.Clan.ReadOnly = true;
            // 
            // Knjiga
            // 
            this.Knjiga.DataPropertyName = "Knjiga";
            this.Knjiga.HeaderText = "Knjiga";
            this.Knjiga.Name = "Knjiga";
            this.Knjiga.ReadOnly = true;
            // 
            // Izdaj
            // 
            this.Izdaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Izdaj.HeaderText = "Izdaj";
            this.Izdaj.Name = "Izdaj";
            this.Izdaj.ReadOnly = true;
            this.Izdaj.Text = "Izdaj";
            this.Izdaj.UseColumnTextForButtonValue = true;
            // 
            // Poništi
            // 
            this.Poništi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Poništi.HeaderText = "Poništi";
            this.Poništi.Name = "Poništi";
            this.Poništi.ReadOnly = true;
            this.Poništi.Text = "Poništi";
            this.Poništi.UseColumnTextForButtonValue = true;
            this.Poništi.Width = 131;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivna";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Width = 50;
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imePrezimeText);
            this.Controls.Add(this.dgvRezervacije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervacija";
            this.Text = "frmRezervacija";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.frmRezervacija_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imePrezimeText;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Knjiga;
        private System.Windows.Forms.DataGridViewButtonColumn Izdaj;
        private System.Windows.Forms.DataGridViewButtonColumn Poništi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
    }
}