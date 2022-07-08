using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository.OrderRepository
{
    public class OrderRepository
    {
        public Order AddOrder(Order order) => OrderDAO.GetOrderDao.AddOrder(order);

        public void DeleteByMember(int memberId) => OrderDAO.GetOrderDao.DeleteByMember(memberId);
        public void DeleteOrder(int orderId) => OrderDAO.GetOrderDao.DeleteOrder(orderId);

        public IEnumerable<Order> GetAllOrder() => OrderDAO.GetOrderDao.GetAllOrder();

        public IEnumerable<Order> GetAllOrderFilterByDate(DateTime? startDate, DateTime? endDate) => OrderDAO.GetOrderDao.GetAllOrderFilterByDate(startDate, endDate);
    }
}
