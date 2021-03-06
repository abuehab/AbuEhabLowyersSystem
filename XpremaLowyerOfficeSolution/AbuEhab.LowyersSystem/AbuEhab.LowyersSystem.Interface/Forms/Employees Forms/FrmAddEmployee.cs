﻿using AbuEhab.LowyersSystem.DataLaye;
using AbuEhab.LowyersSystem.DataLaye.Tables_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbuEhab;

namespace AbuEhab.LowyersSystem.Interface.Forms.Employees_Forms
{
    public partial class FrmAddEmployee : Form
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }



        
        EmployeeCmd cmd = new EmployeeCmd();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text != string.Empty)
            {
                #region "                check Employee   existed or not               "

                Employee employee = cmd.GetEmployeeByName(txtEmployeeName.Text);
                if (employee != null)
                {
                    return;
                }


                #endregion ""
                // كمل الكود 
                // او
                // Start Save New Employee//
                _Operation.StartOperation(this);


                Employee tb = new Employee() { EmployeeName = txtEmployeeName .Text,Address=txtAddress.Text,
                                            Email=txtEmail.Text ,IdNumber=txtIDCard.Text,Phone=txtPhone.Text  };
                cmd.NewEmployee(tb);
                _Operation.EndOperation(this);

                MessageBox.Show("Saved ");
            }
        }

        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            _Operation.ClearTextControls(this); // لتفريغ مربعات النص 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _Operation.ClearTextControls(this); // لتفريغ مربعات النص 
     
        }
        _Styler xStyler = new _Styler();
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            xStyler.TextKeyPressWithoutDot(txtPhone, e);
        }

        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            xStyler.TextKeyPressWithoutDot(txtIDCard, e);

        }
    }
}
