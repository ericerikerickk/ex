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
            this.btnReceivestep1 = new System.Windows.Forms.Button();
            this.dataGridSTEP1 = new System.Windows.Forms.DataGridView();
            this.labelStep1 = new System.Windows.Forms.Label();
            this.panelSTEP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSTEP1
            // 
            this.panelSTEP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSTEP1.Controls.Add(this.btnReceivestep1);
            this.panelSTEP1.Controls.Add(this.dataGridSTEP1);
            this.panelSTEP1.Location = new System.Drawing.Point(12, 42);
            this.panelSTEP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSTEP1.Name = "panelSTEP1";
            this.panelSTEP1.Size = new System.Drawing.Size(949, 432);
            this.panelSTEP1.TabIndex = 1;
            // 
            // btnReceivestep1
            // 
            this.btnReceivestep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReceivestep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceivestep1.ForeColor = System.Drawing.Color.White;
            this.btnReceivestep1.Location = new System.Drawing.Point(371, 364);
            this.btnReceivestep1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReceivestep1.Name = "btnReceivestep1";
            this.btnReceivestep1.Size = new System.Drawing.Size(197, 43);
            this.btnReceivestep1.TabIndex = 2;
            this.btnReceivestep1.Text = "RECEIVE";
            this.btnReceivestep1.UseVisualStyleBackColor = false;
            this.btnReceivestep1.Click += new System.EventHandler(this.btnReceivestep1_Click);
            // 
            // dataGridSTEP1
            // 
            this.dataGridSTEP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSTEP1.Location = new System.Drawing.Point(23, 20);
            this.dataGridSTEP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridSTEP1.Name = "dataGridSTEP1";
            this.dataGridSTEP1.RowHeadersWidth = 51;
            this.dataGridSTEP1.RowTemplate.Height = 24;
            this.dataGridSTEP1.Size = new System.Drawing.Size(908, 319);
            this.dataGridSTEP1.TabIndex = 1;
            // 
            // labelStep1
            // 
            this.labelStep1.AutoSize = true;
            this.labelStep1.Location = new System.Drawing.Point(31, 11);
            this.labelStep1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStep1.Name = "labelStep1";
            this.labelStep1.Size = new System.Drawing.Size(44, 16);
            this.labelStep1.TabIndex = 2;
            this.labelStep1.Text = "label1";
            // 
            // STEP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 510);
            this.Controls.Add(this.labelStep1);
            this.Controls.Add(this.panelSTEP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "STEP1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEP1";
            this.panelSTEP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSTEP1;
        private System.Windows.Forms.DataGridView dataGridSTEP1;
        private System.Windows.Forms.Button btnReceivestep1;
        private System.Windows.Forms.Label labelStep1;
    }
}