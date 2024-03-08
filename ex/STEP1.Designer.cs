namespace ex
{
    partial class STEP1
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
            this.panelSTEP1 = new System.Windows.Forms.Panel();
            this.dataGridSTEP1 = new System.Windows.Forms.DataGridView();
            this.panelSTEP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSTEP1
            // 
            this.panelSTEP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSTEP1.Controls.Add(this.dataGridSTEP1);
            this.panelSTEP1.Location = new System.Drawing.Point(36, 153);
            this.panelSTEP1.Name = "panelSTEP1";
            this.panelSTEP1.Size = new System.Drawing.Size(902, 202);
            this.panelSTEP1.TabIndex = 1;
            // 
            // dataGridSTEP1
            // 
            this.dataGridSTEP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSTEP1.Location = new System.Drawing.Point(23, 20);
            this.dataGridSTEP1.Name = "dataGridSTEP1";
            this.dataGridSTEP1.RowHeadersWidth = 51;
            this.dataGridSTEP1.RowTemplate.Height = 24;
            this.dataGridSTEP1.Size = new System.Drawing.Size(862, 159);
            this.dataGridSTEP1.TabIndex = 1;
            // 
            // STEP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 509);
            this.Controls.Add(this.panelSTEP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STEP1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEP1";
            this.panelSTEP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSTEP1;
        private System.Windows.Forms.DataGridView dataGridSTEP1;
    }
}