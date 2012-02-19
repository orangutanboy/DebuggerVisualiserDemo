namespace VisualiserDemo
{
    partial class StartupForm
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
            this.doStuffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doStuffButton
            // 
            this.doStuffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doStuffButton.Location = new System.Drawing.Point(90, 14);
            this.doStuffButton.Name = "doStuffButton";
            this.doStuffButton.Size = new System.Drawing.Size(75, 23);
            this.doStuffButton.TabIndex = 0;
            this.doStuffButton.Text = "Do Stuff";
            this.doStuffButton.UseVisualStyleBackColor = true;
            this.doStuffButton.Click += new System.EventHandler(this.doStuffButton_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 50);
            this.Controls.Add(this.doStuffButton);
            this.Name = "StartupForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doStuffButton;
    }
}

