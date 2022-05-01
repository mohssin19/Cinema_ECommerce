using Cinema_ECommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema_ECommerce.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}
