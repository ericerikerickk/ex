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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.txtProjectNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitdocs = new System.Windows.Forms.Button();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.dataGridSTEP1 = new System.Windows.Forms.DataGridView();
            this.labelStep1 = new System.Windows.Forms.Label();
            this.panelSTEP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSTEP1
            // 
            this.panelSTEP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSTEP1.Controls.Add(this.txtSearch);
            this.panelSTEP1.Controls.Add(this.lblHello);
            this.panelSTEP1.Controls.Add(this.txtProjectNo);
            this.panelSTEP1.Controls.Add(this.label1);
            this.panelSTEP1.Controls.Add(this.btnSubmitdocs);
            this.panelSTEP1.Controls.Add(this.txtProjectDescription);
            this.panelSTEP1.Controls.Add(this.txtProjectName);
            this.panelSTEP1.Controls.Add(this.label2);
            this.panelSTEP1.Controls.Add(this.lblProject);
            this.panelSTEP1.Controls.Add(this.dataGridSTEP1);
            this.panelSTEP1.Location = new System.Drawing.Point(7, 9);
            this.panelSTEP1.Margin = new System.Windows.Forms.Padding(2);
            this.panelSTEP1.Name = "panelSTEP1";
            this.panelSTEP1.Size = new System.Drawing.Size(712, 394);
            this.panelSTEP1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(159, 143);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(110, 24);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(44, 150);
            this.lblHello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(111, 13);
            this.lblHello.TabIndex = 23;
            this.lblHello.Text = "Search by Project No.";
            // 
            // txtProjectNo
            // 
            this.txtProjectNo.Location = new System.Drawing.Point(200, 6);
            this.txtProjectNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectNo.Multiline = true;
            this.txtProjectNo.Name = "txtProjectNo";
            this.txtProjectNo.Size = new System.Drawing.Size(145, 28);
            this.txtProjectNo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "PROJECT NAME";
            // 
            // btnSubmitdocs
            // 
            this.btnSubmitdocs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSubmitdocs.FlatAppearance.BorderSize = 0;
            this.btnSubmitdocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitdocs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitdocs.Location = new System.Drawing.Point(542, 55);
            this.btnSubmitdocs.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitdocs.Name = "btnSubmitdocs";
            this.btnSubmitdocs.Size = new System.Drawing.Size(111, 35);
            this.btnSubmitdocs.TabIndex = 20;
            this.btnSubmitdocs.Text = "RECEIVE";
            this.btnSubmitdocs.UseVisualStyleBackColor = false;
            this.btnSubmitdocs.Click += new System.EventHandler(this.btnSubmitdocs_Click);
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(202, 55);
            this.txtProjectDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(330, 79);
            this.txtProjectDescription.TabIndex = 19;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(495, 6);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectName.Multiline = true;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(145, 28);
            this.txtProjectName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "PROJECT DESCRIPTION";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(64, 11);
            this.lblProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(132, 16);
            this.lblProject.TabIndex = 16;
            this.lblProject.Text = "PROJECT NUMBER";
            // 
            // dataGridSTEP1
            // 
            this.dataGridSTEP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSTEP1.Location = new System.Drawing.Point(44, 171);
            this.dataGridSTEP1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridSTEP1.Name = "dataGridSTEP1";
            this.dataGridSTEP1.ReadOnly = true;
            this.dataGridSTEP1.RowHeadersWidth = 51;
            this.dataGridSTEP1.RowTemplate.Height = 24;
            this.dataGridSTEP1.Size = new System.Drawing.Size(625, 204);
            this.dataGridSTEP1.TabIndex = 1;
            this.dataGridSTEP1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSTEP1_CellClick);
            // 
            // labelStep1
            // 
            this.labelStep1.AutoSize = true;
            this.labelStep1.Location = new System.Drawing.Point(23, 9);
            this.labelStep1.Name = "labelStep1";
            this.labelStep1.Size = new System.Drawing.Size(35, 13);
            this.labelStep1.TabIndex = 2;
            this.labelStep1.Text = "label1";
            // 
            // STEP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 414);
            this.Controls.Add(this.labelStep1);
            this.Controls.Add(this.panelSTEP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "STEP1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEP1";
            this.panelSTEP1.ResumeLayout(false);
            this.panelSTEP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSTEP1;
        private System.Windows.Forms.DataGridView dataGridSTEP1;
        private System.Windows.Forms.Label labelStep1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox txtProjectNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitdocs;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProject;
    }
}