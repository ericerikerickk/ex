namespace ex
{
    partial class Documents
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
            this.panelDocuments = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDocuments.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDocuments
            // 
            this.panelDocuments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDocuments.Controls.Add(this.label1);
            this.panelDocuments.Location = new System.Drawing.Point(43, 177);
            this.panelDocuments.Name = "panelDocuments";
            this.panelDocuments.Size = new System.Drawing.Size(889, 154);
            this.panelDocuments.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "WAY SHAT DIHA?";
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 509);
            this.Controls.Add(this.panelDocuments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Documents";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documents";
            this.panelDocuments.ResumeLayout(false);
            this.panelDocuments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDocuments;
        private System.Windows.Forms.Label label1;
    }
}