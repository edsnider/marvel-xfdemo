using System;
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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // HACK: Should happen in a navigation service
            Vm.Init(_character);
        }

        private void ComicsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var comic = e.SelectedItem as Comic;
            Navigation.PushModalAsync(new ComicView(comic));
        }

        private async void Order_OnClicked(object sender, EventArgs e)
        {
            var sort = await DisplayActionSheet("Order comics by", "Cancel", null, "Issue #", "Title");

            Vm.OrderComicsBy = sort == "Title" ? "title" : "issueNumber";
            Vm.LoadComicsCommand.Execute(null);
        }
    }
}
