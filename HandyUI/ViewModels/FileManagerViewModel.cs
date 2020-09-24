using HandyUI.Models;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace HandyUI.ViewModels
{
    public class FileManagerViewModel : BindableBase
    {
        ResourceDictionary dict = Application.LoadComponent(new Uri("HandyUI;component/Resources/Geometries.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;

        private ObservableCollection<FileManagerModel> _data = new ObservableCollection<FileManagerModel>();
        public ObservableCollection<FileManagerModel> data
        {
            get { return _data; }
            set { SetProperty(ref _data, value); }
        }

        public FileManagerViewModel()
        {
            data.Add(new FileManagerModel { Image = (DrawingImage)dict["folder"], Name = "Collection 1", FileItem = "21 Items", LastModified = "Jan 3, 2019", FileSize = "15 Gb" });
            data.Add(new FileManagerModel { Image = (DrawingImage)dict["folder"], Name = "Collection 2", FileItem = "40 Items", LastModified = "Jan 10, 2020", FileSize = "45 Gb" });
            data.Add(new FileManagerModel { Image = (DrawingImage)dict["folder"], Name = "Collection 3", FileItem = "90 Items", LastModified = "Mar 10, 2020", FileSize = "82 Gb" });
            data.Add(new FileManagerModel { Image = (DrawingImage)dict["video"], Name = "File Manager UI Part-1 by Jd's Code Lab", FileItem = "1 Item", LastModified = "Jun 14, 2020", FileSize = "1 Gb" });
            data.Add(new FileManagerModel { Image = (DrawingImage)dict["video"], Name = "File Manager UI Part-2 by Jd's Code Lab", FileItem = "1 Item", LastModified = "Jun 17, 2020", FileSize = "4 Gb" });
            data.Add(new FileManagerModel { Image = (DrawingImage)dict["music"], Name = "Some music track", FileItem = "1 Items", LastModified = "March 19, 2019", FileSize = "5 Mb" });
        }
    }
}
