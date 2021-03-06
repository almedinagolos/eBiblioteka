
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
            this.components = new System.ComponentModel.Container();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nazivText = new System.Windows.Forms.TextBox();
            this.dgvZanr = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dodajZanrLabel = new System.Windows.Forms.Label();
            this.zanrTextBox = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(398, 318);
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
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pretraga:";
            // 
            // nazivText
            // 
            this.nazivText.Location = new System.Drawing.Point(85, 11);
            this.nazivText.Name = "nazivText";
            this.nazivText.Size = new System.Drawing.Size(412, 20);
            this.nazivText.TabIndex = 12;
            this.nazivText.TextChanged += new System.EventHandler(this.nazivText_TextChanged);
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
            this.dgvZanr.Location = new System.Drawing.Point(21, 46);
            this.dgvZanr.Name = "dgvZanr";
            this.dgvZanr.ReadOnly = true;
            this.dgvZanr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZanr.Size = new System.Drawing.Size(476, 240);
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
            // dodajZanrLabel
            // 
            this.dodajZanrLabel.AutoSize = true;
            this.dodajZanrLabel.Location = new System.Drawing.Point(18, 295);
            this.dodajZanrLabel.Name = "dodajZanrLabel";
            this.dodajZanrLabel.Size = new System.Drawing.Size(61, 13);
            this.dodajZanrLabel.TabIndex = 16;
            this.dodajZanrLabel.Text = "Dodaj žanr:";
            // 
            // zanrTextBox
            // 
            this.zanrTextBox.Location = new System.Drawing.Point(85, 292);
            this.zanrTextBox.Name = "zanrTextBox";
            this.zanrTextBox.Size = new System.Drawing.Size(412, 20);
            this.zanrTextBox.TabIndex = 15;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmZanr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 460);
            this.Controls.Add(this.dodajZanrLabel);
            this.Controls.Add(this.zanrTextBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazivText);
            this.Controls.Add(this.dgvZanr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmZanr";
            this.Text = "frmZanr";
            this.Load += new System.EventHandler(this.frmZanr_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.frmZanr_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
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
        private System.Windows.Forms.Label dodajZanrLabel;
        private System.Windows.Forms.TextBox zanrTextBox;
        private System.Windows.Forms.ErrorProvider err;
    }
}