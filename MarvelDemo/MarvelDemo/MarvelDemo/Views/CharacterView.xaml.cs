using MarvelDemo.Models;
using MarvelDemo.Services;
using MarvelDemo.ViewModels;
using Xamarin.Forms;

namespace MarvelDemo.Views
{
    public partial class CharacterView
    {
        CharacterViewModel Vm => BindingContext as CharacterViewModel;
        Character _character;

        public CharacterView(Character character)
        {
            InitializeComponent();

            _character = character;

            // TODO: IoC
            var hashService = DependencyService.Get<IHashService>();
            var dataService = new MarvelDataService(hashService);
            
            BindingContext = new CharacterViewModel(dataService);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Vm.Init(_character);
        }

        private void ComicsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var comic = e.SelectedItem as Comic;
            if (comic != null)
                DisplayAlert("Issue # " + comic.IssueNumber, comic.Title, "OK");

            ComicsListView.SelectedItem = null; // Force item unselect
        }
    }
}
