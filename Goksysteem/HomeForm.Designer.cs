
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.aantalTokens = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStake
            // 
            this.lbStake.AutoSize = true;
            this.lbStake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStake.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStake.Location = new System.Drawing.Point(468, 42);
            this.lbStake.Name = "lbStake";
            this.lbStake.Size = new System.Drawing.Size(112, 31);
            this.lbStake.TabIndex = 11;
            this.lbStake.Text = "Inzetten";
            this.lbStake.Click += new System.EventHandler(this.lbStake_Click);
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.Location = new System.Drawing.Point(612, 42);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(129, 31);
            this.lbLogout.TabIndex = 10;
            this.lbLogout.Text = "Uitloggen";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // lbSummary
            // 
            this.lbSummary.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbSummary.AutoSize = true;
            this.lbSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSummary.Location = new System.Drawing.Point(250, 42);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(182, 33);
            this.lbSummary.TabIndex = 9;
            this.lbSummary.Text = "Mijn overzicht";
            this.lbSummary.Click += new System.EventHandler(this.lbSummary_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbLogo.Location = new System.Drawing.Point(35, 30);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(136, 46);
            this.lbLogo.TabIndex = 8;
            this.lbLogo.Text = "(Logo)";
            this.lbLogo.Click += new System.EventHandler(this.lbLogo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(323, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.30434F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 250);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // aantalTokens
            // 
            this.aantalTokens.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.aantalTokens.AutoSize = true;
            this.aantalTokens.Cursor = System.Windows.Forms.Cursors.Default;
            this.aantalTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantalTokens.Location = new System.Drawing.Point(151, 373);
            this.aantalTokens.Name = "aantalTokens";
            this.aantalTokens.Size = new System.Drawing.Size(29, 31);
            this.aantalTokens.TabIndex = 13;
            this.aantalTokens.Text = "0";
            this.aantalTokens.Click += new System.EventHandler(this.aantalTokens_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pietje Jan";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Totaal:";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "Actieve wedstrijden";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStake);
            this.Controls.Add(this.aantalTokens);
            this.Controls.Add(this.tableLayoutPanel1);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label aantalTokens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}