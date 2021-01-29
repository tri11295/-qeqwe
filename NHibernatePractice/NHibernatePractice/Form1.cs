//---------------------------------------------------------------------------
//
//	System		:	WAO台湾
//	ClasName	:	Form1
//	OverView	:	Màn hình thống kê thông tin sinh viên
//	Designer	:	TriNQ＠SSV
//	Programer	:	TriNQ＠SSV
//	Created Date:	YYYY/MM/DD
//
#region -----------< History >-----------------------------------------------
//	ID			:
//	Designer	:
//	Programmer	:
//	Updated Date:
//	Comment		:
//	Version		:
//---------------------------------------------------------------------------
#endregion

using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHibernatePractice
{
	public partial class Form1 : Form
	{
		private Configuration myConfiguration;
		private ISessionFactory mySessionFactory;
		private ISession mySession;

		private IList<SinhVien> listSinhVien;

		public Form1()
		{
			InitializeComponent();
		}

		private void SetDataGridViewSinhVien()
		{
			this.dataGridViewListSinhVien.DataSource = this.listSinhVien;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				myConfiguration = new Configuration();
				myConfiguration.Configure();
				mySessionFactory = myConfiguration.BuildSessionFactory();
				mySession = mySessionFactory.OpenSession();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void buttonRead_Click(object sender, EventArgs e)
		{
			using (mySession.BeginTransaction())
			{
				ICriteria criteria = mySession.CreateCriteria<SinhVien>();
				listSinhVien = criteria.List<SinhVien>();

				mySession.Transaction.Commit();
			}
			this.SetDataGridViewSinhVien();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			try
			{
				 // Add Record
				using (mySession.BeginTransaction())
				{
					string name = textBoxName.Text;
					string classStudent = textBoxClass.Text;

					SinhVien sinhVien = new SinhVien { HoTen = name, Lop = classStudent };
					mySession.Save(sinhVien);

					mySession.Transaction.Commit();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				// Update Record
				using (mySession.BeginTransaction())
				{
					int id = textbox
					string name = textBoxName.Text;
					string classStudent = textBoxClass.Text;

					SinhVien sinhVien = new SinhVien { HoTen = name, Lop = classStudent };
					mySession.Save(sinhVien);

					mySession.Transaction.Commit();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void buttonDel_Click(object sender, EventArgs e)
		{

		}
	}
}
