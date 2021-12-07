
namespace Goksysteem
{
    partial class HomeForm
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
            this.lbStake = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbSummary = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.txbHome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbStake
            // 
            this.lbStake.AutoSize = true;
            this.lbStake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStake.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStake.Location = new System.Drawing.Point(441, 25);
            this.lbStake.Name = "lbStake";
            this.lbStake.Size = new System.Drawing.Size(132, 38);
            this.lbStake.TabIndex = 11;
            this.lbStake.Text = "Inzetten";
            this.lbStake.Click += new System.EventHandler(this.lbStake_Click);
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.Location = new System.Drawing.Point(595, 25);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(154, 38);
            this.lbLogout.TabIndex = 10;
            this.lbLogout.Text = "Uitloggen";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // lbSummary
            // 
            this.lbSummary.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbSummary.AutoSize = true;
            this.lbSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSummary.Location = new System.Drawing.Point(189, 25);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(217, 38);
            this.lbSummary.TabIndex = 9;
            this.lbSummary.Text = "Mijn overzicht";
            this.lbSummary.Click += new System.EventHandler(this.lbSummary_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbLogo.Location = new System.Drawing.Point(12, 9);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(78, 58);
            this.lbLogo.TabIndex = 8;
            this.lbLogo.Text = "4s";
            this.lbLogo.Click += new System.EventHandler(this.lbLogo_Click);
            // 
            // txbHome
            // 
            this.txbHome.BackColor = System.Drawing.SystemColors.Info;
            this.txbHome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.txbHome.Location = new System.Drawing.Point(63, 95);
            this.txbHome.Multiline = true;
            this.txbHome.Name = "txbHome";
            this.txbHome.ReadOnly = true;
            this.txbHome.Size = new System.Drawing.Size(686, 321);
            this.txbHome.TabIndex = 13;
            this.txbHome.TabStop = false;
            this.txbHome.Text = "Zet jouw tokens in voor de uitslag van onze voetbal wedstrijden";
            this.txbHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbHome);
            this.Controls.Add(this.lbStake);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.lbLogo);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStake;
        private System.Windows.Forms.Label lbLogout;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.TextBox txbHome;
    }
}