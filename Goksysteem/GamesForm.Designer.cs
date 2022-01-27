
namespace Goksysteem
{
    partial class GamesForm
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
            this.lbSelect = new System.Windows.Forms.Label();
            this.listboxGames = new System.Windows.Forms.ListBox();
            this.lbGames = new System.Windows.Forms.Label();
            this.lbStake = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbSummary = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.txbInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Location = new System.Drawing.Point(613, 144);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(155, 17);
            this.lbSelect.TabIndex = 30;
            this.lbSelect.Text = "Selecteer een wedstrijd";
            // 
            // listboxGames
            // 
            this.listboxGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listboxGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listboxGames.FormattingEnabled = true;
            this.listboxGames.ItemHeight = 29;
            this.listboxGames.Location = new System.Drawing.Point(488, 173);
            this.listboxGames.Name = "listboxGames";
            this.listboxGames.Size = new System.Drawing.Size(413, 236);
            this.listboxGames.TabIndex = 0;
            // 
            // lbGames
            // 
            this.lbGames.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbGames.AutoSize = true;
            this.lbGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbGames.Location = new System.Drawing.Point(371, 86);
            this.lbGames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(290, 58);
            this.lbGames.TabIndex = 28;
            this.lbGames.Text = "Wedstrijden";
            // 
            // lbStake
            // 
            this.lbStake.AutoSize = true;
            this.lbStake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStake.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStake.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbStake.Location = new System.Drawing.Point(580, 27);
            this.lbStake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStake.Name = "lbStake";
            this.lbStake.Size = new System.Drawing.Size(132, 38);
            this.lbStake.TabIndex = 34;
            this.lbStake.Text = "Inzetten";
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.Location = new System.Drawing.Point(785, 27);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(154, 38);
            this.lbLogout.TabIndex = 33;
            this.lbLogout.Text = "Uitloggen";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // lbSummary
            // 
            this.lbSummary.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbSummary.AutoSize = true;
            this.lbSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSummary.Location = new System.Drawing.Point(244, 27);
            this.lbSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(217, 38);
            this.lbSummary.TabIndex = 32;
            this.lbSummary.Text = "Mijn overzicht";
            this.lbSummary.Click += new System.EventHandler(this.lbSummary_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbLogo.Location = new System.Drawing.Point(8, 7);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(78, 58);
            this.lbLogo.TabIndex = 31;
            this.lbLogo.Text = "4s";
            this.lbLogo.Click += new System.EventHandler(this.lbLogo_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChoose.Location = new System.Drawing.Point(435, 420);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(117, 48);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Bevestig";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(559, 437);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 36;
            // 
            // txbInfo
            // 
            this.txbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInfo.Location = new System.Drawing.Point(63, 173);
            this.txbInfo.Multiline = true;
            this.txbInfo.Name = "txbInfo";
            this.txbInfo.ReadOnly = true;
            this.txbInfo.Size = new System.Drawing.Size(398, 236);
            this.txbInfo.TabIndex = 37;
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 514);
            this.Controls.Add(this.txbInfo);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lbStake);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.listboxGames);
            this.Controls.Add(this.lbGames);
            this.Name = "GamesForm";
            this.Text = "Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSelect;
        private System.Windows.Forms.ListBox listboxGames;
        private System.Windows.Forms.Label lbGames;
        private System.Windows.Forms.Label lbStake;
        private System.Windows.Forms.Label lbLogout;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.TextBox txbInfo;
    }
}