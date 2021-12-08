
namespace eBiblioteka.WinUI
{
    partial class Login
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
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrijavaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(113, 73);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(193, 20);
            this.korisnickoImeTextBox.TabIndex = 0;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(113, 126);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.PasswordChar = '*';
            this.lozinkaTextBox.Size = new System.Drawing.Size(193, 20);
            this.lozinkaTextBox.TabIndex = 1;
            this.lozinkaTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // PrijavaButton
            // 
            this.PrijavaButton.Location = new System.Drawing.Point(171, 161);
            this.PrijavaButton.Name = "PrijavaButton";
            this.PrijavaButton.Size = new System.Drawing.Size(75, 23);
            this.PrijavaButton.TabIndex = 2;
            this.PrijavaButton.Text = "Prijava";
            this.PrijavaButton.UseVisualStyleBackColor = true;
            this.PrijavaButton.Click += new System.EventHandler(this.PrijavaButton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.PrijavaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 234);
            this.Controls.Add(this.PrijavaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrijavaButton;
    }
}