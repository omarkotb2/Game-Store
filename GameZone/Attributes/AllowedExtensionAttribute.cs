namespace GameZone.Attributes
{
    public class AllowedExtensionAttribute : ValidationAttribute
    {
        private readonly  string _allowedExtension;
        public AllowedExtensionAttribute(string allowedExtension)
        {
            _allowedExtension = allowedExtension;
                
        }

        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            var File = value as IFormFile;
            if (File is not null)
            {
                var extension = Path.GetExtension(File.FileName);
                var isAllowed = _allowedExtension.Split(",").Contains(extension,StringComparer.OrdinalIgnoreCase);
                if (!isAllowed)
                {
                    return new ValidationResult($"only{_allowedExtension} are allowed! ");

                }

            }
            return ValidationResult.Success;
        }
    }
}
