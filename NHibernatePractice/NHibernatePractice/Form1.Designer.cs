namespace NHibernatePractice
{
	partial class Form1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.labelSTT = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelClass = new System.Windows.Forms.Label();
			this.labelSearch = new System.Windows.Forms.Label();
			this.textBoxSTT = new System.Windows.Forms.TextBox();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxClass = new System.Windows.Forms.TextBox();
			this.buttonRead = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.dataGridViewListSinhVien = new System.Windows.Forms.DataGridView();
			this.columnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnNameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewListSinhVien)).BeginInit();
			this.SuspendLayout();
			// 
			// labelSTT
			// 
			this.labelSTT.AutoSize = true;
			this.labelSTT.Location = new System.Drawing.Point(68, 15);
			this.labelSTT.Name = "labelSTT";
			this.labelSTT.Size = new System.Drawing.Size(49, 12);
			this.labelSTT.TabIndex = 0;
			this.labelSTT.Text = "Số thứ tự";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(76, 40);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(41, 12);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Họ Tên";
			// 
			// labelClass
			// 
			this.labelClass.AutoSize = true;
			this.labelClass.Location = new System.Drawing.Point(95, 65);
			this.labelClass.Name = "labelClass";
			this.labelClass.Size = new System.Drawing.Size(22, 12);
			this.labelClass.TabIndex = 2;
			this.labelClass.Text = "Lớp";
			// 
			// labelSearch
			// 
			this.labelSearch.AutoSize = true;
			this.labelSearch.Location = new System.Drawing.Point(12, 90);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(105, 12);
			this.labelSearch.TabIndex = 3;
			this.labelSearch.Text = "Tìm Kiếm Theo Tên";
			// 
			// textBoxSTT
			// 
			this.textBoxSTT.Location = new System.Drawing.Point(123, 12);
			this.textBoxSTT.Name = "textBoxSTT";
			this.textBoxSTT.Size = new System.Drawing.Size(29, 19);
			this.textBoxSTT.TabIndex = 4;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(123, 87);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(207, 19);
			this.textBoxSearch.TabIndex = 5;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(123, 37);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(207, 19);
			this.textBoxName.TabIndex = 6;
			// 
			// textBoxClass
			// 
			this.textBoxClass.Location = new System.Drawing.Point(123, 62);
			this.textBoxClass.Name = "textBoxClass";
			this.textBoxClass.Size = new System.Drawing.Size(78, 19);
			this.textBoxClass.TabIndex = 7;
			// 
			// buttonRead
			// 
			this.buttonRead.Location = new System.Drawing.Point(12, 112);
			this.buttonRead.Name = "buttonRead";
			this.buttonRead.Size = new System.Drawing.Size(75, 23);
			this.buttonRead.TabIndex = 8;
			this.buttonRead.Text = "Xem";
			this.buttonRead.UseVisualStyleBackColor = true;
			this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(93, 112);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 9;
			this.buttonAdd.Text = "Thêm";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(174, 112);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdate.TabIndex = 10;
			this.buttonUpdate.Text = "Sửa";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonDel
			// 
			this.buttonDel.Location = new System.Drawing.Point(255, 112);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(75, 23);
			this.buttonDel.TabIndex = 11;
			this.buttonDel.Text = "Xóa";
			this.buttonDel.UseVisualStyleBackColor = true;
			this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
			// 
			// dataGridViewListSinhVien
			// 
			this.dataGridViewListSinhVien.AllowUserToAddRows = false;
			this.dataGridViewListSinhVien.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewListSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewListSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewListSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSTT,
            this.columnID,
            this.columnNameEmployee});
			this.dataGridViewListSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridViewListSinhVien.Location = new System.Drawing.Point(0, 141);
			this.dataGridViewListSinhVien.Name = "dataGridViewListSinhVien";
			this.dataGridViewListSinhVien.ReadOnly = true;
			this.dataGridViewListSinhVien.RowTemplate.Height = 21;
			this.dataGridViewListSinhVien.Size = new System.Drawing.Size(342, 238);
			this.dataGridViewListSinhVien.TabIndex = 25;
			// 
			// columnSTT
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			this.columnSTT.DefaultCellStyle = dataGridViewCellStyle2;
			this.columnSTT.Frozen = true;
			this.columnSTT.HeaderText = "STT";
			this.columnSTT.Name = "columnSTT";
			this.columnSTT.ReadOnly = true;
			this.columnSTT.Width = 50;
			// 
			// columnID
			// 
			this.columnID.HeaderText = "Họ Tên";
			this.columnID.Name = "columnID";
			this.columnID.ReadOnly = true;
			this.columnID.Width = 130;
			// 
			// columnNameEmployee
			// 
			this.columnNameEmployee.HeaderText = "Lớp";
			this.columnNameEmployee.Name = "columnNameEmployee";
			this.columnNameEmployee.ReadOnly = true;
			this.columnNameEmployee.Width = 50;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 379);
			this.Controls.Add(this.dataGridViewListSinhVien);
			this.Controls.Add(this.buttonDel);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonRead);
			this.Controls.Add(this.textBoxClass);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.textBoxSTT);
			this.Controls.Add(this.labelSearch);
			this.Controls.Add(this.labelClass);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelSTT);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewListSinhVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSTT;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelClass;
		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.TextBox textBoxSTT;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxClass;
		private System.Windows.Forms.Button buttonRead;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.DataGridView dataGridViewListSinhVien;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnSTT;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnNameEmployee;
	}
}

