using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEquipmentDal : IEntityRepository<Equipment>
    {
        //Genel operasyonları Core katmanından aldım.
        List<EquipmentDetailsDto> GetEquipmentDetails(Expression<Func<EquipmentDetailsDto, bool>> filter = null);
    }
}