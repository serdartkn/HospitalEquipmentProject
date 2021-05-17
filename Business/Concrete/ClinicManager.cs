using Business.Abstract;
using Business.Constants;
using Core.Result.Abstract;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Aspect.Autofact.Validation;
using Business.ValidationRules.FluentValidation;

namespace Business.Concrete
{
    //DataAccess katmanına erişim sağlandı.

    public class ClinicManager : IClinicService
    {
        IClinicDal _clinicDal;

        public ClinicManager(IClinicDal clinicDal) {
            _clinicDal = clinicDal;
        }

        [ValidationAspect(typeof(ClinicValidator))]
        public IResult Add(Clinic clinic)
        {
            _clinicDal.Add(clinic);
            return new SuccesResult(Messages.ClinicAdded);
        }

        public IResult Delete(Clinic clinic)
        {
            _clinicDal.Delete(clinic);
            return new SuccesResult(Messages.ClinicDeleted);
        }

        public IDataResult<List<Clinic>> GetAll()
        {
            return new SuccessDataResult<List<Clinic>>(_clinicDal.GetAll(), Messages.ClinicsListed) ;
        }

        public IDataResult<Clinic> GetById(int Id)
        {
            return new SuccessDataResult<Clinic>(_clinicDal.Get(c => c.Id == Id), Messages.ClinicListed); ;
        }

        [ValidationAspect(typeof(ClinicValidator))]
        public IResult Update(Clinic clinic)
        {
            _clinicDal.Update(clinic);
            return new SuccesResult(Messages.ClinicUpdated);
        }
    }
}