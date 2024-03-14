namespace ex
{
    partial class STEP4
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
            this.panelSTEP4 = new System.Windows.Forms.Panel();
            this.btnReceiveStep4 = new System.Windows.Forms.Button();
            this.btnApproveStep4 = new System.Windows.Forms.Button();
            this.dataGridSTEP4 = new System.Windows.Forms.DataGridView();
            this.labelStep4 = new System.Windows.Forms.Label();
            this.panelSTEP4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSTEP4
            // 
            this.panelSTEP4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSTEP4.Controls.Add(this.btnReceiveStep4);
            this.panelSTEP4.Controls.Add(this.btnApproveStep4);
            this.panelSTEP4.Controls.Add(this.dataGridSTEP4);
            this.panelSTEP4.Location = new System.Drawing.Point(12, 38);
            this.panelSTEP4.Name = "panelSTEP4";
            this.panelSTEP4.Size = new System.Drawing.Size(950, 432);
            this.panelSTEP4.TabIndex = 2;
            // 
            // btnReceiveStep4
            // 
            this.btnReceiveStep4.BackColor = System.Drawing.Color.Red;
            this.btnReceiveStep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveStep4.ForeColor = System.Drawing.Color.White;
            this.btnReceiveStep4.Location = new System.Drawing.Point(690, 364);
            this.btnReceiveStep4.Name = "btnReceiveStep4";
            this.btnReceiveStep4.Size = new System.Drawing.Size(197, 43);
            this.btnReceiveStep4.TabIndex = 3;
            this.btnReceiveStep4.Text = "REJECT";
            this.btnReceiveStep4.UseVisualStyleBackColor = false;
            // 
            // btnApproveStep4
            // 
            this.btnApproveStep4.BackColor = System.Drawing.Color.ForestGreen;
            this.btnApproveStep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveStep4.ForeColor = System.Drawing.Color.White;
            this.btnApproveStep4.Location = new System.Drawing.Point(70, 364);
            this.btnApproveStep4.Name = "btnApproveStep4";
            this.btnApproveStep4.Size = new System.Drawing.Size(197, 43);
            this.btnApproveStep4.TabIndex = 2;
            this.btnApproveStep4.Text = "APPROVE";
            this.btnApproveStep4.UseVisualStyleBackColor = false;
            // 
            // dataGridSTEP4
            // 
            this.dataGridSTEP4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSTEP4.Location = new System.Drawing.Point(23, 20);
            this.dataGridSTEP4.Name = "dataGridSTEP4";
            this.dataGridSTEP4.RowHeadersWidth = 51;
            this.dataGridSTEP4.RowTemplate.Height = 24;
            this.dataGridSTEP4.Size = new System.Drawing.Size(908, 319);
            this.dataGridSTEP4.TabIndex = 1;
            // 
            // labelStep4
            // 
            this.labelStep4.AutoSize = true;
            this.labelStep4.Location = new System.Drawing.Point(32, 9);
            this.labelStep4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStep4.Name = "labelStep4";
            this.labelStep4.Size = new System.Drawing.Size(44, 16);
            this.labelStep4.TabIndex = 3;
            this.labelStep4.Text = "label1";
            // 
            // STEP4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 509);
            this.Controls.Add(this.labelStep4);
            this.Controls.Add(this.panelSTEP4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STEP4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEP4";
            this.panelSTEP4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSTEP4;
        private System.Windows.Forms.Button btnApproveStep4;
        private System.Windows.Forms.DataGridView dataGridSTEP4;
        private System.Windows.Forms.Button btnReceiveStep4;
        private System.Windows.Forms.Label labelStep4;
    }
}