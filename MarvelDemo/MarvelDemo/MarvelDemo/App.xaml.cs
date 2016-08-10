using MarvelDemo.Views;
using Xamarin.Forms;

namespace MarvelDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new MainView());
        }
    }
}
