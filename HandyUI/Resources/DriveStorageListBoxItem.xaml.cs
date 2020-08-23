using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HandyUI.Resources
{
    /// <summary>
    /// Interaction logic for DriveStorageListBoxItem.xaml
    /// </summary>
    public partial class DriveStorageListBoxItem : UserControl
    {
        public DriveStorageListBoxItem()
        {
            InitializeComponent();
        }

        public Geometry FileThumb
        {
            get { return (Geometry)GetValue(FileThumbProperty); }
            set { SetValue(FileThumbProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FileThumb.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FileThumbProperty =
            DependencyProperty.Register("FileThumb", typeof(Geometry), typeof(DriveStorageListBoxItem));

    }
}
