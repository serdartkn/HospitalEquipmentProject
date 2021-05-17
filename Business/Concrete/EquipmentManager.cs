using Business.Abstract;
using Business.Constants;
using Core.Result.Abstract;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess.Abstract;
using Core.Aspect.Autofact.Validation;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Aspect.Autofac.Logging;
using Entities.Dto;

namespace Business.Concrete
{
    //DataAccess katmanına erişim sağlandı.
    public class EquipmentManager : IEquipmentService
    {

        IEquipmentDal _equipmentDal;
        public EquipmentManager(IEquipmentDal equipmentDal) {

            _equipmentDal = equipmentDal;
        
        }

        [ValidationAspect(typeof(EquipmentValidator))]
        //[LogAspect(typeof(DatabaseLogger))]
        public IResult Add(Equipment equipment)
        {
            _equipmentDal.Add(equipment);
            return new SuccesResult(Messages.EquipmentAdded);
        }

        public IResult Delete(Equipment equipment)
        {
            _equipmentDal.Delete(equipment);
            return new SuccesResult(Messages.EquipmentDeleted);
        }

        public IDataResult<List<Equipment>> GetAll()
        {
            return new SuccessDataResult<List<Equipment>>(_equipmentDal.GetAll(), Messages.EquipmentsListed);
        }

        public IDataResult<Equipment> GetById(int Id)
        {
            return new SuccessDataResult<Equipment>(_equipmentDal.Get(c => c.Id == Id), Messages.EquipmentListed);
        }

        public IDataResult<List<EquipmentDetailsDto>> GetEquipmentDetails()
        {
            return new SuccessDataResult<List<EquipmentDetailsDto>>(_equipmentDal.GetEquipmentDetails(), Messages.EquipmentListed);
        }

        public IDataResult<List<EquipmentDetailsDto>> GetEquipmentDetailsById(int id)
        {
            return new SuccessDataResult<List<EquipmentDetailsDto>>(_equipmentDal.GetEquipmentDetails(e=>e.ClinicId==id), Messages.EquipmentListed);
        }

        [ValidationAspect(typeof(EquipmentValidator))]
        public IResult Update(Equipment equipment)
        {
            _equipmentDal.Update(equipment);
            return new SuccesResult(Messages.EquipmentUpdated);
        }
    }
}