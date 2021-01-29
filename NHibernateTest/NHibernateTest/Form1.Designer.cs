namespace NHibernateTest
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
			this.dmTextBoxName = new Jp.Co.Unisys.EFSA.Windows.Controls.DMTextBox();
			this.dmLabelName = new Jp.Co.Unisys.EFSA.Windows.Controls.DMLabel();
			this.dmLabelClass = new Jp.Co.Unisys.EFSA.Windows.Controls.DMLabel();
			this.dmTextBoxClass = new Jp.Co.Unisys.EFSA.Windows.Controls.DMTextBox();
			this.dmSpreadDsSinhVien = new Jp.Co.Unisys.EFSA.Windows.Spread.DMSpread();
			this.dmSpreadDsSinhVien_Sheet1 = new FarPoint.Win.Spread.SheetView();
			this.dmButtonAdd = new Jp.Co.Unisys.EFSA.Windows.Controls.DMButton();
			this.dmButtonUpdate = new Jp.Co.Unisys.EFSA.Windows.Controls.DMButton();
			this.dmButtonDel = new Jp.Co.Unisys.EFSA.Windows.Controls.DMButton();
			this.dmLabelSearch = new Jp.Co.Unisys.EFSA.Windows.Controls.DMLabel();
			this.dmTextBox1 = new Jp.Co.Unisys.EFSA.Windows.Controls.DMTextBox();
			this.dmButtonRead = new Jp.Co.Unisys.EFSA.Windows.Controls.DMButton();
			this.dmTextBox2 = new Jp.Co.Unisys.EFSA.Windows.Controls.DMTextBox();
			this.dmLabelSTT = new Jp.Co.Unisys.EFSA.Windows.Controls.DMLabel();
			((System.ComponentModel.ISupportInitialize)(this.dmSpreadDsSinhVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dmSpreadDsSinhVien_Sheet1)).BeginInit();
			this.SuspendLayout();
			// 
			// dmTextBoxName
			// 
			this.dmTextBoxName.ExBackColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmTextBoxName.ExF4AssemblyName = "";
			this.dmTextBoxName.ExF4ScreenID = "";
			this.dmTextBoxName.ExForeColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmTextBoxName.ExFullLengthSkip = true;
			this.dmTextBoxName.ExInputCharType = Jp.Co.Unisys.EFSA.Windows.Controls.ExInputCharTypes.NORMAL;
			this.dmTextBoxName.ExIsDspMode = false;
			this.dmTextBoxName.ExIsHighlightText = true;
			this.dmTextBoxName.ExIsNotCheckExternalChar = false;
			this.dmTextBoxName.ExIsPaintErrorColor = false;
			this.dmTextBoxName.ExIsPaintUnIndispensableColor = false;
			this.dmTextBoxName.ExMinLength = 0;
			this.dmTextBoxName.ExUserSetBackColor = System.Drawing.SystemColors.Window;
			this.dmTextBoxName.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmTextBoxName.Location = new System.Drawing.Point(136, 87);
			this.dmTextBoxName.MaxLengthType = Jp.Co.Unisys.EFSA.Windows.Controls.ExLengthType.BYTE;
			this.dmTextBoxName.Name = "dmTextBoxName";
			this.dmTextBoxName.Size = new System.Drawing.Size(195, 19);
			this.dmTextBoxName.TabIndex = 0;
			// 
			// dmLabelName
			// 
			this.dmLabelName.AutoSize = true;
			this.dmLabelName.BackColor = System.Drawing.Color.Transparent;
			this.dmLabelName.ExCopyTextName = "";
			this.dmLabelName.ExUserSetBackColor = System.Drawing.Color.White;
			this.dmLabelName.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmLabelName.Location = new System.Drawing.Point(89, 40);
			this.dmLabelName.Name = "dmLabelName";
			this.dmLabelName.Size = new System.Drawing.Size(41, 12);
			this.dmLabelName.TabIndex = 1;
			this.dmLabelName.Text = "Họ Tên";
			// 
			// dmLabelClass
			// 
			this.dmLabelClass.AutoSize = true;
			this.dmLabelClass.BackColor = System.Drawing.Color.Transparent;
			this.dmLabelClass.ExCopyTextName = "";
			this.dmLabelClass.ExUserSetBackColor = System.Drawing.Color.White;
			this.dmLabelClass.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmLabelClass.Location = new System.Drawing.Point(108, 65);
			this.dmLabelClass.Name = "dmLabelClass";
			this.dmLabelClass.Size = new System.Drawing.Size(22, 12);
			this.dmLabelClass.TabIndex = 2;
			this.dmLabelClass.Text = "Lớp";
			// 
			// dmTextBoxClass
			// 
			this.dmTextBoxClass.ExBackColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmTextBoxClass.ExF4AssemblyName = "";
			this.dmTextBoxClass.ExF4ScreenID = "";
			this.dmTextBoxClass.ExForeColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmTextBoxClass.ExFullLengthSkip = true;
			this.dmTextBoxClass.ExInputCharType = Jp.Co.Unisys.EFSA.Windows.Controls.ExInputCharTypes.NORMAL;
			this.dmTextBoxClass.ExIsDspMode = false;
			this.dmTextBoxClass.ExIsHighlightText = true;
			this.dmTextBoxClass.ExIsNotCheckExternalChar = false;
			this.dmTextBoxClass.ExIsPaintErrorColor = false;
			this.dmTextBoxClass.ExIsPaintUnIndispensableColor = false;
			this.dmTextBoxClass.ExMinLength = 0;
			this.dmTextBoxClass.ExUserSetBackColor = System.Drawing.SystemColors.Window;
			this.dmTextBoxClass.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmTextBoxClass.Location = new System.Drawing.Point(136, 62);
			this.dmTextBoxClass.MaxLengthType = Jp.Co.Unisys.EFSA.Windows.Controls.ExLengthType.BYTE;
			this.dmTextBoxClass.Name = "dmTextBoxClass";
			this.dmTextBoxClass.Size = new System.Drawing.Size(84, 19);
			this.dmTextBoxClass.TabIndex = 3;
			// 
			// dmSpreadDsSinhVien
			// 
			this.dmSpreadDsSinhVien.AccessibleDescription = "dmSpreadDsSinhVien, Sheet1, Row 0, Column 0, ";
			this.dmSpreadDsSinhVien.AllowUserZoom = false;
			this.dmSpreadDsSinhVien.BorderCollapse = FarPoint.Win.Spread.BorderCollapse.Collapse;
			this.dmSpreadDsSinhVien.ColumnSplitBoxPolicy = FarPoint.Win.Spread.SplitBoxPolicy.Never;
			this.dmSpreadDsSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dmSpreadDsSinhVien.ExListMode = Jp.Co.Unisys.EFSA.Windows.Spread.ExListModeTypes.INPUT_NORMAL;
			this.dmSpreadDsSinhVien.ExMoveScrollRowCount = 0;
			this.dmSpreadDsSinhVien.Location = new System.Drawing.Point(0, 144);
			this.dmSpreadDsSinhVien.Name = "dmSpreadDsSinhVien";
			this.dmSpreadDsSinhVien.RowSplitBoxPolicy = FarPoint.Win.Spread.SplitBoxPolicy.Never;
			this.dmSpreadDsSinhVien.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Cells;
			this.dmSpreadDsSinhVien.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.dmSpreadDsSinhVien_Sheet1});
			this.dmSpreadDsSinhVien.Size = new System.Drawing.Size(602, 472);
			this.dmSpreadDsSinhVien.TabIndex = 4;
			// 
			// dmSpreadDsSinhVien_Sheet1
			// 
			this.dmSpreadDsSinhVien_Sheet1.Reset();
			this.dmSpreadDsSinhVien_Sheet1.SheetName = "Sheet1";
			// Formulas and custom names must be loaded with R1C1 reference style
			this.dmSpreadDsSinhVien_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
			this.dmSpreadDsSinhVien_Sheet1.ColumnCount = 3;
			this.dmSpreadDsSinhVien_Sheet1.RowCount = 1;
			this.dmSpreadDsSinhVien_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "STT";
			this.dmSpreadDsSinhVien_Sheet1.ColumnHeader.Cells.Get(0, 1).Locked = true;
			this.dmSpreadDsSinhVien_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "Họ Tên";
			this.dmSpreadDsSinhVien_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "Lớp";
			this.dmSpreadDsSinhVien_Sheet1.Columns.Get(0).Label = "STT";
			this.dmSpreadDsSinhVien_Sheet1.Columns.Get(0).Width = 40F;
			this.dmSpreadDsSinhVien_Sheet1.Columns.Get(1).Label = "Họ Tên";
			this.dmSpreadDsSinhVien_Sheet1.Columns.Get(1).Width = 185F;
			this.dmSpreadDsSinhVien_Sheet1.Columns.Get(2).Label = "Lớp";
			this.dmSpreadDsSinhVien_Sheet1.Columns.Get(2).Width = 95F;
			this.dmSpreadDsSinhVien_Sheet1.RowHeader.Columns.Default.Resizable = false;
			this.dmSpreadDsSinhVien_Sheet1.RowHeader.Visible = false;
			this.dmSpreadDsSinhVien_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
			// 
			// dmButtonAdd
			// 
			this.dmButtonAdd.ExBackColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmButtonAdd.ExButtonEnableFlgID = Jp.Co.Unisys.EFSA.Windows.Controls.EnableFlgID.Default;
			this.dmButtonAdd.ExCaption = "Thêm";
			this.dmButtonAdd.ExForeColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmButtonAdd.ExIsPaintNextScreenColor = true;
			this.dmButtonAdd.ExNextScreenID = "";
			this.dmButtonAdd.ExProgressDialogVisible = false;
			this.dmButtonAdd.ExShortCutKey = Jp.Co.Unisys.EFSA.Windows.Controls.ButtonShortCutKeys.NONE;
			this.dmButtonAdd.ExUserSetBackColor = System.Drawing.SystemColors.Control;
			this.dmButtonAdd.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmButtonAdd.Location = new System.Drawing.Point(158, 112);
			this.dmButtonAdd.Name = "dmButtonAdd";
			this.dmButtonAdd.Size = new System.Drawing.Size(140, 26);
			this.dmButtonAdd.TabIndex = 5;
			this.dmButtonAdd.Text = "Thêm";
			this.dmButtonAdd.UseVisualStyleBackColor = true;
			this.dmButtonAdd.Click += new System.EventHandler(this.dmButtonAdd_Click);
			// 
			// dmButtonUpdate
			// 
			this.dmButtonUpdate.ExBackColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmButtonUpdate.ExButtonEnableFlgID = Jp.Co.Unisys.EFSA.Windows.Controls.EnableFlgID.Default;
			this.dmButtonUpdate.ExCaption = "Sửa";
			this.dmButtonUpdate.ExForeColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmButtonUpdate.ExIsPaintNextScreenColor = true;
			this.dmButtonUpdate.ExNextScreenID = "";
			this.dmButtonUpdate.ExProgressDialogVisible = false;
			this.dmButtonUpdate.ExShortCutKey = Jp.Co.Unisys.EFSA.Windows.Controls.ButtonShortCutKeys.NONE;
			this.dmButtonUpdate.ExUserSetBackColor = System.Drawing.SystemColors.Control;
			this.dmButtonUpdate.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmButtonUpdate.Location = new System.Drawing.Point(304, 112);
			this.dmButtonUpdate.Name = "dmButtonUpdate";
			this.dmButtonUpdate.Size = new System.Drawing.Size(140, 26);
			this.dmButtonUpdate.TabIndex = 6;
			this.dmButtonUpdate.Text = "Sửa";
			this.dmButtonUpdate.UseVisualStyleBackColor = true;
			this.dmButtonUpdate.Click += new System.EventHandler(this.dmButtonUpdate_Click);
			// 
			// dmButtonDel
			// 
			this.dmButtonDel.ExBackColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmButtonDel.ExButtonEnableFlgID = Jp.Co.Unisys.EFSA.Windows.Controls.EnableFlgID.Default;
			this.dmButtonDel.ExCaption = "Xóa";
			this.dmButtonDel.ExForeColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmButtonDel.ExIsPaintNextScreenColor = true;
			this.dmButtonDel.ExNextScreenID = "";
			this.dmButtonDel.ExProgressDialogVisible = false;
			this.dmButtonDel.ExShortCutKey = Jp.Co.Unisys.EFSA.Windows.Controls.ButtonShortCutKeys.NONE;
			this.dmButtonDel.ExUserSetBackColor = System.Drawing.SystemColors.Control;
			this.dmButtonDel.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmButtonDel.Location = new System.Drawing.Point(450, 112);
			this.dmButtonDel.Name = "dmButtonDel";
			this.dmButtonDel.Size = new System.Drawing.Size(140, 26);
			this.dmButtonDel.TabIndex = 7;
			this.dmButtonDel.Text = "Xóa";
			this.dmButtonDel.UseVisualStyleBackColor = true;
			this.dmButtonDel.Click += new System.EventHandler(this.dmButtonDel_Click);
			// 
			// dmLabelSearch
			// 
			this.dmLabelSearch.AutoSize = true;
			this.dmLabelSearch.BackColor = System.Drawing.Color.Transparent;
			this.dmLabelSearch.ExCopyTextName = "";
			this.dmLabelSearch.ExUserSetBackColor = System.Drawing.Color.White;
			this.dmLabelSearch.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmLabelSearch.Location = new System.Drawing.Point(12, 90);
			this.dmLabelSearch.Name = "dmLabelSearch";
			this.dmLabelSearch.Size = new System.Drawing.Size(118, 12);
			this.dmLabelSearch.TabIndex = 8;
			this.dmLabelSearch.Text = "Tìm kiếm theo Họ Tên";
			// 
			// dmTextBox1
			// 
			this.dmTextBox1.ExBackColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmTextBox1.ExF4AssemblyName = "";
			this.dmTextBox1.ExF4ScreenID = "";
			this.dmTextBox1.ExForeColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmTextBox1.ExFullLengthSkip = true;
			this.dmTextBox1.ExInputCharType = Jp.Co.Unisys.EFSA.Windows.Controls.ExInputCharTypes.NORMAL;
			this.dmTextBox1.ExIsDspMode = false;
			this.dmTextBox1.ExIsHighlightText = true;
			this.dmTextBox1.ExIsNotCheckExternalChar = false;
			this.dmTextBox1.ExIsPaintErrorColor = false;
			this.dmTextBox1.ExIsPaintUnIndispensableColor = false;
			this.dmTextBox1.ExMinLength = 0;
			this.dmTextBox1.ExUserSetBackColor = System.Drawing.SystemColors.Window;
			this.dmTextBox1.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmTextBox1.Location = new System.Drawing.Point(136, 37);
			this.dmTextBox1.MaxLengthType = Jp.Co.Unisys.EFSA.Windows.Controls.ExLengthType.BYTE;
			this.dmTextBox1.Name = "dmTextBox1";
			this.dmTextBox1.Size = new System.Drawing.Size(195, 19);
			this.dmTextBox1.TabIndex = 9;
			// 
			// dmButtonRead
			// 
			this.dmButtonRead.ExBackColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmButtonRead.ExButtonEnableFlgID = Jp.Co.Unisys.EFSA.Windows.Controls.EnableFlgID.Default;
			this.dmButtonRead.ExCaption = "Xem";
			this.dmButtonRead.ExForeColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmButtonRead.ExIsPaintNextScreenColor = true;
			this.dmButtonRead.ExNextScreenID = "";
			this.dmButtonRead.ExProgressDialogVisible = false;
			this.dmButtonRead.ExShortCutKey = Jp.Co.Unisys.EFSA.Windows.Controls.ButtonShortCutKeys.NONE;
			this.dmButtonRead.ExUserSetBackColor = System.Drawing.SystemColors.Control;
			this.dmButtonRead.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmButtonRead.Location = new System.Drawing.Point(12, 112);
			this.dmButtonRead.Name = "dmButtonRead";
			this.dmButtonRead.Size = new System.Drawing.Size(140, 26);
			this.dmButtonRead.TabIndex = 10;
			this.dmButtonRead.Text = "Xem";
			this.dmButtonRead.UseVisualStyleBackColor = true;
			this.dmButtonRead.Click += new System.EventHandler(this.dmButtonRead_Click);
			// 
			// dmTextBox2
			// 
			this.dmTextBox2.ExBackColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmTextBox2.ExF4AssemblyName = "";
			this.dmTextBox2.ExF4ScreenID = "";
			this.dmTextBox2.ExForeColorType = Jp.Co.Unisys.EFSA.Windows.Controls.ExColorTypes.NORMAL;
			this.dmTextBox2.ExFullLengthSkip = true;
			this.dmTextBox2.ExInputCharType = Jp.Co.Unisys.EFSA.Windows.Controls.ExInputCharTypes.NORMAL;
			this.dmTextBox2.ExIsDspMode = false;
			this.dmTextBox2.ExIsHighlightText = true;
			this.dmTextBox2.ExIsNotCheckExternalChar = false;
			this.dmTextBox2.ExIsPaintErrorColor = false;
			this.dmTextBox2.ExIsPaintUnIndispensableColor = false;
			this.dmTextBox2.ExMinLength = 0;
			this.dmTextBox2.ExUserSetBackColor = System.Drawing.SystemColors.Window;
			this.dmTextBox2.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmTextBox2.Location = new System.Drawing.Point(136, 12);
			this.dmTextBox2.MaxLengthType = Jp.Co.Unisys.EFSA.Windows.Controls.ExLengthType.BYTE;
			this.dmTextBox2.Name = "dmTextBox2";
			this.dmTextBox2.Size = new System.Drawing.Size(84, 19);
			this.dmTextBox2.TabIndex = 11;
			// 
			// dmLabelSTT
			// 
			this.dmLabelSTT.AutoSize = true;
			this.dmLabelSTT.BackColor = System.Drawing.Color.Transparent;
			this.dmLabelSTT.ExCopyTextName = "";
			this.dmLabelSTT.ExUserSetBackColor = System.Drawing.Color.White;
			this.dmLabelSTT.ExUserSetForeColor = System.Drawing.Color.Black;
			this.dmLabelSTT.Location = new System.Drawing.Point(81, 15);
			this.dmLabelSTT.Name = "dmLabelSTT";
			this.dmLabelSTT.Size = new System.Drawing.Size(49, 12);
			this.dmLabelSTT.TabIndex = 13;
			this.dmLabelSTT.Text = "Số thứ tự";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 616);
			this.Controls.Add(this.dmLabelSTT);
			this.Controls.Add(this.dmTextBox2);
			this.Controls.Add(this.dmButtonRead);
			this.Controls.Add(this.dmTextBox1);
			this.Controls.Add(this.dmLabelSearch);
			this.Controls.Add(this.dmButtonDel);
			this.Controls.Add(this.dmButtonUpdate);
			this.Controls.Add(this.dmButtonAdd);
			this.Controls.Add(this.dmSpreadDsSinhVien);
			this.Controls.Add(this.dmTextBoxClass);
			this.Controls.Add(this.dmLabelClass);
			this.Controls.Add(this.dmLabelName);
			this.Controls.Add(this.dmTextBoxName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dmSpreadDsSinhVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dmSpreadDsSinhVien_Sheet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Jp.Co.Unisys.EFSA.Windows.Controls.DMTextBox dmTextBoxName;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMLabel dmLabelName;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMLabel dmLabelClass;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMTextBox dmTextBoxClass;
		private Jp.Co.Unisys.EFSA.Windows.Spread.DMSpread dmSpreadDsSinhVien;
		private FarPoint.Win.Spread.SheetView dmSpreadDsSinhVien_Sheet1;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMButton dmButtonAdd;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMButton dmButtonUpdate;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMButton dmButtonDel;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMLabel dmLabelSearch;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMTextBox dmTextBox1;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMButton dmButtonRead;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMTextBox dmTextBox2;
		private Jp.Co.Unisys.EFSA.Windows.Controls.DMLabel dmLabelSTT;
	}
}

