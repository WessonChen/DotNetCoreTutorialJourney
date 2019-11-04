using System.ComponentModel.DataAnnotations;

namespace DotNetCoreTutorialJourney.Utilities
{
    public class AGreaterThanBCAttribute : ValidationAttribute
    {
        private readonly string _b;
        private readonly string _c;

        public AGreaterThanBCAttribute(string b, string c)
        {
            _b = b;
            _c = c;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ErrorMessage = ErrorMessageString;

            var currentValue = value ?? 0;
            var comparingB = validationContext.ObjectType.GetProperty(_b);
            var comparingC = validationContext.ObjectType.GetProperty(_c);
            var comparisonValueB = comparingB.GetValue(validationContext.ObjectInstance) ?? 0;
            var comparisonValueC = comparingC.GetValue(validationContext.ObjectInstance) ?? 0;

            if ((int)currentValue != (int)comparisonValueB + (int)comparisonValueC)
                return new ValidationResult(ErrorMessage);
            return ValidationResult.Success;
        }
    }
}
