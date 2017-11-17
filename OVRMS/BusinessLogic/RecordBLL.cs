using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OVRMS.DAL;

namespace OVRMS.BLL
{
    class RecordBLL
    {
        CustomerDAL cust = new CustomerDAL();
        EmployeeDAL s = new EmployeeDAL();
        OVRMSDCDataContext db = new OVRMSDCDataContext();

        /* Customer Record */
        public int addCustomer(Customer nw)
        {
            return cust.addItem(nw);         
        }

        public void updateCustomer(Customer nw)
        {
            cust.updateItem(nw);
        }

        public Customer getCustomer(int pid)
        {
            return cust.getItem(pid);
        }

        public Customer getCustomer(string str)
        {
            return cust.getItem(str);
        }

        public object getCustomerGridList()
        {
            var CustomerList = from cust in db.Customers
                              select new
                              {
                                  ID = cust.IdCustomer,
                                  FirstName = cust.FirstName,
                                  LastName = cust.LastName
        };
            return CustomerList.Distinct();
        }

        public void deleteCustomer(int pid)
        {
            cust.deleteItem(pid);
        }

        /* Employee Record */
        public int addEmployee(Employee nw)
        {
            /* Store the MD5 of password */
            LoginBLL l = new LoginBLL();
            string password = l.GetMd5Hash(nw.Password);
            nw.Password = password;

            return s.addItem(nw);
        }

        public void updateEmployee(Employee nw)
        {
            /* Store the MD5 of password */
            LoginBLL l = new LoginBLL();
            string password = l.GetMd5Hash(nw.Password);
            nw.Password = password;
            
            s.updateItem(nw);
        }

        public Employee getEmployee(int pid)
        {
            return s.getItem(pid);
        }

        public Employee getEmployee(string str)
        {
            return s.getItem(str);
        }

        public void deleteEmployee(int pid)
        {
            s.deleteItem(pid);
        }

        public object getEmployeeGridList()
        {
            var EmployeeList = from emp in db.Employees join r in db.Roles on emp.IdRole equals r.IdRole
                              select new
                              {
                                  ID = emp.IdEmp,
                                  FirstName = emp.FirstName,
                                  LastName = emp.LastName
                              };
            return EmployeeList.Distinct();
        }


        public bool checkUser(int uid, string password)
        {
            LoginBLL l = new LoginBLL();
            //string passwordMD5 = l.GetMd5Hash(password);
            var Employee = from u in db.Employees join r in db.Roles on u.IdRole equals r.IdRole
                        where u.IdEmp == uid && u.Password == password //passwordMD5
                           select u;
            if (Employee.Any(u => u.IdEmp == uid))
                return true;
            return false;
        }

    }
}
