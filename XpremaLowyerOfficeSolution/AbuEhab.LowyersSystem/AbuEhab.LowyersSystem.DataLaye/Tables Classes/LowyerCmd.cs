using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbuEhab.LowyersSystem.DataLaye.Tables_Classes
{
    public class LowyerCmd : Database 
    {


        // Go Do It 
        public bool NewLowyer(Lawyer lo)
        {
            context =new DbDataContext();
            context.Lawyers.InsertOnSubmit(lo);
            context.SubmitChanges();
            return true;
        }
    }
}
