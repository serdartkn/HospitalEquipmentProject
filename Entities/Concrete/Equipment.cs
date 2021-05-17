using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Equipment : IEntity
    {
        public int Id { get; set; }
        public int ClinicId { get; set; }
        public string Name { get; set; }
        public DateTime? ProcurementDate { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UsageRate { get; set; }

    }
}
