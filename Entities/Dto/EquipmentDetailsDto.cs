using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class EquipmentDetailsDto : IDto
    {
        public int EquipmentId { get; set; }
        public string ClinicName { get; set; }
        public int ClinicId { get; set; }
        public string EquipmentName { get; set; }
        public DateTime? ProcurementDate { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UsageRate { get; set; }
    }
}
