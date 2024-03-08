namespace ex
{
    partial class STEP3
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
            this.panelSTEP2 = new System.Windows.Forms.Panel();
            this.dataGridSTEP2 = new System.Windows.Forms.DataGridView();
            this.panelSTEP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSTEP2
            // 
            this.panelSTEP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSTEP2.Controls.Add(this.dataGridSTEP2);
            this.panelSTEP2.Location = new System.Drawing.Point(36, 153);
            this.panelSTEP2.Name = "panelSTEP2";
            this.panelSTEP2.Size = new System.Drawing.Size(902, 202);
            this.panelSTEP2.TabIndex = 3;
            // 
            // dataGridSTEP2
            // 
            this.dataGridSTEP2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSTEP2.Location = new System.Drawing.Point(23, 20);
            this.dataGridSTEP2.Name = "dataGridSTEP2";
            this.dataGridSTEP2.RowHeadersWidth = 51;
            this.dataGridSTEP2.RowTemplate.Height = 24;
            this.dataGridSTEP2.Size = new System.Drawing.Size(862, 159);
            this.dataGridSTEP2.TabIndex = 1;
            // 
            // STEP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 509);
            this.Controls.Add(this.panelSTEP2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STEP3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEP3";
            this.panelSTEP2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSTEP2;
        private System.Windows.Forms.DataGridView dataGridSTEP2;
    }
}