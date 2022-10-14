using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Module.Attributes
{
    public class ValidateRadioButton: ValidationAttribute,IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-radiobutton", ErrorMessage);
        }
        public override bool IsValid(object? value)
        {
            return (bool)value;
        }
    }
}
