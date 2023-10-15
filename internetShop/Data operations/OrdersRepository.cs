
using internetShop.Data;
using internetShop.Interfaces;
using internetShop.Models;

namespace internetShop.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent _content;
        private readonly ShopCart _shopCart;

        public OrdersRepository(AppDBContent content, ShopCart shopCart)
        {
            _content = content;
            _shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime= DateTime.Now;
            _content.Order.Add(order);

            var items = _shopCart.listShopItems;

            foreach (var element in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarID = element.car.id,
                    orderID = order.id,
                    price = element.car.price
                };
                _content.OrderDetail.Add(orderDetail);
            }
            _content.SaveChanges();
        }
    }
}
