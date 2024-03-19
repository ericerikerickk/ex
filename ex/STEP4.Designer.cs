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
            this.panelSTEP2 = new System.Windows.Forms.Panel();
            this.btnDeny = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.txtProjectNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.dataGridSTEP4 = new System.Windows.Forms.DataGridView();
            this.panelSTEP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSTEP2
            // 
            this.panelSTEP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSTEP2.Controls.Add(this.btnDeny);
            this.panelSTEP2.Controls.Add(this.txtSearch);
            this.panelSTEP2.Controls.Add(this.lblHello);
            this.panelSTEP2.Controls.Add(this.txtProjectNo);
            this.panelSTEP2.Controls.Add(this.label1);
            this.panelSTEP2.Controls.Add(this.btnApprove);
            this.panelSTEP2.Controls.Add(this.txtProjectDescription);
            this.panelSTEP2.Controls.Add(this.txtProjectName);
            this.panelSTEP2.Controls.Add(this.label2);
            this.panelSTEP2.Controls.Add(this.lblProject);
            this.panelSTEP2.Controls.Add(this.dataGridSTEP4);
            this.panelSTEP2.Location = new System.Drawing.Point(12, 11);
            this.panelSTEP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSTEP2.Name = "panelSTEP2";
            this.panelSTEP2.Size = new System.Drawing.Size(949, 485);
            this.panelSTEP2.TabIndex = 4;
            // 
            // btnDeny
            // 
            this.btnDeny.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeny.BackColor = System.Drawing.Color.Red;
            this.btnDeny.FlatAppearance.BorderSize = 0;
            this.btnDeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeny.Location = new System.Drawing.Point(723, 116);
            this.btnDeny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(148, 43);
            this.btnDeny.TabIndex = 26;
            this.btnDeny.Text = "DECLINE";
            this.btnDeny.UseVisualStyleBackColor = false;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(212, 176);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 29);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblHello
            // 
            this.lblHello.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(59, 185);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(137, 16);
            this.lblHello.TabIndex = 23;
            this.lblHello.Text = "Search by Project No.";
            // 
            // txtProjectNo
            // 
            this.txtProjectNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProjectNo.Location = new System.Drawing.Point(269, 17);
            this.txtProjectNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectNo.Multiline = true;
            this.txtProjectNo.Name = "txtProjectNo";
            this.txtProjectNo.Size = new System.Drawing.Size(192, 34);
            this.txtProjectNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "PROJECT NAME";
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnApprove.Location = new System.Drawing.Point(723, 68);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(148, 43);
            this.btnApprove.TabIndex = 4;
            this.btnApprove.Text = "APPROVE";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProjectDescription.Location = new System.Drawing.Point(269, 68);
            this.txtProjectDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(439, 96);
            this.txtProjectDescription.TabIndex = 3;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProjectName.Location = new System.Drawing.Point(648, 17);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectName.Multiline = true;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(192, 34);
            this.txtProjectName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "PROJECT DESCRIPTION";
            // 
            // lblProject
            // 
            this.lblProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(85, 31);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(165, 20);
            this.lblProject.TabIndex = 16;
            this.lblProject.Text = "PROJECT NUMBER";
            // 
            // dataGridSTEP4
            // 
            this.dataGridSTEP4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridSTEP4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSTEP4.Location = new System.Drawing.Point(59, 210);
            this.dataGridSTEP4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridSTEP4.Name = "dataGridSTEP4";
            this.dataGridSTEP4.ReadOnly = true;
            this.dataGridSTEP4.RowHeadersWidth = 51;
            this.dataGridSTEP4.RowTemplate.Height = 24;
            this.dataGridSTEP4.Size = new System.Drawing.Size(833, 251);
            this.dataGridSTEP4.TabIndex = 1;
            this.dataGridSTEP4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSTEP4_CellClick);
            // 
            // STEP4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 510);
            this.Controls.Add(this.panelSTEP2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "STEP4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEP4";
            this.panelSTEP2.ResumeLayout(false);
            this.panelSTEP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSTEP2;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox txtProjectNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.DataGridView dataGridSTEP4;
    }
}