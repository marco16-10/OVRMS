using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OVRMS.DAL
{
    class CustomerDAL: IRecord<Customer>
    {
        OVRMSDCDataContext db = new OVRMSDCDataContext();

        public int addItem(Customer c)
        {
            db.Customers.InsertOnSubmit(c);
            db.SubmitChanges();
            return c.IdCustomer;
        }

        public void updateItem(Customer c)
        {
            Customer pt = getItem(c.IdCustomer);
            pt.FirstName = c.FirstName;
            pt.LastName = c.LastName;
            pt.Address = c.Address;
            pt.LicenceNumber = c.LicenceNumber;
            pt.DateOfBirth = c.DateOfBirth;
            pt.Status = c.Status;
            pt.Email = c.Email;
            pt.Mobile = c.Mobile;
            pt.Notes = c.Notes;
            db.SubmitChanges();
        }

        public Customer getItem(int pid)
        {
            return db.Customers.First(b => b.IdCustomer == pid);
        }

        public Customer getItem(string name)
        {
            return db.Customers.First(b => b.FirstName == name);
        }

        public void deleteItem(int pid)
        {
            db.Customers.DeleteOnSubmit(getItem(pid));

            db.SubmitChanges();
        }
    }
}
