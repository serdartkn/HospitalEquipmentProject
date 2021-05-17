using Core.Result.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IClinicService
    {
        //İş katmanı için genel operasyonlar yazıldı.
        IDataResult<List<Clinic>> GetAll();
        IDataResult<Clinic> GetById(int Id);
        IResult Add(Clinic clinic);
        IResult Update(Clinic clinic);
        IResult Delete(Clinic clinic);
    }
}