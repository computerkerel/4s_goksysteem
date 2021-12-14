
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
            this.lbGamble = new System.Windows.Forms.Label();
            this.lbTokenBalance = new System.Windows.Forms.Label();
            this.lbTokens = new System.Windows.Forms.Label();
            this.lbStakes = new System.Windows.Forms.Label();
            this.txbStakeAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGamble
            // 
            this.lbGamble.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbGamble.AutoSize = true;
            this.lbGamble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGamble.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbGamble.Location = new System.Drawing.Point(419, 79);
            this.lbGamble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGamble.Name = "lbGamble";
            this.lbGamble.Size = new System.Drawing.Size(198, 58);
            this.lbGamble.TabIndex = 17;
            this.lbGamble.Text = "Gokken";
            // 
            // lbTokenBalance
            // 
            this.lbTokenBalance.AutoSize = true;
            this.lbTokenBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTokenBalance.Location = new System.Drawing.Point(395, 177);
            this.lbTokenBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTokenBalance.Name = "lbTokenBalance";
            this.lbTokenBalance.Size = new System.Drawing.Size(137, 20);
            this.lbTokenBalance.TabIndex = 19;
            this.lbTokenBalance.Text = "Uw token balans:";
            // 
            // lbTokens
            // 
            this.lbTokens.AutoSize = true;
            this.lbTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTokens.Location = new System.Drawing.Point(603, 177);
            this.lbTokens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTokens.Name = "lbTokens";
            this.lbTokens.Size = new System.Drawing.Size(27, 20);
            this.lbTokens.TabIndex = 20;
            this.lbTokens.Text = "50";
            // 
            // lbStakes
            // 
            this.lbStakes.AutoSize = true;
            this.lbStakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbStakes.Location = new System.Drawing.Point(321, 300);
            this.lbStakes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStakes.Name = "lbStakes";
            this.lbStakes.Size = new System.Drawing.Size(192, 20);
            this.lbStakes.TabIndex = 21;
            this.lbStakes.Text = "Aantal token inzettingen:";
            // 
            // txbStakeAmount
            // 
            this.txbStakeAmount.Location = new System.Drawing.Point(613, 300);
            this.txbStakeAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStakeAmount.Name = "txbStakeAmount";
            this.txbStakeAmount.Size = new System.Drawing.Size(132, 22);
            this.txbStakeAmount.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(477, 418);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 48);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(613, 274);
            this.lbError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 24;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(617, 446);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 17);
            this.lbMessage.TabIndex = 25;
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbBack.Location = new System.Drawing.Point(13, 9);
            this.lbBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(100, 29);
            this.lbBack.TabIndex = 26;
            this.lbBack.Text = "< Terug";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // StakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbStakeAmount);
            this.Controls.Add(this.lbStakes);
            this.Controls.Add(this.lbTokens);
            this.Controls.Add(this.lbTokenBalance);
            this.Controls.Add(this.lbGamble);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StakeForm";
            this.Text = "Stake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbGamble;
        private System.Windows.Forms.Label lbTokenBalance;
        private System.Windows.Forms.Label lbTokens;
        private System.Windows.Forms.Label lbStakes;
        private System.Windows.Forms.TextBox txbStakeAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbBack;
    }
}