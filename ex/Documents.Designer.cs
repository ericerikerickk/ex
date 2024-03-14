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
            this.lblHello = new System.Windows.Forms.Label();
            this.txtProjectNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitdocs = new System.Windows.Forms.Button();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.dataGridViewDocs = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDocuments
            // 
            this.panelDocuments.Controls.Add(this.txtSearch);
            this.panelDocuments.Controls.Add(this.btnDelete);
            this.panelDocuments.Controls.Add(this.lblHello);
            this.panelDocuments.Controls.Add(this.txtProjectNo);
            this.panelDocuments.Controls.Add(this.label1);
            this.panelDocuments.Controls.Add(this.btnSubmitdocs);
            this.panelDocuments.Controls.Add(this.txtProjectDescription);
            this.panelDocuments.Controls.Add(this.txtProjectName);
            this.panelDocuments.Controls.Add(this.label2);
            this.panelDocuments.Controls.Add(this.lblProject);
            this.panelDocuments.Controls.Add(this.dataGridViewDocs);
            this.panelDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDocuments.Location = new System.Drawing.Point(0, 0);
            this.panelDocuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDocuments.Name = "panelDocuments";
            this.panelDocuments.Size = new System.Drawing.Size(973, 510);
            this.panelDocuments.TabIndex = 0;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(12, 175);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(111, 13);
            this.lblHello.TabIndex = 13;
            this.lblHello.Text = "Search by Project No.";
            // 
            // txtProjectNo
            // 
            this.txtProjectNo.Location = new System.Drawing.Point(232, 22);
            this.txtProjectNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectNo.Multiline = true;
            this.txtProjectNo.Name = "txtProjectNo";
            this.txtProjectNo.Size = new System.Drawing.Size(192, 34);
            this.txtProjectNo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "PROJECT NAME";
            // 
            // btnSubmitdocs
            // 
            this.btnSubmitdocs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSubmitdocs.FlatAppearance.BorderSize = 0;
            this.btnSubmitdocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitdocs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitdocs.Location = new System.Drawing.Point(530, 68);
            this.btnSubmitdocs.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitdocs.Name = "btnSubmitdocs";
            this.btnSubmitdocs.Size = new System.Drawing.Size(197, 43);
            this.btnSubmitdocs.TabIndex = 10;
            this.btnSubmitdocs.Text = "SUBMIT";
            this.btnSubmitdocs.UseVisualStyleBackColor = false;
            this.btnSubmitdocs.Click += new System.EventHandler(this.btnSubmitdocs_Click);
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(235, 82);
            this.txtProjectDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(439, 96);
            this.txtProjectDescription.TabIndex = 5;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(625, 22);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectName.Multiline = true;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(192, 34);
            this.txtProjectName.TabIndex = 4;
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
            this.lblProject.Location = new System.Drawing.Point(51, 28);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(165, 20);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "PROJECT NUMBER";
            // 
            // dataGridViewDocs
            // 
            this.dataGridViewDocs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocs.Location = new System.Drawing.Point(87, 247);
            this.dataGridViewDocs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDocs.Name = "dataGridViewDocs";
            this.dataGridViewDocs.ReadOnly = true;
            this.dataGridViewDocs.RowHeadersWidth = 51;
            this.dataGridViewDocs.RowTemplate.Height = 24;
            this.dataGridViewDocs.Size = new System.Drawing.Size(799, 222);
            this.dataGridViewDocs.TabIndex = 1;
            this.dataGridViewDocs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDocs_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(530, 111);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(128, 169);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 28);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 510);
            this.Controls.Add(this.panelDocuments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Button btnSubmitdocs;
        private System.Windows.Forms.TextBox txtProjectNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
    }
}