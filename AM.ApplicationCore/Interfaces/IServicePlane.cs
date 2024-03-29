﻿using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane:IService<Plane>
    {

        //public void AddPlane(Plane plane);
        //public void RemovePlane(Plane plane);
        //public List<Plane> GetPlaneList();
        public IList<Plane> GetPassenger(Plane plane);


        public IList<Flight> GetFlights(int n);

        public bool isAvailable(Flight flight, int n);

        public void DeletePlanes();

    }
}
