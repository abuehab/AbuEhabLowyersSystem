using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbuEhab.LowyersSystem.DataLaye.Tables_Classes
{
    public class LowyerCmd : Database 
    {


        // Go Do It 
        /// <summary>
        /// This Method to add new lowyer
        /// </summary>
        /// <param name="lo">Object</param>
        /// <returns> Return true  or false </returns>
        public bool NewLowyer(Lawyer lo)
        {
            context =new DbDataContext();
            context.Lawyers.InsertOnSubmit(lo);
            context.SubmitChanges();
            return true;
        }


       
    }
}
