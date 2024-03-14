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
            this.panelSTEP3 = new System.Windows.Forms.Panel();
            this.btnReceivestep3 = new System.Windows.Forms.Button();
            this.dataGridSTEP3 = new System.Windows.Forms.DataGridView();
            this.labelStep3 = new System.Windows.Forms.Label();
            this.panelSTEP3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSTEP3
            // 
            this.panelSTEP3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSTEP3.Controls.Add(this.btnReceivestep3);
            this.panelSTEP3.Controls.Add(this.dataGridSTEP3);
            this.panelSTEP3.Location = new System.Drawing.Point(12, 38);
            this.panelSTEP3.Name = "panelSTEP3";
            this.panelSTEP3.Size = new System.Drawing.Size(950, 432);
            this.panelSTEP3.TabIndex = 2;
            // 
            // btnReceivestep3
            // 
            this.btnReceivestep3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReceivestep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceivestep3.ForeColor = System.Drawing.Color.White;
            this.btnReceivestep3.Location = new System.Drawing.Point(371, 364);
            this.btnReceivestep3.Name = "btnReceivestep3";
            this.btnReceivestep3.Size = new System.Drawing.Size(197, 43);
            this.btnReceivestep3.TabIndex = 2;
            this.btnReceivestep3.Text = "RECEIVE";
            this.btnReceivestep3.UseVisualStyleBackColor = false;
            // 
            // dataGridSTEP3
            // 
            this.dataGridSTEP3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSTEP3.Location = new System.Drawing.Point(23, 20);
            this.dataGridSTEP3.Name = "dataGridSTEP3";
            this.dataGridSTEP3.RowHeadersWidth = 51;
            this.dataGridSTEP3.RowTemplate.Height = 24;
            this.dataGridSTEP3.Size = new System.Drawing.Size(908, 319);
            this.dataGridSTEP3.TabIndex = 1;
            // 
            // labelStep3
            // 
            this.labelStep3.AutoSize = true;
            this.labelStep3.Location = new System.Drawing.Point(32, 9);
            this.labelStep3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStep3.Name = "labelStep3";
            this.labelStep3.Size = new System.Drawing.Size(44, 16);
            this.labelStep3.TabIndex = 3;
            this.labelStep3.Text = "label1";
            // 
            // STEP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 509);
            this.Controls.Add(this.labelStep3);
            this.Controls.Add(this.panelSTEP3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STEP3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEP3";
            this.panelSTEP3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSTEP3;
        private System.Windows.Forms.Button btnReceivestep3;
        private System.Windows.Forms.DataGridView dataGridSTEP3;
        private System.Windows.Forms.Label labelStep3;
    }
}