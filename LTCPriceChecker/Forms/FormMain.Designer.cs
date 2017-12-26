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
            this.labelPutYourBTCAmount = new System.Windows.Forms.Label();
            this.textBoxuserBTCAmount = new System.Windows.Forms.TextBox();
            this.buttonChangeOptions = new System.Windows.Forms.Button();
            this.checkBoxTest = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(174, 70);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "WELCOME goto www.Lomaz.pl";
            // 
            // textBoxuserLTCAmount
            // 
            this.textBoxuserLTCAmount.Location = new System.Drawing.Point(126, 88);
            this.textBoxuserLTCAmount.Name = "textBoxuserLTCAmount";
            this.textBoxuserLTCAmount.Size = new System.Drawing.Size(60, 20);
            this.textBoxuserLTCAmount.TabIndex = 1;
            this.textBoxuserLTCAmount.Text = "0,5";
            // 
            // labelPutYourLTCAmount
            // 
            this.labelPutYourLTCAmount.AutoSize = true;
            this.labelPutYourLTCAmount.Location = new System.Drawing.Point(12, 91);
            this.labelPutYourLTCAmount.Name = "labelPutYourLTCAmount";
            this.labelPutYourLTCAmount.Size = new System.Drawing.Size(123, 13);
            this.labelPutYourLTCAmount.TabIndex = 2;
            this.labelPutYourLTCAmount.Text = "labelPutYourLTCAmount";
            // 
            // labelPutYourBTCAmount
            // 
            this.labelPutYourBTCAmount.AutoSize = true;
            this.labelPutYourBTCAmount.Location = new System.Drawing.Point(12, 117);
            this.labelPutYourBTCAmount.Name = "labelPutYourBTCAmount";
            this.labelPutYourBTCAmount.Size = new System.Drawing.Size(124, 13);
            this.labelPutYourBTCAmount.TabIndex = 3;
            this.labelPutYourBTCAmount.Text = "labelPutYourBTCAmount";
            // 
            // textBoxuserBTCAmount
            // 
            this.textBoxuserBTCAmount.Location = new System.Drawing.Point(126, 114);
            this.textBoxuserBTCAmount.Name = "textBoxuserBTCAmount";
            this.textBoxuserBTCAmount.Size = new System.Drawing.Size(60, 20);
            this.textBoxuserBTCAmount.TabIndex = 4;
            this.textBoxuserBTCAmount.Text = "0,5";
            // 
            // buttonChangeOptions
            // 
            this.buttonChangeOptions.Location = new System.Drawing.Point(15, 140);
            this.buttonChangeOptions.Name = "buttonChangeOptions";
            this.buttonChangeOptions.Size = new System.Drawing.Size(169, 23);
            this.buttonChangeOptions.TabIndex = 6;
            this.buttonChangeOptions.Text = "buttonChangeOptions";
            this.buttonChangeOptions.UseVisualStyleBackColor = true;
            this.buttonChangeOptions.Click += new System.EventHandler(this.buttonChangeOptions_Click);
            // 
            // checkBoxTest
            // 
            this.checkBoxTest.AutoSize = true;
            this.checkBoxTest.Location = new System.Drawing.Point(12, 68);
            this.checkBoxTest.Name = "checkBoxTest";
            this.checkBoxTest.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTest.TabIndex = 7;
            this.checkBoxTest.UseVisualStyleBackColor = true;
            this.checkBoxTest.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(196, 177);
            this.Controls.Add(this.checkBoxTest);
            this.Controls.Add(this.buttonChangeOptions);
            this.Controls.Add(this.textBoxuserBTCAmount);
            this.Controls.Add(this.labelPutYourBTCAmount);
            this.Controls.Add(this.labelPutYourLTCAmount);
            this.Controls.Add(this.textBoxuserLTCAmount);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto value";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxuserLTCAmount;
        private System.Windows.Forms.Label labelPutYourLTCAmount;
        private System.Windows.Forms.Label labelPutYourBTCAmount;
        private System.Windows.Forms.TextBox textBoxuserBTCAmount;
        private System.Windows.Forms.Button buttonChangeOptions;
        private System.Windows.Forms.CheckBox checkBoxTest;
    }
}

