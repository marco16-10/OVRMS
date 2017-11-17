using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OVRMS.DAL
{
    class EmployeeDAL : IRecord<Employee> 
    {
        OVRMSDCDataContext db = new OVRMSDCDataContext();

        public int addItem(Employee p)
        {
            db.Employees.InsertOnSubmit(p);
            db.SubmitChanges();
            return p.IdEmp;
        }

        public void updateItem(Employee p)
        {
            Employee pt = getItem(p.IdEmp);
            pt.FirstName = p.FirstName;
            pt.LastName = p.LastName;
            pt.Address = p.Address;
            db.SubmitChanges();
        }

        public Employee getItem(int pid)
        {
            return db.Employees.First(b => b.IdEmp == pid);
        }

        public Employee getItem(string name)
        {
            return db.Employees.First(b => b.FirstName == name);
        }

        public void deleteItem(int pid)
        {
            db.Employees.DeleteOnSubmit(getItem(pid));
        
            db.SubmitChanges();
        }
    }
}
