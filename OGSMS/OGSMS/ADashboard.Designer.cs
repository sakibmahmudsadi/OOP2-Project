namespace OGSMS
{
    partial class ADashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADashboard));
            this.DashBoardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DashBoardLabel = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.GamesB = new System.Windows.Forms.Button();
            this.UserB = new System.Windows.Forms.Button();
            this.PublisherB = new System.Windows.Forms.Button();
            this.ManagerB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ManageB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DashBoardPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
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
            this.DashBoardPanel.TabIndex = 0;
            this.DashBoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DashBoardPanel_Paint);
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
            this.DashBoardLabel.Click += new System.EventHandler(this.DashBoardLabel_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.GamesB);
            this.ButtonPanel.Controls.Add(this.UserB);
            this.ButtonPanel.Controls.Add(this.PublisherB);
            this.ButtonPanel.Controls.Add(this.ManagerB);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(4, 95);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(253, 565);
            this.ButtonPanel.TabIndex = 1;
            // 
            // GamesB
            // 
            this.GamesB.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesB.Location = new System.Drawing.Point(31, 347);
            this.GamesB.Name = "GamesB";
            this.GamesB.Size = new System.Drawing.Size(189, 64);
            this.GamesB.TabIndex = 3;
            this.GamesB.Text = "Games";
            this.GamesB.UseVisualStyleBackColor = true;
            this.GamesB.Click += new System.EventHandler(this.GamesB_Click);
            // 
            // UserB
            // 
            this.UserB.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserB.Location = new System.Drawing.Point(31, 247);
            this.UserB.Name = "UserB";
            this.UserB.Size = new System.Drawing.Size(189, 64);
            this.UserB.TabIndex = 2;
            this.UserB.Text = "User";
            this.UserB.UseVisualStyleBackColor = true;
            this.UserB.Click += new System.EventHandler(this.CustomerB_Click);
            // 
            // PublisherB
            // 
            this.PublisherB.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublisherB.Location = new System.Drawing.Point(31, 149);
            this.PublisherB.Name = "PublisherB";
            this.PublisherB.Size = new System.Drawing.Size(189, 64);
            this.PublisherB.TabIndex = 1;
            this.PublisherB.Text = "Publisher";
            this.PublisherB.UseVisualStyleBackColor = true;
            this.PublisherB.Click += new System.EventHandler(this.PublisherB_Click);
            // 
            // ManagerB
            // 
            this.ManagerB.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerB.Location = new System.Drawing.Point(31, 57);
            this.ManagerB.Name = "ManagerB";
            this.ManagerB.Size = new System.Drawing.Size(189, 64);
            this.ManagerB.TabIndex = 0;
            this.ManagerB.Text = "Manager";
            this.ManagerB.UseVisualStyleBackColor = true;
            this.ManagerB.Click += new System.EventHandler(this.ManagerB_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
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
            this.ManageB.Text = "Manage";
            this.ManageB.UseVisualStyleBackColor = true;
            this.ManageB.Click += new System.EventHandler(this.ManageB_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGV2);
            this.panel3.Controls.Add(this.DGV);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(264, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 565);
            this.panel3.TabIndex = 3;
            // 
            // DGV2
            // 
            this.DGV2.AllowUserToAddRows = false;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column9,
            this.Column11});
            this.DGV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV2.Location = new System.Drawing.Point(0, 0);
            this.DGV2.Name = "DGV2";
            this.DGV2.RowHeadersVisible = false;
            this.DGV2.RowHeadersWidth = 62;
            this.DGV2.RowTemplate.Height = 28;
            this.DGV2.Size = new System.Drawing.Size(990, 565);
            this.DGV2.TabIndex = 6;
            this.DGV2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV2_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ID";
            this.Column6.HeaderText = "ID";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Name";
            this.Column7.HeaderText = "Name";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Price";
            this.Column8.HeaderText = "Price";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Catagory";
            this.Column10.HeaderText = "Catagory";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "Publisher";
            this.Column9.HeaderText = "Publisher";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "PD";
            this.Column11.HeaderText = "Publish Date";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
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
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(990, 565);
            this.DGV.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NAME";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "EMAIL";
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "PASS";
            this.Column4.HeaderText = "Password";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "TYPE";
            this.Column5.HeaderText = "Type";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
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
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(16, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(66, 61);
            this.panel4.TabIndex = 2;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // ADashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.DashBoardPanel);
            this.Name = "ADashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.MDashboard_Load);
            this.DashBoardPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
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
        private System.Windows.Forms.Button UserB;
        private System.Windows.Forms.Button PublisherB;
        private System.Windows.Forms.Button ManagerB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ManageB;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView DGV2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Panel panel4;
    }
}

