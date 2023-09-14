namespace iMean.Tools.NCrypter.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userInputPanel = new iMean.Tools.NCrypter.WinForms.Controls.UserInputPanel();
            this.SuspendLayout();
            // 
            // userInputPanel
            // 
            this.userInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInputPanel.Location = new System.Drawing.Point(0, 0);
            this.userInputPanel.Name = "userInputPanel";
            this.userInputPanel.Size = new System.Drawing.Size(728, 386);
            this.userInputPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 386);
            this.Controls.Add(this.userInputPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "iMean - NCryptR";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserInputPanel userInputPanel;
    }
}