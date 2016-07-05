using MarvelDemo.Models;
using MarvelDemo.ViewModels;
using Xamarin.Forms;

namespace MarvelDemo.Views
{
    public partial class MainView : ContentPage
    {
        MainViewModel Vm => BindingContext as MainViewModel;

        public MainView()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Vm.Init();
        }

        private void CharactersListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var character = e.SelectedItem as Character;
            Navigation.PushAsync(new CharacterView(character));
        }
    }
}
