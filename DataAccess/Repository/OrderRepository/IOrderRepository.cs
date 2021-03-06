using BusinessObject;

namespace DataAccess.Repository.OrderRepository
{
    public interface IOrderRepository
    {
        public Order AddOrder(Order order);
        public IEnumerable<Order> GetAllOrder();
        public IEnumerable<Order> GetAllOrderFilterByDate(DateTime? startDate, DateTime? endDate);
        public void DeleteOrder(int orderId);
        public void DeleteByMember(int memberId);
    }
}
