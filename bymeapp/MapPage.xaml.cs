using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bymeapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
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