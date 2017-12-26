namespace CryptoPriceChecker
{
    partial class FormOptions
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
            this.checkBoxAllwaysOnTop = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAcceptOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxAllwaysOnTop
            // 
            this.checkBoxAllwaysOnTop.AutoSize = true;
            this.checkBoxAllwaysOnTop.Location = new System.Drawing.Point(12, 12);
            this.checkBoxAllwaysOnTop.Name = "checkBoxAllwaysOnTop";
            this.checkBoxAllwaysOnTop.Size = new System.Drawing.Size(142, 17);
            this.checkBoxAllwaysOnTop.TabIndex = 0;
            this.checkBoxAllwaysOnTop.Text = "checkBoxAllwaysOnTop";
            this.checkBoxAllwaysOnTop.UseVisualStyleBackColor = true;
            this.checkBoxAllwaysOnTop.CheckedChanged += new System.EventHandler(this.checkBoxAllwaysOnTop_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Some other options will be later";
            // 
            // buttonAcceptOptions
            // 
            this.buttonAcceptOptions.Location = new System.Drawing.Point(90, 77);
            this.buttonAcceptOptions.Name = "buttonAcceptOptions";
            this.buttonAcceptOptions.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptOptions.TabIndex = 2;
            this.buttonAcceptOptions.Text = "buttonAcceptOptions";
            this.buttonAcceptOptions.UseVisualStyleBackColor = true;
            this.buttonAcceptOptions.Click += new System.EventHandler(this.buttonAcceptOptions_Click);
            // 
            // FormOptions
            // 
            this.AcceptButton = this.buttonAcceptOptions;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 105);
            this.Controls.Add(this.buttonAcceptOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxAllwaysOnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAllwaysOnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAcceptOptions;
    }
}