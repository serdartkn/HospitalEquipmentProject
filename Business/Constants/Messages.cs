using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Result yapısı için olası mesajlar oluşturuldu.
        public static string ClinicAdded = "Clinic Added";
        public static string ClinicUpdated = "Clinic Updated";
        public static string ClinicDeleted = "Clinic Deleted";
        public static string ClinicsListed = "Clinics Listed";
        public static string ClinicListed = "Clinic Listed";
        public static string ClinicNameInvalid = "Clinic Name Invalid";


        public static string EquipmentAdded = "Equipment Added";
        public static string EquipmentUpdated = "Equipment Updated";
        public static string EquipmentDeleted = "Equipment Deleted";
        public static string EquipmentsListed = "Equipments Listed";
        public static string EquipmentListed = "Equipment Listed";
        public static string EquipmentNameInvalid = "Equipment Name Invalid";


        public static string NotEmpty = "This Field Should Not Be Left Blank";
        public static string MinLength2 = "This Field Must Contain A Minimum Of 2 Characters";
        public static string GreaterThan1 = "1 Or A Larger Value Must Be Entered In This Field";
        public static string GreaterThan001 = "0.01 Or A Larger Value Must Be Entered In This Field";
        public static string Range0100 = "A Value Between 0.00 And 100.0 Must Be Entered In This Field";
    }
}