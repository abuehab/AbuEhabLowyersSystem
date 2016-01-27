using AbuEhab.LowyersSystem.DataLaye.Tables_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbuEhab.LowyersSystem.Interface.Forms.Employees_Forms
{
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }
        EmployeeCmd cmd = new EmployeeCmd();

        void PopulateDgv()
        {
            cmd = new EmployeeCmd();

            var lst = cmd.AllEmplyees();

            Dgv.Rows.Clear();

            this.Invoke((MethodInvoker)delegate
            {



                lst.ForEach(i =>
                {


                    Dgv.Rows.Add(i.Id.ToString(),
                                              i.EmployeeName, i.Address, i.IdNumber, i.Phone, i.Described


                                            );

                });

            });

        }


        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv.Rows.Count > 0)
            {

                int col = this.Dgv.CurrentCell.ColumnIndex;

                var rw = cmd.GetEmployeeById(int.Parse(Dgv.CurrentRow.Cells[0].Value.ToString()));

                if (col.ToString() == "7")
                {

                    FrmEditEmployee frm = new FrmEditEmployee();
                    frm.TargetEmployee = rw;

                    frm.ShowDialog();
                }

                // Delete 
                if (col.ToString() == "8")
                {


                    if (MessageBox.Show("Are You Sure ? ", "Delete",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly |
                            MessageBoxOptions.DefaultDesktopOnly) == System.Windows.Forms.DialogResult.OK)
                    {
                        // _Operation.StartOperation(this);

                        cmd.DeleteEmployee(rw, rw.Id);

                    }
                }
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frm = new FrmAddEmployee();
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void BtnFrish_Click(object sender, EventArgs e)
        {
            PopulateDgv();
        }



    }
}
