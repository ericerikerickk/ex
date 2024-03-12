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
            this.btnSubmitdocs = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.dataGridViewDocs = new System.Windows.Forms.DataGridView();
            this.panelDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDocuments
            // 
            this.panelDocuments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDocuments.Controls.Add(this.btnSubmitdocs);
            this.panelDocuments.Controls.Add(this.textBox2);
            this.panelDocuments.Controls.Add(this.textBox1);
            this.panelDocuments.Controls.Add(this.label2);
            this.panelDocuments.Controls.Add(this.lblProject);
            this.panelDocuments.Controls.Add(this.dataGridViewDocs);
            this.panelDocuments.Location = new System.Drawing.Point(12, 12);
            this.panelDocuments.Name = "panelDocuments";
            this.panelDocuments.Size = new System.Drawing.Size(950, 485);
            this.panelDocuments.TabIndex = 0;
            // 
            // btnSubmitdocs
            // 
            this.btnSubmitdocs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSubmitdocs.FlatAppearance.BorderSize = 0;
            this.btnSubmitdocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitdocs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitdocs.Location = new System.Drawing.Point(377, 185);
            this.btnSubmitdocs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitdocs.Name = "btnSubmitdocs";
            this.btnSubmitdocs.Size = new System.Drawing.Size(197, 43);
            this.btnSubmitdocs.TabIndex = 10;
            this.btnSubmitdocs.Text = "SUBMIT";
            this.btnSubmitdocs.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 84);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 96);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 33);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PROJECT DESCRIPTION";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(76, 40);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(140, 20);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "PROJECT NAME";
            // 
            // dataGridViewDocs
            // 
            this.dataGridViewDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocs.Location = new System.Drawing.Point(16, 247);
            this.dataGridViewDocs.Name = "dataGridViewDocs";
            this.dataGridViewDocs.RowHeadersWidth = 51;
            this.dataGridViewDocs.RowTemplate.Height = 24;
            this.dataGridViewDocs.Size = new System.Drawing.Size(919, 221);
            this.dataGridViewDocs.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDocuments;
        private System.Windows.Forms.DataGridView dataGridViewDocs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Button btnSubmitdocs;
    }
}