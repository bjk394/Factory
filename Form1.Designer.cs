namespace Factory
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
            this.ServeBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ServeBox
            // 
            this.ServeBox.Location = new System.Drawing.Point(122, 53);
            this.ServeBox.Name = "ServeBox";
            this.ServeBox.Size = new System.Drawing.Size(218, 20);
            this.ServeBox.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(195, 79);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(122, 108);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(218, 20);
            this.outBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 218);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ServeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServeBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox outBox;
    }
}

