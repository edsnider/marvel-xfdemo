using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MarvelDemo.Models;

namespace MarvelDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        ObservableCollection<Character> _characters;
        public ObservableCollection<Character> Characters
        {
            get { return _characters; }
            set
            {
                _characters = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
        }

        public async Task Init()
        {
            await LoadCharacters();
        }

        async Task LoadCharacters()
        {
            Characters = new ObservableCollection<Character>();

            Characters.Add(new Character { Id = 1009368, Name = "Iron Man", IconPath = "ironman_52.png", SeriesId = 2029 });
            Characters.Add(new Character { Id = 1009220, Name = "Captain America", IconPath = "captainamerica_52.png", SeriesId = 1996 });
            Characters.Add(new Character { Id = 1009664, Name = "Thor", IconPath = "thor_52.png", SeriesId = 2083 });

            await Task.FromResult(true);
        }
    }
}
