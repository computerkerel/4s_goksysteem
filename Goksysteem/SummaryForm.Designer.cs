
namespace Goksysteem
{
    partial class SummaryForm
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
            this.lbhistory = new System.Windows.Forms.Label();
            this.lbPending = new System.Windows.Forms.Label();
            this.lbTokens = new System.Windows.Forms.Label();
            this.lbTokenBalance = new System.Windows.Forms.Label();
            this.txbHistory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbStake
            // 
            this.lbStake.AutoSize = true;
            this.lbStake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStake.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStake.Location = new System.Drawing.Point(588, 31);
            this.lbStake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lbLogout.Location = new System.Drawing.Point(793, 31);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lbSummary.BackColor = System.Drawing.SystemColors.Control;
            this.lbSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSummary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbSummary.Location = new System.Drawing.Point(252, 31);
            this.lbSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lbLogo.Location = new System.Drawing.Point(16, 11);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(78, 58);
            this.lbLogo.TabIndex = 8;
            this.lbLogo.Text = "4s";
            this.lbLogo.Click += new System.EventHandler(this.lbLogo_Click);
            // 
            // lbhistory
            // 
            this.lbhistory.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.lbhistory.AutoSize = true;
            this.lbhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbhistory.Location = new System.Drawing.Point(171, 135);
            this.lbhistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhistory.Name = "lbhistory";
            this.lbhistory.Size = new System.Drawing.Size(329, 58);
            this.lbhistory.TabIndex = 17;
            this.lbhistory.Text = "Geschiedenis";
            // 
            // lbPending
            // 
            this.lbPending.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.lbPending.AutoSize = true;
            this.lbPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbPending.Location = new System.Drawing.Point(689, 135);
            this.lbPending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPending.Name = "lbPending";
            this.lbPending.Size = new System.Drawing.Size(150, 58);
            this.lbPending.TabIndex = 18;
            this.lbPending.Text = "Actief";
            // 
            // lbTokens
            // 
            this.lbTokens.AutoSize = true;
            this.lbTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTokens.Location = new System.Drawing.Point(232, 518);
            this.lbTokens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTokens.Name = "lbTokens";
            this.lbTokens.Size = new System.Drawing.Size(82, 20);
            this.lbTokens.TabIndex = 22;
            this.lbTokens.Text = "niet actief";
            // 
            // lbTokenBalance
            // 
            this.lbTokenBalance.AutoSize = true;
            this.lbTokenBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTokenBalance.Location = new System.Drawing.Point(24, 518);
            this.lbTokenBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTokenBalance.Name = "lbTokenBalance";
            this.lbTokenBalance.Size = new System.Drawing.Size(137, 20);
            this.lbTokenBalance.TabIndex = 21;
            this.lbTokenBalance.Text = "Uw token balans:";
            // 
            // txbHistory
            // 
            this.txbHistory.Location = new System.Drawing.Point(167, 227);
            this.txbHistory.Multiline = true;
            this.txbHistory.Name = "txbHistory";
            this.txbHistory.ReadOnly = true;
            this.txbHistory.Size = new System.Drawing.Size(333, 230);
            this.txbHistory.TabIndex = 23;
            this.txbHistory.TabStop = false;
            this.txbHistory.Text = "Het is leeg hier";
            this.txbHistory.TextChanged += new System.EventHandler(this.txbHistory_TextChanged);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txbHistory);
            this.Controls.Add(this.lbTokens);
            this.Controls.Add(this.lbTokenBalance);
            this.Controls.Add(this.lbPending);
            this.Controls.Add(this.lbhistory);
            this.Controls.Add(this.lbStake);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.lbLogo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SummaryForm";
            this.Text = "Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStake;
        private System.Windows.Forms.Label lbLogout;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label lbhistory;
        private System.Windows.Forms.Label lbPending;
        private System.Windows.Forms.Label lbTokens;
        private System.Windows.Forms.Label lbTokenBalance;
        private System.Windows.Forms.TextBox txbHistory;
    }
}