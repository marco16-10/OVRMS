using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OVRMS.DAL
{
    class RentalDAL : IRecord<Rental>
    {
        OVRMSDCDataContext db = new OVRMSDCDataContext();

        public int addItem(Rental v)
        {
            db.Rentals.InsertOnSubmit(v);
            db.SubmitChanges();
            return v.IdRental;
        }

        public void updateItem(Rental r)
        {
            Rental ren = getItem(r.IdRental);
            ren.IdRental = r.IdRental;
            ren.IdCustomer = r.IdCustomer;
            ren.RentalExpStartDate = r.RentalExpStartDate;
            ren.RentalExpEndtDate = r.RentalExpEndtDate;
            ren.RentalActStartDate = r.RentalActStartDate;
            ren.RentalActEndDate = r.RentalActEndDate;
            ren.DamagesPenalty = r.DamagesPenalty;
            ren.LowFuelPenalty = r.LowFuelPenalty;
            ren.RoadOffencePenalty = r.RoadOffencePenalty;
            ren.LateReturnPenalty = r.LateReturnPenalty;
            ren.NumberOfKm = r.NumberOfKm;
            ren.NumberOfDays = r.NumberOfDays;
            ren.Notes = r.Notes;
        }

        public Rental getItem(int pid)
        {
            return db.Rentals.First(b => b.IdRental == pid);
        }

        public Rental getItem(string name)
        {
            return null;
        }

        public void deleteItem(int pid)
        {
            db.Rentals.DeleteOnSubmit(getItem(pid));

            db.SubmitChanges();
        }
    }
}