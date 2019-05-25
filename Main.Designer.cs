namespace Erkist.Clipboarder
{
    partial class Main
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
            this.HumanFriendlyText = new System.Windows.Forms.TextBox();
            this.ClipboardText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HumanFriendlyText
            // 
            this.HumanFriendlyText.Location = new System.Drawing.Point(13, 13);
            this.HumanFriendlyText.Name = "HumanFriendlyText";
            this.HumanFriendlyText.ReadOnly = true;
            this.HumanFriendlyText.Size = new System.Drawing.Size(450, 20);
            this.HumanFriendlyText.TabIndex = 0;
            // 
            // ClipboardText
            // 
            this.ClipboardText.Location = new System.Drawing.Point(13, 40);
            this.ClipboardText.Name = "ClipboardText";
            this.ClipboardText.ReadOnly = true;
            this.ClipboardText.Size = new System.Drawing.Size(450, 20);
            this.ClipboardText.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 75);
            this.Controls.Add(this.ClipboardText);
            this.Controls.Add(this.HumanFriendlyText);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HumanFriendlyText;
        private System.Windows.Forms.TextBox ClipboardText;
    }
}

