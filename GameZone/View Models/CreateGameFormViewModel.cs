

using GameZone.Attributes;
using System.Runtime.CompilerServices;

namespace GameZone.View_Models
{
    public class CreateGameFormViewModel:GameFormViewModel
    {


        [AllowedExtension(FileSettings.AllowedExtension)
            ,MaxFileSize(FileSettings.MaxFileSizeInBytes)]

        public IFormFile Cover { get; set; } = default!;


    }
}
