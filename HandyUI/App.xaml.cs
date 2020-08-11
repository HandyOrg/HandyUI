using HandyControl.Data;
using HandyControl.Themes;
using HandyControl.Tools;
using System.Windows;
using System;
using Prism.Ioc;
using HandyUI.Views;
using Prism.Regions;

namespace HandyUI
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Container.Resolve<IRegionManager>().RegisterViewWithRegion("ContentRegion", typeof(Overview));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<BasicKanban>();
        }
        internal void UpdateSkin(SkinType skin)
        {
            SharedResourceDictionary.SharedDictionaries.Clear();
            Resources.MergedDictionaries.Add(ResourceHelper.GetSkin(skin));
            Resources.MergedDictionaries.Add(new ResourceDictionary
            {
                Source = new Uri("pack://application:,,,/HandyControl;component/Themes/Theme.xaml")
            });
            Current.MainWindow?.OnApplyTemplate();
        }
    }
}
