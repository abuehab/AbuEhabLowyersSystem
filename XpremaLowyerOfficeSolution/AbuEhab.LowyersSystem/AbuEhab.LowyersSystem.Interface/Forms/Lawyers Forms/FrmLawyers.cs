using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AbuEhab;
using AbuEhab.LowyersSystem.DataLaye.Tables_Classes;
using System.Windows.Forms;
using AbuEhab.LowyersSystem.DataLaye;

namespace AbuEhab.LowyersSystem.Interface.Forms.Lowyers_Forms
{
    public partial class FrmLawyers : Form
    {
        public FrmLawyers()
        {
            InitializeComponent();
        }
        Lawyer cmd=new Lawyer();

        private void PopulateDgv()
        {

        }

        private void FrmLowyers_Load(object sender, EventArgs e)
        {

        }
    }
}
