using Cinema_ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_ECommerce.Data.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly AppDbContext _appDbContext;

        public OrdersService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Order>> GetOrdersByUserIdAsync(string userId)
        {
            return await _appDbContext.Orders.Include(o => o.OrderItems).ThenInclude(o => o.Movie).Where(o => o.UserId == userId).ToListAsync();
        }

        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress
            };
            await _appDbContext.AddAsync(order);
            await _appDbContext.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    MovieId = item.Movie.Id,
                    OrderId = order.Id,
                    Price = item.Movie.Price
                };
                await _appDbContext.AddAsync(orderItem);
            }
            await _appDbContext.SaveChangesAsync();
        }
    }
}
