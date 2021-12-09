
namespace eBiblioteka.WinUI
{
    partial class frmKnjigeUnos
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.unesiButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bibliotekaCombo = new System.Windows.Forms.ComboBox();
            this.zanrCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpGodIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(148, 245);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(180, 50);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(204, 20);
            this.nazivTextBox.TabIndex = 3;
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(181, 167);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(204, 99);
            this.opisTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis";
            // 
            // unesiButton
            // 
            this.unesiButton.Location = new System.Drawing.Point(516, 233);
            this.unesiButton.Name = "unesiButton";
            this.unesiButton.Size = new System.Drawing.Size(134, 33);
            this.unesiButton.TabIndex = 0;
            this.unesiButton.Text = "Potvrda unosa";
            this.unesiButton.UseVisualStyleBackColor = true;
            this.unesiButton.Click += new System.EventHandler(this.unesiButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Biblioteka";
            // 
            // bibliotekaCombo
            // 
            this.bibliotekaCombo.FormattingEnabled = true;
            this.bibliotekaCombo.Location = new System.Drawing.Point(459, 50);
            this.bibliotekaCombo.Name = "bibliotekaCombo";
            this.bibliotekaCombo.Size = new System.Drawing.Size(191, 21);
            this.bibliotekaCombo.TabIndex = 13;
            // 
            // zanrCombo
            // 
            this.zanrCombo.FormattingEnabled = true;
            this.zanrCombo.Location = new System.Drawing.Point(459, 107);
            this.zanrCombo.Name = "zanrCombo";
            this.zanrCombo.Size = new System.Drawing.Size(191, 21);
            this.zanrCombo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Žanr";
            // 
            // dtpGodIzdavanja
            // 
            this.dtpGodIzdavanja.Location = new System.Drawing.Point(181, 108);
            this.dtpGodIzdavanja.Name = "dtpGodIzdavanja";
            this.dtpGodIzdavanja.Size = new System.Drawing.Size(200, 20);
            this.dtpGodIzdavanja.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Godina izdavanja";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmKnjigeUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 334);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpGodIzdavanja);
            this.Controls.Add(this.zanrCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bibliotekaCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unesiButton);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKnjigeUnos";
            this.Text = "frmKnjigeUnos";
            this.Load += new System.EventHandler(this.frmKnjigeUnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button unesiButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bibliotekaCombo;
        private System.Windows.Forms.ComboBox zanrCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpGodIzdavanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}