using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessObject;
using DataAccessLayer;

namespace BusinessLayer
{
    public class OrderLineBL
    {
        public int SaveOrderLineBL(OrderLine objBL)
        {
            try
            {
                OrderLineDAL obj = new OrderLineDAL();
                return obj.AddOrderLineDetails(objBL);

            }
            catch
            {
                throw;
            }
        }
        public DataSet FetchAllOrderLineBL()
        {
            OrderLineDAL obj = new OrderLineDAL();
            return obj.ShowOrderLineDetails();

        }
        public DataSet FetchOrderLinebyidBL(OrderLine obj1)
        {
            OrderLineDAL obj = new OrderLineDAL();
            return obj.ShowOrderLineDetailsbyid(obj1);

        }
        public int UpdateProductQuan_in_handBL(OrderLine obj)
        {
            try
            {

                OrderLineDAL pro = new OrderLineDAL();
                return pro.UpdateProductQuan_in_hand(obj);

            }
            catch
            {
                throw;
            }
        }
    }
}
