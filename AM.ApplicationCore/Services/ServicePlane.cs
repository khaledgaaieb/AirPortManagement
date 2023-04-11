using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : IServicePlane
    {
        //private readonly IGenericRepository<Plane> _repository;
        private IUnitOfWork unitOfWork;
        public ServicePlane(IUnitOfWork uof)
        {
            unitOfWork= uof;
        }
        public void AddPlane(Plane plane)
        {
            unitOfWork.Repository<Plane>().Add(plane);
        }

        public List<Plane> GetPlaneList()
        {
            return unitOfWork.Repository<Plane>().GetAll().ToList();
        }

        public void RemovePlane(Plane plane)
        {
            unitOfWork.Repository<Plane>().Delete(plane);
        }
    }
}
