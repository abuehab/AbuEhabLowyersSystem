using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

namespace AbuEhab.LowyersSystem.DataLaye.Tables_Classes
{
    public class EmployeeCmd : Database 
    {


        public bool NewEmployee(Employee employee)
        {
            context = new DbDataContext();
            context.Employees.InsertOnSubmit(employee);
            context.SubmitChanges();
            return true;
        }




        public bool EditEmployee(Employee emp, int xid)
        {
            emp.Id = xid;
            var q = CompiledQuery.Compile((DbDataContext db, int i) =>
                                             db.Employees.Single(d => d.Id == i));
            var employee = q(context, xid);

            employee.EmployeeName = emp.EmployeeName;
            employee.Address = emp.Address;
            employee.Phone = emp.Phone;
            employee.IdNumber = emp.IdNumber;
            employee.Described = emp.Described;

            context.SubmitChanges();
            return true;
        }







        public List<Employee> AllEmplyees()
        {
            try
            {
                var q = CompiledQuery.Compile((DbDataContext db) =>
                                                                db.Employees
                                                               );
                var employees = q(context).ToList();

                return employees;

            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Employee> ListEmplyee_ByName(string name)
        {
            try
            {
                var q = CompiledQuery.Compile((DbDataContext db, string n) =>
                                                                db.Employees.Where(c => c.EmployeeName.Contains(n)
                                                             ));
                var employees = q(context, name).ToList();

                return employees;

            }
            catch (Exception)
            {

                return null;
            }
        }


        public Employee GetEmployeeByName(string name)
        {
            try
            {
                var q = CompiledQuery.Compile((DbDataContext db, string n) =>
                                     db.Employees.Where(c => c.EmployeeName == n)
                                     );
                var employee = q(context, name).Single();
                return employee;
            }
            catch (Exception)
            {

                return null;
            }
        }


        public Employee GetEmployeeById(int employeeid)
        {
            try
            {
                var q = CompiledQuery.Compile((DbDataContext db, int i) =>
                                                              db.Employees.Where(c => c.Id == i));
                var employee = q(context, employeeid).Single();
                return employee;
            }
            catch (Exception)
            {

                return null;
            }
        }



        public bool DeleteEmployee(Employee emp, int xid)
        {
            emp.Id = xid;
            var q = CompiledQuery.Compile((DbDataContext db, int i) =>
                                                          db.Employees.Single(d => d.Id == i));
            var employee = q(context, xid);
            context.Employees.DeleteOnSubmit(employee);
            context.SubmitChanges();
            return true;
        }


    }
}
