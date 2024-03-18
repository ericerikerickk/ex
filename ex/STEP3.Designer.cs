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
            this.labelStep3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.txtProjectNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.dataGridSTEP3 = new System.Windows.Forms.DataGridView();
            this.panelSTEP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSTEP2
            // 
            this.panelSTEP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSTEP2.Controls.Add(this.labelStep3);
            this.panelSTEP2.Controls.Add(this.txtSearch);
            this.panelSTEP2.Controls.Add(this.lblHello);
            this.panelSTEP2.Controls.Add(this.txtProjectNo);
            this.panelSTEP2.Controls.Add(this.label1);
            this.panelSTEP2.Controls.Add(this.btnReceive);
            this.panelSTEP2.Controls.Add(this.txtProjectDescription);
            this.panelSTEP2.Controls.Add(this.txtProjectName);
            this.panelSTEP2.Controls.Add(this.label2);
            this.panelSTEP2.Controls.Add(this.lblProject);
            this.panelSTEP2.Controls.Add(this.dataGridSTEP3);
            this.panelSTEP2.Location = new System.Drawing.Point(9, 10);
            this.panelSTEP2.Margin = new System.Windows.Forms.Padding(2);
            this.panelSTEP2.Name = "panelSTEP2";
            this.panelSTEP2.Size = new System.Drawing.Size(712, 394);
            this.panelSTEP2.TabIndex = 3;
            // 
            // labelStep3
            // 
            this.labelStep3.AutoSize = true;
            this.labelStep3.Location = new System.Drawing.Point(10, 8);
            this.labelStep3.Name = "labelStep3";
            this.labelStep3.Size = new System.Drawing.Size(35, 13);
            this.labelStep3.TabIndex = 25;
            this.labelStep3.Text = "label1";
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
            this.txtProjectNo.TabIndex = 1;
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
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReceive.FlatAppearance.BorderSize = 0;
            this.btnReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReceive.Location = new System.Drawing.Point(542, 55);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(2);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(111, 35);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.Text = "RECEIVE";
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(202, 55);
            this.txtProjectDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(330, 79);
            this.txtProjectDescription.TabIndex = 3;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(495, 6);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectName.Multiline = true;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(145, 28);
            this.txtProjectName.TabIndex = 2;
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
            // dataGridSTEP3
            // 
            this.dataGridSTEP3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSTEP3.Location = new System.Drawing.Point(44, 171);
            this.dataGridSTEP3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridSTEP3.Name = "dataGridSTEP3";
            this.dataGridSTEP3.ReadOnly = true;
            this.dataGridSTEP3.RowHeadersWidth = 51;
            this.dataGridSTEP3.RowTemplate.Height = 24;
            this.dataGridSTEP3.Size = new System.Drawing.Size(625, 204);
            this.dataGridSTEP3.TabIndex = 1;
            this.dataGridSTEP3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSTEP3_CellClick);
            // 
            // STEP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 414);
            this.Controls.Add(this.panelSTEP2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "STEP3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEP3";
            this.panelSTEP2.ResumeLayout(false);
            this.panelSTEP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSTEP3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSTEP2;
        private System.Windows.Forms.Label labelStep3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox txtProjectNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.DataGridView dataGridSTEP3;
    }
}