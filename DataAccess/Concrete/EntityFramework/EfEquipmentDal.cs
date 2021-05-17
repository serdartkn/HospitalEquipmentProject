using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEquipmentDal : EfEntityRepositoryBase<Equipment, HospitalContext>, IEquipmentDal
    {
        //Entity Framework kullanarak veritabanı ile etkileşim altyapısını kurdum.
        //Genel operasyonları entity frameworkü kullanarak Core katmanından aldım.
        public List<EquipmentDetailsDto> GetEquipmentDetails(Expression<Func<EquipmentDetailsDto, bool>> filter = null)
        {
            using (HospitalContext context1 = new HospitalContext())
            {
                var result = from e in context1.Equipments
                             join c in context1.Clinics on e.ClinicId equals c.Id

                             select new EquipmentDetailsDto
                             {
                                 EquipmentId = e.Id,
                                 ClinicId = e.ClinicId,
                                 ClinicName = c.Name,
                                 EquipmentName = e.Name,
                                 ProcurementDate = e.ProcurementDate,
                                 UnitPrice = e.UnitPrice,
                                 UnitsInStock = e.UnitsInStock,
                                 UsageRate = e.UsageRate
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}