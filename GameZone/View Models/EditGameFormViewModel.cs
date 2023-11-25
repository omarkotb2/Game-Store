using GameZone.Attributes;

namespace GameZone.View_Models
{
    public class EditGameFormViewModel:GameFormViewModel
    {
        public int Id {  get; set; }
        public string? CurrentCover { get; set; }

        [AllowedExtension(FileSettings.AllowedExtension)
            , MaxFileSize(FileSettings.MaxFileSizeInBytes)]

        public IFormFile? Cover { get; set; } = default!;

    }
}
