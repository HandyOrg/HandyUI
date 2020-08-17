using HandyUI.Models;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HandyUI.ViewModels
{
    public class MusicPlayerViewModel : BindableBase
    {
        private IList<CardModel> _datalist;
        public IList<CardModel> DataList
        {
            get { return _datalist; }
            set { SetProperty(ref _datalist, value); }
        }
        internal ObservableCollection<CardModel> GetCardDataList()
        {
            return new ObservableCollection<CardModel>
        {
            new CardModel
            {
                Header = "Atomic",
                Content = "/HandyUI;component/Resources/Album/1.jpg",
                Footer = "Stive Morgan"
            },
            new CardModel
            {
                Header = "Zinderlong",
                Content = "/HandyUI;component/Resources/Album/2.jpg",
                Footer = "Zonderling"
            },
            new CardModel
            {
                Header = "Busy Doin' Nothin'",
                Content = "/HandyUI;component/Resources/Album/3.jpg",
                Footer = "Ace Wilder"
            },
            new CardModel
            {
                Header = "Wrong",
                Content = "/HandyUI;component/Resources/Album/4.jpg",
                Footer = "Blaxy Girls"
            },
            new CardModel
            {
                Header = "The Lights",
                Content = "/HandyUI;component/Resources/Album/5.jpg",
                Footer = "Panda Eyes"
            },
            new CardModel
            {
                Header = "EA7-50-Cent Disco",
                Content = "/HandyUI;component/Resources/Album/6.jpg",
                Footer = "еяхат музыка"
            },
            new CardModel
            {
                Header = "Monsters",
                Content = "/HandyUI;component/Resources/Album/7.jpg",
                Footer = "Different Heaven"
            },
            new CardModel
            {
                Header = "Gangsta Walk",
                Content = "/HandyUI;component/Resources/Album/8.jpg",
                Footer = "Illusionize"
            },
            new CardModel
            {
                Header = "Won't Back Down",
                Content = "/HandyUI;component/Resources/Album/9.jpg",
                Footer = "Boehm"
            },
            new CardModel
            {
                Header = "Katchi",
                Content = "/HandyUI;component/Resources/Album/10.jpg",
                Footer = "Ofenbach"
            }
        };
        }
        public MusicPlayerViewModel()
        {
            DataList = GetCardDataList();
        }
    }
}
