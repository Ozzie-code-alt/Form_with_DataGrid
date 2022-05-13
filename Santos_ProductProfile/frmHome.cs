using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santos_ProductProfile
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void dataEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataEmployees.Rows.Add(txtEmpID.Text,txtempLname.Text,txtempFName.Text,txtEmpMname.Text,txtempAddress.Text);
            CLearAll();
        }

        private void CLearAll()
        {
            txtEmpID.Clear();
            txtempLname.Clear();
            txtempFName.Clear();
            txtEmpMname.Clear();
            txtempAddress.Clear();
            button1.Enabled = true;
            btnUpdate.Enabled = !true;
        }

        private void dataEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if(dataEmployees.SelectedRows.Count > 0)
            {
                txtEmpID.Text = dataEmployees.SelectedRows[0].Cells[0].Value.ToString();
                txtempLname.Text = dataEmployees.SelectedRows[0].Cells[1].Value.ToString();
                txtempFName.Text = dataEmployees.SelectedRows[0].Cells[2].Value.ToString();
                txtEmpMname.Text = dataEmployees.SelectedRows[0].Cells[3].Value.ToString();
                txtempAddress.Text = dataEmployees.SelectedRows[0].Cells[4].Value.ToString();
                btnUpdate.Enabled = true;
                button1.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataEmployees.SelectedRows.Count > 0)
            {
                dataEmployees.SelectedRows[0].Cells[0].Value = txtEmpID.Text;
                 dataEmployees.SelectedRows[0].Cells[1].Value = txtempLname.Text;
                 dataEmployees.SelectedRows[0].Cells[2].Value = txtempFName.Text;
                 dataEmployees.SelectedRows[0].Cells[3].Value = txtEmpMname.Text;
                dataEmployees.SelectedRows[0].Cells[4].Value = txtempAddress.Text;
                CLearAll();
            }

        }

      

        private void btnCLear_Click(object sender, EventArgs e)
        {
            CLearAll();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnUpdatee.Enabled = false;
        }









        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataPRD.Rows.Add(txtPrdID.Text,txtprdName.Text,txtPrdType.Text,txtPrdManufact.Text,txtPrdPPU.Text);
            CLearAlls();
        }

        private void dataPRD_SelectionChanged(object sender, EventArgs e)
        {
            if(dataPRD.SelectedRows.Count > 0)
            {
                txtPrdID.Text = dataPRD.SelectedRows[0].Cells[0].Value.ToString();
                txtprdName.Text = dataPRD.SelectedRows[0].Cells[1].Value.ToString();
                txtPrdType.Text = dataPRD.SelectedRows[0].Cells[2].Value.ToString();
                txtPrdManufact.Text = dataPRD.SelectedRows[0].Cells[3].Value.ToString();
                txtPrdPPU.Text = dataPRD.SelectedRows[0].Cells[4].Value.ToString();


                btnUpdatee.Enabled = true;
                btnAdd.Enabled = false;
                
            }
        }
        private void CLearAlls()
        {
           txtPrdID.Clear();
           txtprdName.Clear();
           txtPrdType.Clear();
           txtPrdManufact.Clear();
           txtPrdPPU.Clear();
           
            btnAdd.Enabled = true;
            btnUpdatee.Enabled = !true;

        }
        private void btnUpdatee_Click(object sender, EventArgs e)
        {
            if (dataPRD.SelectedRows.Count > 0)
            {
                dataPRD.SelectedRows[0].Cells[0].Value = txtPrdID.Text;
                dataPRD.SelectedRows[0].Cells[1].Value = txtprdName.Text;
                dataPRD.SelectedRows[0].Cells[2].Value = txtPrdType.Text;
                dataPRD.SelectedRows[0].Cells[3].Value = txtPrdManufact.Text;
                dataPRD.SelectedRows[0].Cells[4].Value = txtPrdPPU.Text;
            }
        }

        private void btnClearer_Click(object sender, EventArgs e)
        {
            CLearAlls();
        }
    }
}
