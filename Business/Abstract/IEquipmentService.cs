using Core.Result.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IEquipmentService
    {
        //İş katmanı için genel operasyonlar yazıldı.
        IDataResult<List<Equipment>> GetAll();
        IDataResult<Equipment> GetById(int Id);
        IResult Add(Equipment equipment);
        IResult Update(Equipment equipment);
        IResult Delete(Equipment equipment);
        IDataResult<List<EquipmentDetailsDto>> GetEquipmentDetails();
        IDataResult<List<EquipmentDetailsDto>> GetEquipmentDetailsById(int id);
    }
}