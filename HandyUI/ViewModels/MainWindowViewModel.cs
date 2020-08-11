using HandyControl.Controls;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Windows.Controls;

namespace HandyUI.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        IRegionManager region;
        public DelegateCommand<SelectionChangedEventArgs> SwitchItemCommand { get; set; }

        private string _title = "HandyUI Examples";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            region = regionManager;
            SwitchItemCommand = new DelegateCommand<SelectionChangedEventArgs>(OnSwitchItem);
        }

        private void OnSwitchItem(SelectionChangedEventArgs e)
        {
            if (e.AddedItems[0] is ListBoxItem item)
            {
                if (item.Tag != null)
                {
                    region.RequestNavigate("ContentRegion", item.Tag.ToString());
                }
                else
                {
                    region.RequestNavigate("ContentRegion", "Overview");
                }
            }
        }
    }
}
