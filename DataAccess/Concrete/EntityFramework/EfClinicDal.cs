using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfClinicDal : EfEntityRepositoryBase<Clinic, HospitalContext>, IClinicDal
    {
        //Entity Framework kullanarak veritabanı ile etkileşim altyapısını kurdum.
        //Genel operasyonları entity frameworkü kullanarak Core katmanından aldım.
    }
}