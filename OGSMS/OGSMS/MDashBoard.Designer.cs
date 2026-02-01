namespace OGSMS
{
    partial class MDashBoard
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
            this.DashBoardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DashBoardLabel = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.GamesB = new System.Windows.Forms.Button();
            this.CustomerB = new System.Windows.Forms.Button();
            this.PublisherB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ManageB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DashBoardPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DashBoardPanel
            // 
            this.DashBoardPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DashBoardPanel.ColumnCount = 2;
            this.DashBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.66773F));
            this.DashBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.33228F));
            this.DashBoardPanel.Controls.Add(this.panel1, 0, 0);
            this.DashBoardPanel.Controls.Add(this.ButtonPanel, 0, 1);
            this.DashBoardPanel.Controls.Add(this.panel2, 1, 0);
            this.DashBoardPanel.Controls.Add(this.panel3, 1, 1);
            this.DashBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashBoardPanel.Name = "DashBoardPanel";
            this.DashBoardPanel.RowCount = 2;
            this.DashBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.70482F));
            this.DashBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.29518F));
            this.DashBoardPanel.Size = new System.Drawing.Size(1258, 664);
            this.DashBoardPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DashBoardLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 84);
            this.panel1.TabIndex = 0;
            // 
            // DashBoardLabel
            // 
            this.DashBoardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardLabel.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardLabel.Location = new System.Drawing.Point(0, 0);
            this.DashBoardLabel.Name = "DashBoardLabel";
            this.DashBoardLabel.Size = new System.Drawing.Size(251, 82);
            this.DashBoardLabel.TabIndex = 0;
            this.DashBoardLabel.Text = "DashBoard";
            this.DashBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.GamesB);
            this.ButtonPanel.Controls.Add(this.CustomerB);
            this.ButtonPanel.Controls.Add(this.PublisherB);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(4, 95);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(253, 565);
            this.ButtonPanel.TabIndex = 1;
            // 
            // GamesB
            // 
            this.GamesB.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesB.Location = new System.Drawing.Point(27, 230);
            this.GamesB.Name = "GamesB";
            this.GamesB.Size = new System.Drawing.Size(189, 64);
            this.GamesB.TabIndex = 3;
            this.GamesB.Text = "Games";
            this.GamesB.UseVisualStyleBackColor = true;
            this.GamesB.Click += new System.EventHandler(this.GamesB_Click);
            // 
            // CustomerB
            // 
            this.CustomerB.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerB.Location = new System.Drawing.Point(27, 130);
            this.CustomerB.Name = "CustomerB";
            this.CustomerB.Size = new System.Drawing.Size(189, 64);
            this.CustomerB.TabIndex = 2;
            this.CustomerB.Text = "User";
            this.CustomerB.UseVisualStyleBackColor = true;
            this.CustomerB.Click += new System.EventHandler(this.CustomerB_Click);
            // 
            // PublisherB
            // 
            this.PublisherB.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublisherB.Location = new System.Drawing.Point(27, 32);
            this.PublisherB.Name = "PublisherB";
            this.PublisherB.Size = new System.Drawing.Size(189, 64);
            this.PublisherB.TabIndex = 1;
            this.PublisherB.Text = "Publisher";
            this.PublisherB.UseVisualStyleBackColor = true;
            this.PublisherB.Click += new System.EventHandler(this.PublisherB_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ManageB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(264, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 84);
            this.panel2.TabIndex = 2;
            // 
            // ManageB
            // 
            this.ManageB.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageB.Location = new System.Drawing.Point(753, 9);
            this.ManageB.Name = "ManageB";
            this.ManageB.Size = new System.Drawing.Size(220, 61);
            this.ManageB.TabIndex = 0;
            this.ManageB.Text = "Manage ⚙️";
            this.ManageB.UseVisualStyleBackColor = true;
            this.ManageB.Click += new System.EventHandler(this.ManageB_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGV);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(264, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 565);
            this.panel3.TabIndex = 3;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(990, 565);
            this.DGV.TabIndex = 5;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NAME";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "EMAIL";
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "PASS";
            this.Column4.HeaderText = "Password";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "TYPE";
            this.Column5.HeaderText = "Type";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(990, 565);
            this.dataGridView1.TabIndex = 0;
            // 
            // MDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.DashBoardPanel);
            this.Name = "MDashBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.MDashBoard_Load);
            this.DashBoardPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DashBoardPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DashBoardLabel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button GamesB;
        private System.Windows.Forms.Button CustomerB;
        private System.Windows.Forms.Button PublisherB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ManageB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}