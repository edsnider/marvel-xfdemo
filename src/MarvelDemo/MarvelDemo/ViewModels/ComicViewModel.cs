using System;
using System.Threading.Tasks;
using MarvelDemo.Models;

namespace MarvelDemo.ViewModels
{
    public class ComicViewModel : BaseViewModel
    {
        Comic _comic;
        public Comic Comic
        {
            get { return _comic; }
            set
            {
                _comic = value;
                OnPropertyChanged();
            }
        }

        public ComicViewModel()
        {
        }

        public void Init(Comic comic)
        {
            if (comic == null)
                throw new ArgumentNullException(nameof(comic), "ComicViewModel requires a non-null Comic object to initialize.");

            Comic = comic;
        }
    }
}
