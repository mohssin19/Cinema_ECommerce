using Cinema_ECommerce.Data.Base;
using Cinema_ECommerce.Models;

namespace Cinema_ECommerce.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {

        }
    }
}
