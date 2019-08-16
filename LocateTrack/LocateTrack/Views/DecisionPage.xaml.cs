using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocateTrack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DecisionPage : ContentPage
    {
        public DecisionPage()
        {
            InitializeComponent();
        }

        private async void Passenger_Tapped(object sender, EventArgs e)
        {
            await PassengerLayout.RelScaleTo(-0.1, 250);
            await PassengerLayout.RelScaleTo(0.1, 250);
            await Navigation.PushModalAsync( new Passenger.LoginPage());
        }

        private async void Pilot_Tapped(object sender, EventArgs e)
        {
            await PilotLayout.RelScaleTo(-0.1, 250);
            await PilotLayout.RelScaleTo(0.1, 250);
            await Navigation.PushModalAsync(new Pilot.LoginPage());
        }

        protected override bool OnBackButtonPressed()
        {
            return false;
        }
    }
}