namespace OGSMS
{
    partial class PDashBoard
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.RefreshB = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.NewB = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DashBoardLabel = new System.Windows.Forms.Label();
            this.DashBoardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CatagoryTB = new System.Windows.Forms.TextBox();
            this.PIDTB = new System.Windows.Forms.TextBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NamwLabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DashBoardPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGV);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(353, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 567);
            this.panel3.TabIndex = 3;
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
            this.Column5,
            this.Column6});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(901, 567);
            this.DGV.TabIndex = 5;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(901, 567);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.RefreshB);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.NewB);
            this.panel2.Controls.Add(this.SaveB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(353, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 86);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(719, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "Earning";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RefreshB
            // 
            this.RefreshB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshB.Location = new System.Drawing.Point(277, 16);
            this.RefreshB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshB.Name = "RefreshB";
            this.RefreshB.Size = new System.Drawing.Size(156, 54);
            this.RefreshB.TabIndex = 8;
            this.RefreshB.Text = "🔄 Refresh";
            this.RefreshB.UseVisualStyleBackColor = true;
            this.RefreshB.Click += new System.EventHandler(this.RefreshB_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(136, 16);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(135, 54);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "🗑️ Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // NewB
            // 
            this.NewB.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewB.Location = new System.Drawing.Point(3, 16);
            this.NewB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewB.Name = "NewB";
            this.NewB.Size = new System.Drawing.Size(127, 54);
            this.NewB.TabIndex = 6;
            this.NewB.Text = "➕ New";
            this.NewB.UseVisualStyleBackColor = true;
            this.NewB.Click += new System.EventHandler(this.NewB_Click);
            // 
            // SaveB
            // 
            this.SaveB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveB.Location = new System.Drawing.Point(449, 18);
            this.SaveB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(165, 52);
            this.SaveB.TabIndex = 0;
            this.SaveB.Text = "💾 Save";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.ManageB_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DashBoardLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 86);
            this.panel1.TabIndex = 0;
            // 
            // DashBoardLabel
            // 
            this.DashBoardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardLabel.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardLabel.Location = new System.Drawing.Point(0, 0);
            this.DashBoardLabel.Name = "DashBoardLabel";
            this.DashBoardLabel.Size = new System.Drawing.Size(340, 84);
            this.DashBoardLabel.TabIndex = 0;
            this.DashBoardLabel.Text = "DashBoard";
            this.DashBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashBoardPanel
            // 
            this.DashBoardPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DashBoardPanel.ColumnCount = 2;
            this.DashBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.76452F));
            this.DashBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.23548F));
            this.DashBoardPanel.Controls.Add(this.panel4, 0, 1);
            this.DashBoardPanel.Controls.Add(this.panel1, 0, 0);
            this.DashBoardPanel.Controls.Add(this.panel2, 1, 0);
            this.DashBoardPanel.Controls.Add(this.panel3, 1, 1);
            this.DashBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashBoardPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashBoardPanel.Name = "DashBoardPanel";
            this.DashBoardPanel.RowCount = 2;
            this.DashBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.70482F));
            this.DashBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.29518F));
            this.DashBoardPanel.Size = new System.Drawing.Size(1258, 664);
            this.DashBoardPanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.CatagoryTB);
            this.panel4.Controls.Add(this.PIDTB);
            this.panel4.Controls.Add(this.IdTB);
            this.panel4.Controls.Add(this.PriceTB);
            this.panel4.Controls.Add(this.NameTB);
            this.panel4.Controls.Add(this.IdLabel);
            this.panel4.Controls.Add(this.TypeLabel);
            this.panel4.Controls.Add(this.EmailLabel);
            this.panel4.Controls.Add(this.NamwLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 94);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 567);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Category :";
            // 
            // CatagoryTB
            // 
            this.CatagoryTB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatagoryTB.Location = new System.Drawing.Point(3, 346);
            this.CatagoryTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CatagoryTB.Name = "CatagoryTB";
            this.CatagoryTB.Size = new System.Drawing.Size(335, 44);
            this.CatagoryTB.TabIndex = 11;
            // 
            // PIDTB
            // 
            this.PIDTB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDTB.Location = new System.Drawing.Point(3, 478);
            this.PIDTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PIDTB.Name = "PIDTB";
            this.PIDTB.ReadOnly = true;
            this.PIDTB.Size = new System.Drawing.Size(335, 44);
            this.PIDTB.TabIndex = 10;
            // 
            // IdTB
            // 
            this.IdTB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(61, 23);
            this.IdTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTB.Name = "IdTB";
            this.IdTB.ReadOnly = true;
            this.IdTB.Size = new System.Drawing.Size(277, 40);
            this.IdTB.TabIndex = 9;
            this.IdTB.TextChanged += new System.EventHandler(this.IdTB_TextChanged);
            // 
            // PriceTB
            // 
            this.PriceTB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTB.Location = new System.Drawing.Point(3, 246);
            this.PriceTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(335, 44);
            this.PriceTB.TabIndex = 6;
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(3, 128);
            this.NameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(335, 44);
            this.NameTB.TabIndex = 5;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(3, 18);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(0, 36);
            this.IdLabel.TabIndex = 4;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(3, 419);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(229, 41);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Publisher(ID) :";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(3, 188);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(98, 36);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Price :";
            // 
            // NamwLabel
            // 
            this.NamwLabel.AutoSize = true;
            this.NamwLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamwLabel.Location = new System.Drawing.Point(3, 72);
            this.NamwLabel.Name = "NamwLabel";
            this.NamwLabel.Size = new System.Drawing.Size(89, 36);
            this.NamwLabel.TabIndex = 1;
            this.NamwLabel.Text = "Name";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Ref";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "NAME";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "PRICE";
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "CATAGORY";
            this.Column4.HeaderText = "CATEGORY";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "PUBLISHER";
            this.Column5.HeaderText = "Publisher ID";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "PD";
            this.Column6.HeaderText = "Published Date";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // PDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.DashBoardPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PDashBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publisher";
            this.Load += new System.EventHandler(this.PDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.DashBoardPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RefreshB;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button NewB;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DashBoardLabel;
        private System.Windows.Forms.TableLayoutPanel DashBoardPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CatagoryTB;
        private System.Windows.Forms.TextBox PIDTB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NamwLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}