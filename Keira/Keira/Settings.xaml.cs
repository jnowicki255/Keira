using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Keira
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    { 
        public Settings()
        {
            InitializeComponent();
        }

        private void TextCellHostname_Tapped(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new ViewSettingsHostname());
        }

        private void TextCellPort_Tapped(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new ViewSettingsPort());
        }

        private void TextCellTopic_Tapped(object sender, EventArgs e)
        {

        }

        private void TextCellUID_Tapped(object sender, EventArgs e)
        {

        }
    }
}