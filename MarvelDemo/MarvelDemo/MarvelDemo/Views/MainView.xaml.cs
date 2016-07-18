using MarvelDemo.Models;
using MarvelDemo.ViewModels;
using Xamarin.Forms;

namespace MarvelDemo.Views
{
    public partial class MainView
    {
        MainViewModel Vm => BindingContext as MainViewModel;

        public MainView()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Vm.Init();
        }

        private void CharactersListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var character = e.SelectedItem as Character;
            Navigation.PushAsync(new CharacterView(character));
        }
    }
}
