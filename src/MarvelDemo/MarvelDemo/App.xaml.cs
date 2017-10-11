using MarvelDemo.Views;
using Xamarin.Forms;

namespace MarvelDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var tabs = new TabbedPage();
            var mainPage = new NavigationPage(new MainView()) {Icon = "Avengers.png", Title = "Avengers"};
            var aboutPage = new NavigationPage(new AboutView()) {Icon = "Info.png", Title = "About"};

            tabs.Children.Add(mainPage);
            tabs.Children.Add(aboutPage);

            MainPage = tabs;
        }
    }
}
