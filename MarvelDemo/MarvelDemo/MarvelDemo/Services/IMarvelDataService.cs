using System.Collections.Generic;
using System.Threading.Tasks;
using MarvelDemo.Models;

namespace MarvelDemo.Services
{
    public interface IMarvelDataService
    {
        Task<IEnumerable<Comic>> GetComicsBySeries(int seriesId, string orderBy = null);
    }
}
