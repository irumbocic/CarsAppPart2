using Project.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model.Common
{
    public interface IVehicleModel
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public  VehicleMake VehicleMake { get; set; }
    }
}
