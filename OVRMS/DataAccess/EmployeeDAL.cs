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
            Employee emp = getItem(p.IdEmp);
            emp.FirstName = p.FirstName;
            emp.LastName = p.LastName;
            emp.IdRole = p.IdRole;
            emp.Address = p.Address;
            emp.DateofHire = p.DateofHire;
            emp.EmploymentType = p.EmploymentType;
            emp.Gender = p.Gender;
            emp.HourlyWage = p.HourlyWage;
            emp.Password = p.Password;
            emp.Qualification = p.Qualification;
            emp.TaxCode = p.TaxCode;
            emp.IsKiwiSaver = p.IsKiwiSaver;
            emp.KiwiSaverContrRate = p.KiwiSaverContrRate;
            emp.EmployerContrRate = p.EmployerContrRate;
            emp.Notes = p.Notes;
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
