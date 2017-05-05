using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //[NoJoeOnMonday]
    public class Appointment:IValidatableObject
    {
        /// <summary>
        /// 设置或获取客户名称
        /// </summary>
        public  string ClientName { set; get; }

        [DataType(dataType:DataType.Date)]
        public DateTime Date { set; get; }

        public bool TermsAccepted { set; get; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errorList=new List<ValidationResult>();
            if (string.IsNullOrEmpty(ClientName))
            {
                errorList.Add(new ValidationResult("Please enter your name"));
            }
            if (DateTime.Now>Date)
            {
                errorList.Add(new ValidationResult("Please enter a date in the future"));
            }
            if (errorList.Count == 0 && ClientName == "Joe" && Date.DayOfWeek == DayOfWeek.Monday)
            {
                errorList.Add(new ValidationResult("Joe cannot book appointments on Mondays"));
            }
            if (!TermsAccepted)
            {
                errorList.Add(new ValidationResult("You must accept the terms"));
            }
            return errorList;
        }
    }
}
