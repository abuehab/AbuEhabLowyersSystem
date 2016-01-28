using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public bool EditLowyer(Lawyer low, int xid)
        {
            low.Id = xid;
            var q = CompiledQuery.Compile((DbDataContext db, int i) =>
                db.Lawyers.Single(d => d.Id == i));
            var lawyer = q(context, xid);
            lawyer.LawyerName = low.LawyerName;
            lawyer.Address = low.Address;
            lawyer.Phone = low.Phone;
            lawyer.Describe = low.Describe;
            lawyer.FollowUpIssues = low.FollowUpIssues;

            context.SubmitChanges();

            return true;
        }

        public List<Lawyer> AlLawyers()
        {
            try
            {
                var q = CompiledQuery.Compile((DbDataContext db) =>
                                    db.Lawyers);
                var low = q(context).ToList();
                return low;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Lawyer GetLawyerByName(string n)
        {
            try
            {
                var q = CompiledQuery.Compile((DbDataContext db,string name) =>
                                    db.Lawyers.Where(p=>p.LawyerName==name));
                var low = q(context, n).Single();
                return low;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Lawyer GetLawyerById(int x)
        {
            try
            {
                var q = CompiledQuery.Compile((DbDataContext db, int id) =>
                    db.Lawyers.Where(p => p.Id == x));

                var low = q(context,x).Single();
                return low;
            }
            catch (Exception)
            {
                return null;    
             
            }
        }
    }
}
