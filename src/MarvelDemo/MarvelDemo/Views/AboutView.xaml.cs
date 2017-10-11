using System;
using Xamarin.Forms;

namespace MarvelDemo.Views
{
    public partial class AboutView
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void MarvelLinkButton_OnClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://developer.marvel.com"));
        }

        private void Icons8LinkButton_OnClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.icons8.com"));
        }
    }
}
