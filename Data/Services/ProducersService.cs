using Cinema_ECommerce.Data.Base;
using Cinema_ECommerce.Models;

namespace Cinema_ECommerce.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {

        }
    }
}
