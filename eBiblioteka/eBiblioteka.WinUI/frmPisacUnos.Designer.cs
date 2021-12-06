
namespace eBiblioteka.WinUI
{
    partial class frmPisacUnos
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
            this.DatumRodjenjaDtp = new System.Windows.Forms.DateTimePicker();
            this.BiografijaTextBox = new System.Windows.Forms.TextBox();
            this.potvrdaUnosaButton = new System.Windows.Forms.Button();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // DatumRodjenjaDtp
            // 
            this.DatumRodjenjaDtp.Location = new System.Drawing.Point(33, 237);
            this.DatumRodjenjaDtp.Name = "DatumRodjenjaDtp";
            this.DatumRodjenjaDtp.Size = new System.Drawing.Size(218, 20);
            this.DatumRodjenjaDtp.TabIndex = 33;
            // 
            // BiografijaTextBox
            // 
            this.BiografijaTextBox.Location = new System.Drawing.Point(281, 50);
            this.BiografijaTextBox.Multiline = true;
            this.BiografijaTextBox.Name = "BiografijaTextBox";
            this.BiografijaTextBox.Size = new System.Drawing.Size(346, 253);
            this.BiografijaTextBox.TabIndex = 30;
            // 
            // potvrdaUnosaButton
            // 
            this.potvrdaUnosaButton.Location = new System.Drawing.Point(501, 316);
            this.potvrdaUnosaButton.Name = "potvrdaUnosaButton";
            this.potvrdaUnosaButton.Size = new System.Drawing.Size(126, 27);
            this.potvrdaUnosaButton.TabIndex = 29;
            this.potvrdaUnosaButton.Text = "Potvrda unosa";
            this.potvrdaUnosaButton.UseVisualStyleBackColor = true;
            this.potvrdaUnosaButton.Click += new System.EventHandler(this.potvrdaUnosaButton_Click);
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(33, 142);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(218, 20);
            this.prezimeTextBox.TabIndex = 27;
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(33, 50);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(218, 20);
            this.imeTextBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Datum rođenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Biografija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ime:";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmPisacUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 355);
            this.Controls.Add(this.DatumRodjenjaDtp);
            this.Controls.Add(this.BiografijaTextBox);
            this.Controls.Add(this.potvrdaUnosaButton);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPisacUnos";
            this.Text = "frmPisacUnos";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatumRodjenjaDtp;
        private System.Windows.Forms.TextBox BiografijaTextBox;
        private System.Windows.Forms.Button potvrdaUnosaButton;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider err;
    }
}