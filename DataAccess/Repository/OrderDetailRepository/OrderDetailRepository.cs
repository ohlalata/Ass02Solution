using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository.OrderDetailRepo
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.GetOrderDetailDao.AddOrderDetail(orderDetail);

        public void DeleteByProduct(int productId) => OrderDetailDAO.GetOrderDetailDao.DeleteOrderDetailsByProductId(productId);

        public void DeleteOrderDetails(int orderId) => OrderDetailDAO.GetOrderDetailDao.DeleteOrderDetails(orderId);

        public IEnumerable<OrderDetail> GetOrderDetails(int orderId) => OrderDetailDAO.GetOrderDetailDao.GetListOrderDetailsByOrderId(orderId);

        public decimal GetOrderTotal(int orderId) => OrderDetailDAO.GetOrderDetailDao.GetOrderTotal(orderId);
    }
}