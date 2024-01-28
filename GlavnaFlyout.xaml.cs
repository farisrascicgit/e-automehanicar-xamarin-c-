using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projekat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlavnaFlyout : ContentPage
    {
        public ListView ListView;

        public GlavnaFlyout()
        {
            InitializeComponent();

            BindingContext = new GlavnaFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class GlavnaFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<GlavnaFlyoutMenuItem> MenuItems { get; set; }

            public GlavnaFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<GlavnaFlyoutMenuItem>(new[]
                {
                    
                    new GlavnaFlyoutMenuItem { Id = 0, Title = "Prijava servisa", TargetType=typeof(Page1) },
                    new GlavnaFlyoutMenuItem { Id = 0, Title = "Automehaničari", TargetType=typeof(Page2) },
                    new GlavnaFlyoutMenuItem { Id = 0, Title = "Usluge", TargetType=typeof(Page3) },


                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}