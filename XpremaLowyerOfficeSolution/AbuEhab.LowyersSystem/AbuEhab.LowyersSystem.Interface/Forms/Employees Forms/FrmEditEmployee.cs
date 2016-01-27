using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbuEhab.LowyersSystem.DataLaye;
using AbuEhab.LowyersSystem.DataLaye.Tables_Classes;
namespace AbuEhab.LowyersSystem.Interface.Forms.Employees_Forms
{
    public partial class FrmEditEmployee : Form
    {
        EmployeeCmd cmd = new EmployeeCmd();

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
            if (txtEmployeeName.Text != string.Empty)
            {
                Employee emp = new Employee()
                {
                    EmployeeName = txtEmployeeName.Text,
                    Address = txtAddress.Text,
                    IdNumber = txtIDCard.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text
                };
                cmd.EditEmployee(emp, TargetEmployee.Id);
                MessageBox.Show("تم التعديل");
                base.Close();
            }
        }



    }
}
