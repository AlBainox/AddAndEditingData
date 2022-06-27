using Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			db = new Models.ContractorDbContext();
			var data = db.Contractors.ToList();
			dgvContractors.DataSource = data;


		}
		Models.ContractorDbContext db;
		bool AddClicked = false;
		bool EditClicked = false;
		public delegate void ChangingDataGridHandler();
				public event ChangingDataGridHandler ChangingData;
		
		protected virtual void OnDataChanged()
		{
			if (ChangingData != null)
				ChangingData();
			else
			{
				
				dgvContractors.Refresh();
				dgvContractors.Update();
			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			ChangingDataContractor.AddClicked = true;
			ChangingDataContractor.ContractorsName = null;
			ChangingDataContractor.Nip = null;
			ChangingDataContractor.TypeOfContractor = null;
			ChangingDataContractor.CompanyDescription = null;
			ChangingDataContractor.IsActive = true;
			Form2 formAddEdit = new Form2();
            formAddEdit.ShowDialog();
			
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			ChangingDataContractor.EditClicked = true;
			Form2 formAddEdit = new Form2();
			formAddEdit.ShowDialog();
			
		}

		private void RowSelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgvContractors.SelectedRows)
			{

				ChangingDataContractor.ContractorsName = row.Cells[1].Value.ToString();
				ChangingDataContractor.Nip = row.Cells[2].Value.ToString();
				ChangingDataContractor.TypeOfContractor = row.Cells[3].Value.ToString();
				ChangingDataContractor.CompanyDescription = row.Cells[4].Value.ToString();
				ChangingDataContractor.IsActive = (bool)row.Cells[5].Value;
			}

		}
		public void AddContractorToDB()
		{
			var contractor = new ContractorModel()
			{
				ContractorsName = ChangingDataContractor.ContractorsName,
				Nip = ChangingDataContractor.Nip,
				TypeOfContractor = ChangingDataContractor.TypeOfContractor,
				CompanyDescription = ChangingDataContractor.CompanyDescription,
				IsActive = ChangingDataContractor.IsActive,
			};

			db.Contractors.Add(contractor);
			db.SaveChanges();

			ChangingDataContractor.AddClicked = false;
			ChangingDataContractor.EditClicked = false;
			
			OnDataChanged();

			
			

		}

		public void EditContractorFromDB()
		{
			var contractor = db.Contractors.Where(c => c.Nip == ChangingDataContractor.Nip).First();
			contractor.ContractorsName	= ChangingDataContractor.ContractorsName;
			contractor.Nip = ChangingDataContractor.Nip;
			contractor.TypeOfContractor = ChangingDataContractor.TypeOfContractor;
			contractor.CompanyDescription = ChangingDataContractor.CompanyDescription;
			contractor.IsActive = ChangingDataContractor.IsActive;
			db.SaveChanges();
			ChangingDataContractor.AddClicked = false;
			ChangingDataContractor.EditClicked = false;
			OnDataChanged();
			
			
		}


	}
}
