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
    }
}
