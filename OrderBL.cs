using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;
using System.Data;
namespace BusinessLayer
{
    public class OrderBL
    {
        public int SaveOrderBL(Order objBL)
        {
            try
            {
                OrderDAL obj = new OrderDAL();
                return obj.AddOrderDetails(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int DeleteOrderBL(Order objBL)
        {
            try
            {
                OrderDAL obj = new OrderDAL();
                return obj.DeleteOrderDetails(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int UpdateOrderAmountBL(Order objBL)
        {
            try
            {
                OrderDAL obj = new OrderDAL();
                return obj.UpdateOrderAmount(objBL);

            }
            catch
            {
                throw;
            }
        }
        public DataSet FetchAllOrderBL()
        {
            OrderDAL obj = new OrderDAL();
            return obj.ShowOrderDetails();

        }
        //public DataSet FetchOrderDetailAndUpdateStatusBL()
        //{
        //    OrderDAL obj = new OrderDAL();
        //    return obj.UpdateOrderDetailsbeforNew();

        //}
        public int UpdateStatusBL(Order ob)
        {
            OrderDAL obj = new OrderDAL();
            return obj.UpdateOrderDetailsbeforeNew(ob);

        }
    }
}
