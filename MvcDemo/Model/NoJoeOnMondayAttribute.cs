using System;

namespace Model
{
    public class NoJoeOnMondayAttribute: System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public NoJoeOnMondayAttribute()
        {
            ErrorMessage = "Joe can not book appointments on Monday";
        }
        public override bool IsValid(object value)
        {
            Appointment appt=value as Appointment;
            if (string.IsNullOrEmpty(appt?.ClientName))
            {
                return true;
            }
            return !(appt.ClientName == "Joe" && appt.Date.DayOfWeek == DayOfWeek.Monday);
        }
    }
}
