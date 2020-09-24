using System.Windows.Media;

namespace HandyUI.Models
{
    public class FileManagerModel
    {
        public DrawingImage Image { get; set; }
        public string Name { get; set; }
        public string FileItem { get; set; }
        public string LastModified { get; set; }
        public string FileSize { get; set; }
    }
}
