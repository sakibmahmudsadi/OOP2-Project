namespace OGSMS
{
    partial class PublisherEdit
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshB = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.NewB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TypeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Catagory = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PeiceLabel = new System.Windows.Forms.Label();
            this.NamwLabel = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.72395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.27605F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DGV, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.85542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.14458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 664);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RefreshB);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.NewB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 84);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RefreshB
            // 
            this.RefreshB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshB.Location = new System.Drawing.Point(354, 15);
            this.RefreshB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshB.Name = "RefreshB";
            this.RefreshB.Size = new System.Drawing.Size(158, 54);
            this.RefreshB.TabIndex = 2;
            this.RefreshB.Text = "🔄 Refresh";
            this.RefreshB.UseVisualStyleBackColor = true;
            this.RefreshB.Click += new System.EventHandler(this.RefreshB_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(177, 15);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(148, 54);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "🗑️ Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // NewB
            // 
            this.NewB.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewB.Location = new System.Drawing.Point(22, 15);
            this.NewB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewB.Name = "NewB";
            this.NewB.Size = new System.Drawing.Size(126, 54);
            this.NewB.TabIndex = 0;
            this.NewB.Text = "➕ New";
            this.NewB.UseVisualStyleBackColor = true;
            this.NewB.Click += new System.EventHandler(this.NewB_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.SaveB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(892, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 84);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(190, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "🔙";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // SaveB
            // 
            this.SaveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveB.Location = new System.Drawing.Point(19, 15);
            this.SaveB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(134, 54);
            this.SaveB.TabIndex = 3;
            this.SaveB.Text = "💾 Save";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TypeTB);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Catagory);
            this.panel3.Controls.Add(this.PassTB);
            this.panel3.Controls.Add(this.IdTB);
            this.panel3.Controls.Add(this.EmailTB);
            this.panel3.Controls.Add(this.NameTB);
            this.panel3.Controls.Add(this.IdLabel);
            this.panel3.Controls.Add(this.PeiceLabel);
            this.panel3.Controls.Add(this.NamwLabel);
            this.panel3.Controls.Add(this.Id);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(892, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 547);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // TypeTB
            // 
            this.TypeTB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeTB.Location = new System.Drawing.Point(19, 482);
            this.TypeTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeTB.Name = "TypeTB";
            this.TypeTB.ReadOnly = true;
            this.TypeTB.Size = new System.Drawing.Size(335, 44);
            this.TypeTB.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Type :";
            // 
            // Catagory
            // 
            this.Catagory.AutoSize = true;
            this.Catagory.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catagory.Location = new System.Drawing.Point(14, 308);
            this.Catagory.Name = "Catagory";
            this.Catagory.Size = new System.Drawing.Size(152, 36);
            this.Catagory.TabIndex = 12;
            this.Catagory.Text = "Password :";
            this.Catagory.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassTB
            // 
            this.PassTB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTB.Location = new System.Drawing.Point(19, 364);
            this.PassTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(335, 44);
            this.PassTB.TabIndex = 11;
            this.PassTB.TextChanged += new System.EventHandler(this.PassTB_TextChanged);
            // 
            // IdTB
            // 
            this.IdTB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(76, 10);
            this.IdTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTB.Name = "IdTB";
            this.IdTB.ReadOnly = true;
            this.IdTB.Size = new System.Drawing.Size(277, 40);
            this.IdTB.TabIndex = 9;
            this.IdTB.Text = "Auto Generated";
            this.IdTB.TextChanged += new System.EventHandler(this.IdTB_TextChanged);
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.Location = new System.Drawing.Point(19, 242);
            this.EmailTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(335, 44);
            this.EmailTB.TabIndex = 6;
            this.EmailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(19, 128);
            this.NameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(335, 44);
            this.NameTB.TabIndex = 5;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(118, 18);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(0, 36);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // PeiceLabel
            // 
            this.PeiceLabel.AutoSize = true;
            this.PeiceLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeiceLabel.Location = new System.Drawing.Point(17, 188);
            this.PeiceLabel.Name = "PeiceLabel";
            this.PeiceLabel.Size = new System.Drawing.Size(107, 36);
            this.PeiceLabel.TabIndex = 2;
            this.PeiceLabel.Text = "Email :";
            this.PeiceLabel.Click += new System.EventHandler(this.PeiceLabel_Click);
            // 
            // NamwLabel
            // 
            this.NamwLabel.AutoSize = true;
            this.NamwLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamwLabel.Location = new System.Drawing.Point(14, 72);
            this.NamwLabel.Name = "NamwLabel";
            this.NamwLabel.Size = new System.Drawing.Size(106, 36);
            this.NamwLabel.TabIndex = 1;
            this.NamwLabel.Text = "Name :";
            this.NamwLabel.Click += new System.EventHandler(this.NamwLabel_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(14, 14);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(58, 36);
            this.Id.TabIndex = 0;
            this.Id.Text = "ID:";
            this.Id.Click += new System.EventHandler(this.Id_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 644);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(4, 92);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(881, 547);
            this.DGV.TabIndex = 4;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
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
            this.Column3.DataPropertyName = "EMAIL";
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TYPE";
            this.Column5.HeaderText = "Type";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "PASS";
            this.Column4.HeaderText = "Password";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // PublisherEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PublisherEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publisher";
            this.Load += new System.EventHandler(this.PublisherEdit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RefreshB;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button NewB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Catagory;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label PeiceLabel;
        private System.Windows.Forms.Label NamwLabel;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TypeTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}