using LocateTrack.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LocateTrack
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public static bool IsUserLoggedIn;

        public AppShell()
        {
            InitializeComponent();
        }

        protected override void OnNavigating(ShellNavigatingEventArgs args)
        {
            base.OnNavigating(args);

            if (!IsUserLoggedIn)
            {
                Navigation.PushModalAsync(new DecisionPage());
            }

        }
    }
}
