using System;
using MarvelDemo.Models;
using MarvelDemo.ViewModels;

namespace MarvelDemo.Views
{
    public partial class ComicView
    {
        ComicViewModel Vm => BindingContext as ComicViewModel;
        Comic _comic;

        public ComicView(Comic comic)
        {
            InitializeComponent();

            _comic = comic;

            BindingContext = new ComicViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Vm.Init(_comic);
        }

        private void CloseButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}
