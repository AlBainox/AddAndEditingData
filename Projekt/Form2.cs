using Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			completingTheFields();
			form1= new Form1();
		}
		public Form1 form1 { get; private set; }
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (ChangingDataContractor.AddClicked)
			{
				ChangingDataContractor.ContractorsName = tbxContractorName.Text;
				ChangingDataContractor.Nip= tbxNIP.Text;
				ChangingDataContractor.TypeOfContractor= cbxContractorType.Text;
				ChangingDataContractor.CompanyDescription= tbxDescription.Text;
				ChangingDataContractor.IsActive= chbIsActive.Checked;
				form1.AddContractorToDB();
			}
			else if (ChangingDataContractor.EditClicked)
			{
				ChangingDataContractor.ContractorsName = tbxContractorName.Text;
				ChangingDataContractor.Nip = tbxNIP.Text;
				ChangingDataContractor.TypeOfContractor = cbxContractorType.Text;
				ChangingDataContractor.CompanyDescription = tbxDescription.Text;
				ChangingDataContractor.IsActive = chbIsActive.Checked;
				form1.EditContractorFromDB();
			}
			Close();
		}
		private void completingTheFields()
		{
			if (ChangingDataContractor.EditClicked)
			{
				tbxContractorName.Text = ChangingDataContractor.ContractorsName;
				tbxNIP.Text = ChangingDataContractor.Nip;
				cbxContractorType.Text = ChangingDataContractor.TypeOfContractor;
				tbxDescription.Text = ChangingDataContractor.CompanyDescription;
				chbIsActive.Checked = ChangingDataContractor.IsActive;
			}
		}
	}
}
