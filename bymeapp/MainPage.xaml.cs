using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms.OpenWhatsApp;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bymeapp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void Map_Clicked(object sender, EventArgs e)
        {
            MapPage myHomePage = new MapPage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Book_Clicked(object sender, EventArgs e)
        {
            BookPage myHomePage = new BookPage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Profile_Clicked(object sender, EventArgs e)
        {
            ProfilePage myHomePage = new ProfilePage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Main_Clicked(object sender, EventArgs e)
        {
            MainPage myHomePage = new MainPage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        private async void OpenWhatsApp(object sender, EventArgs e)
        {
            try
            {
                Chat.Open("+593996691260", "Me interesa conocer los servicios de ByMe");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

    }
    
}
