namespace LTCPriceChecker
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxuserLTCAmount = new System.Windows.Forms.TextBox();
            this.labelPutYourLTCAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(174, 70);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBoxuserLTCAmount
            // 
            this.textBoxuserLTCAmount.Location = new System.Drawing.Point(126, 88);
            this.textBoxuserLTCAmount.Name = "textBoxuserLTCAmount";
            this.textBoxuserLTCAmount.Size = new System.Drawing.Size(60, 20);
            this.textBoxuserLTCAmount.TabIndex = 1;
            this.textBoxuserLTCAmount.Text = "0";
            this.textBoxuserLTCAmount.TextChanged += new System.EventHandler(this.textBoxuserLTCAmount_TextChanged);
            // 
            // labelPutYourLTCAmount
            // 
            this.labelPutYourLTCAmount.AutoSize = true;
            this.labelPutYourLTCAmount.Location = new System.Drawing.Point(12, 91);
            this.labelPutYourLTCAmount.Name = "labelPutYourLTCAmount";
            this.labelPutYourLTCAmount.Size = new System.Drawing.Size(35, 13);
            this.labelPutYourLTCAmount.TabIndex = 2;
            this.labelPutYourLTCAmount.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(196, 115);
            this.Controls.Add(this.labelPutYourLTCAmount);
            this.Controls.Add(this.textBoxuserLTCAmount);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LTC Value";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxuserLTCAmount;
        private System.Windows.Forms.Label labelPutYourLTCAmount;
    }
}

