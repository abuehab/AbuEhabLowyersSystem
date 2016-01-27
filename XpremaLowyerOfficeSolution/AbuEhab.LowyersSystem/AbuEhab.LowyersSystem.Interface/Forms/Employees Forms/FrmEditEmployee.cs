using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbuEhab.LowyersSystem.DataLaye;
namespace AbuEhab.LowyersSystem.Interface.Forms.Employees_Forms
{
    public partial class FrmEditEmployee : Form
    {
        public FrmEditEmployee()
        {
            InitializeComponent();
        }

        public Employee TargetEmployee { get; set; }
        void LoadingData()
        {
            txtEmployeeName.Text = TargetEmployee.EmployeeName;
            txtAddress.Text = TargetEmployee.Address;
            txtEmail.Text = TargetEmployee.Email;
            txtIDCard.Text = TargetEmployee.IdNumber;
            txtPhone.Text = TargetEmployee.Phone;
        }
        private void FrmEditEmployee_Load(object sender, EventArgs e)
        {
            LoadingData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }



    }
}
