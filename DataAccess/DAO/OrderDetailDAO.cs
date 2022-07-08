using BusinessObject;

namespace DataAccess.DAO
{
    public class OrderDetailDAO
    {
        // Using Singleton Pattern
        private static OrderDetailDAO _instance;
        private static readonly object InstanceLock = new object();

        public static OrderDetailDAO GetOrderDetailDao
        {
            get
            {
                lock (InstanceLock)
                {
                    return _instance ??= new OrderDetailDAO();
                }
            }
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                var context = new SalesManagementContext();
                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public decimal GetOrderTotal(int orderId)
        {
            decimal orderTotal = 0;

            try
            {
                var context = new SalesManagementContext();
                IEnumerable<OrderDetail> orderDetails = context.OrderDetails.Where(od => od.OrderId == orderId);
                foreach (var orderDetail in orderDetails)
                {
                    orderTotal += orderDetail.UnitPrice * orderDetail.Quantity;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Math.Round(orderTotal, 2);
        }

        public IEnumerable<OrderDetail> GetListOrderDetailsByOrderId(int orderId)
        {
            try
            {
                return new SalesManagementContext().OrderDetails.Where(od => od.OrderId == orderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteOrderDetails(int orderId)
        {
            try
            {
                IEnumerable<OrderDetail> orderDetails = GetListOrderDetailsByOrderId(orderId);
                var context = new SalesManagementContext();
                foreach (var orderDetail in orderDetails)
                {
                    context.Remove(orderDetail);
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteOrderDetailsByProductId(int productId)
        {
            try
            {
                var context = new SalesManagementContext();
                IEnumerable<OrderDetail> orderDetails = context.OrderDetails.Where(od => od.ProductId == productId);
                foreach (var orderDetail in orderDetails)
                {
                    context.Remove(orderDetail);
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}