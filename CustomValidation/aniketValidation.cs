using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CustomValidation
{
    public class aniketValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            if (value != null)
            {
                string msg = value.ToString();
                if (msg.Contains("Aniket"))
                {
                    return ValidationResult.Success;
                }                
            }
            ErrorMessage = ErrorMessage ?? validationContext.DisplayName + " Field must contain Aniket";
            // ?? operator use for checking null value or not

            return new ValidationResult(ErrorMessage);
        }
    }
}