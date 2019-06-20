using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Mqtt;
using Rg.Plugins.Popup.Services;

namespace Keira
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private string myMessageString;
        public string MyMessageString
        {
            get { return myMessageString; }
            set
            {
                myMessageString = value;
                OnPropertyChanged(nameof(MyMessageString)); // Notify that there was a change on this property
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            MQTTConnection();

        }

        async public void MQTTConnection()
        {
            try
            {
                var configuration = new MqttConfiguration { Port = 1883 };
                var client = await MqttClient.CreateAsync("test.mosquitto.org", configuration);
                await client.ConnectAsync(new MqttClientCredentials("AndroidBpp"), null, true);

                await client.SubscribeAsync("dzaq", MqttQualityOfService.AtLeastOnce);
                client.MessageStream.Subscribe(msg =>
                {
                    MyMessageString = System.Text.Encoding.UTF8.GetString(msg.Payload);
                });
            }
            catch
            {
            }
            
        }

        private void ToolbarItemSettings_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Settings());
        }
    }
}
