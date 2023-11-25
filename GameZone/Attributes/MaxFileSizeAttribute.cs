namespace GameZone.Attributes
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;

        }
        protected override ValidationResult? IsValid
         (object? value, ValidationContext validationContext)
        {
            var File = value as IFormFile;
            if (File is not null)
            {
              
                if (File.Length > _maxFileSize)
                {
                    return new ValidationResult($"Maximum allowed Size is {_maxFileSize} bytes !");

                }

            }
            return ValidationResult.Success;
        }
    }
}
