using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelDemo.Models;
using MarvelDemo.Services;

namespace MarvelDemo.ViewModels
{
    public class CharacterViewModel : BaseViewModel
    {
        readonly IMarvelDataService _dataService;

        Character _character;
        public Character Character
        {
            get { return _character; }
            set
            {
                _character = value;
                OnPropertyChanged();
            }
        }

        ObservableCollection<Comic> _comics;
        public ObservableCollection<Comic> Comics
        {
            get { return _comics; }
            set
            {
                _comics = value;
                OnPropertyChanged();
            }
        }

        public CharacterViewModel(IMarvelDataService dataService)
        {
            _dataService = dataService;

            Comics = new ObservableCollection<Comic>();
        }

        public async Task Init(Character character)
        {
            if (character == null)
                throw new ArgumentNullException(nameof(character), "CharacterViewModel requires a non-null Character object to initialize.");

            Character = character;
            await LoadComics(Character.SeriesId);
        }

        async Task LoadComics(int seriesId)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Comics.Clear();

                var comics = await _dataService.GetComicsBySeries(seriesId);

                foreach (var c in comics)
                    Comics.Add(c);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
