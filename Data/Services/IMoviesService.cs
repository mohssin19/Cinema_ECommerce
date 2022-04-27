using Cinema_ECommerce.Data.Base;
using Cinema_ECommerce.Data.ViewModels;
using Cinema_ECommerce.Models;
using System.Threading.Tasks;

namespace Cinema_ECommerce.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
    }
}
