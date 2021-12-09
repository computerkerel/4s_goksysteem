
namespace Goksysteem
{
    partial class RegisterForm
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
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbPassword.Location = new System.Drawing.Point(351, 234);
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(343, 44);
            this.txbPassword.TabIndex = 18;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbPassword.Location = new System.Drawing.Point(121, 239);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(206, 39);
            this.lbPassword.TabIndex = 17;
            this.lbPassword.Text = "Wachtwoord";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbUsername.Location = new System.Drawing.Point(107, 74);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(238, 39);
            this.lbUsername.TabIndex = 16;
            this.lbUsername.Text = "Gebruiksnaam";
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbUsername.Location = new System.Drawing.Point(351, 74);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(343, 44);
            this.txbUsername.TabIndex = 15;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRegister.Location = new System.Drawing.Point(329, 316);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(172, 66);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Registreer";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbEmail.Location = new System.Drawing.Point(169, 154);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(114, 39);
            this.lbEmail.TabIndex = 20;
            this.lbEmail.Text = "E-mail";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbEmail.Location = new System.Drawing.Point(351, 154);
            this.txbEmail.Multiline = true;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(343, 44);
            this.txbEmail.TabIndex = 19;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(348, 56);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 15);
            this.lbError.TabIndex = 21;
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbBack.Location = new System.Drawing.Point(12, 9);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(100, 29);
            this.lbBack.TabIndex = 22;
            this.lbBack.Text = "< Terug";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.btnRegister);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbBack;
    }
}