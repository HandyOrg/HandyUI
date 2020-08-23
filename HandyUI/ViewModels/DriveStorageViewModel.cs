using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace HandyUI.ViewModels
{
    public class DriveStorageViewModel : BindableBase
    {
        private ObservableCollection<GetFileDetails> _getFileDetails = new ObservableCollection<GetFileDetails>();
        public ObservableCollection<GetFileDetails> getFileDetails
        {
            get { return _getFileDetails; }
            set { SetProperty(ref _getFileDetails, value); }
        }
        public DriveStorageViewModel()
        {
            getFileDetails.Add(new GetFileDetails { FileThumb = (Geometry)dict["PdfGeometry"], FileName = "File 1", Fill = "Red", FileProgram = "Adobe Acrobat", ModifiedOn = "12.01.2020", FileType = ".pdf" });
            getFileDetails.Add(new GetFileDetails { FileThumb = (Geometry)dict["PngGeometry"], FileName = "File 2", Fill = "Green", FileProgram = "Photo Viewer", ModifiedOn = "18.02.2020", FileType = ".png" });
            getFileDetails.Add(new GetFileDetails { FileThumb = (Geometry)dict["txtGeometry"], FileName = "File 3", Fill = "CadetBlue", FileProgram = "Notepad", ModifiedOn = "15.07.2020", FileType = ".txt" });
            getFileDetails.Add(new GetFileDetails { FileThumb = (Geometry)dict["PdfGeometry"], FileName = "File 4", Fill = "Green", FileProgram = "Adobe Acrobat", ModifiedOn = "22.07.2020", FileType = ".pdf" });

        }
        ResourceDictionary dict = Application.LoadComponent(new Uri("HandyUI;component/Resources/Geometries.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;



        public class GetFileDetails
        {
            public Geometry FileThumb { get; set; }
            public string Fill { get; set; }
            public string FileName { get; set; }
            public string FileProgram { get; set; }
            public string ModifiedOn { get; set; }
            public string FileType { get; set; }
        }
    }
}
