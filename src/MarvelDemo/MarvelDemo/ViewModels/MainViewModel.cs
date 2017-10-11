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

        public void Init()
        {
            LoadCharacters();
        }

        void LoadCharacters()
        {
            Characters = new ObservableCollection<Character>();
            
            // Hard-coded list of Characters instead of pulling from the API so we can get just the specific Avengers we want to display:
            Characters.Add(new Character
            {
                Id = 1009368,
                Name = "Iron Man",
                IconPath = "ironman_52.png",
                SeriesId = 2029,
                Thumbnail =
                    new Image {Path = "http://i.annihil.us/u/prod/marvel/i/mg/9/c0/527bb7b37ff55/standard_medium", Extension = "jpg"}
            });
            Characters.Add(new Character
            {
                Id = 1009220,
                Name = "Captain America",
                IconPath = "captainamerica_52.png",
                SeriesId = 1996,
                Thumbnail =
                    new Image {Path = "http://i.annihil.us/u/prod/marvel/i/mg/3/50/537ba56d31087/standard_medium", Extension = "jpg"}
            });
            Characters.Add(new Character
            {
                Id = 1009664,
                Name = "Thor",
                IconPath = "thor_52.png",
                SeriesId = 2083,
                Thumbnail =
                    new Image {Path = "http://i.annihil.us/u/prod/marvel/i/mg/d/d0/5269657a74350/standard_medium", Extension = "jpg"}
            });
        }
    }
}
