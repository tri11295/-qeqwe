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

namespace NHibernateTest
{
	public partial class Form1 : Form
	{
		private Configuration myConfiguration;
		private ISessionFactory mySessionFactory;
		private ISession mySession;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			myConfiguration = new Configuration();
			myConfiguration.Configure();
			mySessionFactory = myConfiguration.BuildSessionFactory();
			mySession = mySessionFactory.OpenSession();
		}

		private void dmButtonRead_Click(object sender, EventArgs e)
		{

		}

		private void dmButtonAdd_Click(object sender, EventArgs e)
		{
			try
			{
				// Add Record
				using (mySession.BeginTransaction())
				{
					string name = dmTextBoxName.Text;
					string classStudent = dmTextBoxClass.Text;

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

		private void dmButtonUpdate_Click(object sender, EventArgs e)
		{

		}

		private void dmButtonDel_Click(object sender, EventArgs e)
		{

		}
	}
}
