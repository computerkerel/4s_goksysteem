
namespace Goksysteem
{
    partial class StakeForm
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
            this.lbTeams = new System.Windows.Forms.Label();
            this.lbGokken = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbTokenBalans = new System.Windows.Forms.Label();
            this.lbTokens = new System.Windows.Forms.Label();
            this.lbInzetten = new System.Windows.Forms.Label();
            this.txbInzetting = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.lbStake.TabIndex = 15;
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
            this.lbLogout.TabIndex = 14;
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
            this.lbSummary.TabIndex = 13;
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
            this.lbLogo.TabIndex = 12;
            this.lbLogo.Text = "4s";
            this.lbLogo.Click += new System.EventHandler(this.lbLogo_Click);
            // 
            // lbTeams
            // 
            this.lbTeams.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbTeams.AutoSize = true;
            this.lbTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbTeams.Location = new System.Drawing.Point(124, 106);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(179, 58);
            this.lbTeams.TabIndex = 16;
            this.lbTeams.Text = "Teams";
            // 
            // lbGokken
            // 
            this.lbGokken.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbGokken.AutoSize = true;
            this.lbGokken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGokken.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbGokken.Location = new System.Drawing.Point(470, 106);
            this.lbGokken.Name = "lbGokken";
            this.lbGokken.Size = new System.Drawing.Size(198, 58);
            this.lbGokken.TabIndex = 17;
            this.lbGokken.Text = "Gokken";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(50, 186);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(333, 252);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbTokenBalans
            // 
            this.lbTokenBalans.AutoSize = true;
            this.lbTokenBalans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTokenBalans.Location = new System.Drawing.Point(485, 186);
            this.lbTokenBalans.Name = "lbTokenBalans";
            this.lbTokenBalans.Size = new System.Drawing.Size(137, 20);
            this.lbTokenBalans.TabIndex = 19;
            this.lbTokenBalans.Text = "Uw token balans:";
            // 
            // lbTokens
            // 
            this.lbTokens.AutoSize = true;
            this.lbTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTokens.Location = new System.Drawing.Point(641, 186);
            this.lbTokens.Name = "lbTokens";
            this.lbTokens.Size = new System.Drawing.Size(27, 20);
            this.lbTokens.TabIndex = 20;
            this.lbTokens.Text = "50";
            // 
            // lbInzetten
            // 
            this.lbInzetten.AutoSize = true;
            this.lbInzetten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbInzetten.Location = new System.Drawing.Point(430, 286);
            this.lbInzetten.Name = "lbInzetten";
            this.lbInzetten.Size = new System.Drawing.Size(192, 20);
            this.lbInzetten.TabIndex = 21;
            this.lbInzetten.Text = "Aantal token inzettingen:";
            // 
            // txbInzetting
            // 
            this.txbInzetting.Location = new System.Drawing.Point(649, 286);
            this.txbInzetting.Name = "txbInzetting";
            this.txbInzetting.Size = new System.Drawing.Size(100, 20);
            this.txbInzetting.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(547, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 39);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // StakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbInzetting);
            this.Controls.Add(this.lbInzetten);
            this.Controls.Add(this.lbTokens);
            this.Controls.Add(this.lbTokenBalans);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbGokken);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.lbStake);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.lbLogo);
            this.Name = "StakeForm";
            this.Text = "Stake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStake;
        private System.Windows.Forms.Label lbLogout;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label lbTeams;
        private System.Windows.Forms.Label lbGokken;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbTokenBalans;
        private System.Windows.Forms.Label lbTokens;
        private System.Windows.Forms.Label lbInzetten;
        private System.Windows.Forms.TextBox txbInzetting;
        private System.Windows.Forms.Button btnSave;
    }
}