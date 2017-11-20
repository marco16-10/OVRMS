using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OVRMS.DAL
{
    class VehicleDAL : IRecord<Vehicle>
    {
        OVRMSDCDataContext db = new OVRMSDCDataContext();

        public int addItem(Vehicle v)
        {
            db.Vehicles.InsertOnSubmit(v);
            db.SubmitChanges();
            return v.IdVehicle;
        }

        public void updateItem(Vehicle v)
        {
            Vehicle veh = getItem(v.IdVehicle);
            veh.IdVehicle = v.IdVehicle;
            veh.IdCategory = v.IdCategory;
            veh.Manufacturer = v.Manufacturer;
            veh.Model = v.Model;
            veh.RegistrationNo = v.RegistrationNo;
            veh.Status = v.Status;
            veh.Color = v.Color;
            veh.Description = v.Description;
            veh.Odometer = v.Odometer;
            veh.Year = v.Year;
            veh.Notes = v.Notes;
            db.SubmitChanges();
        }

        public Vehicle getItem(int pid)
        {
            return db.Vehicles.First(b => b.IdVehicle == pid);
        }

        public Vehicle getItem(string name)
        {
            return db.Vehicles.First(b => b.Description == name);
        }

        public void deleteItem(int pid)
        {
            db.Vehicles.DeleteOnSubmit(getItem(pid));

            db.SubmitChanges();
        }
    }
}

