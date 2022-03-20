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
    public class ProductBL
    {
        public int SaveProductBL(Product objBL)
        {
            try
            {
                ProductDAL obj = new ProductDAL();
                return obj.AddProductDetails(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int DeleteProductBL(Product objBL)
        {
            try
            {
                ProductDAL obj = new ProductDAL();
                return obj.DeleteProductDetails(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int DeleteProductWithNoPreferenceBL()
        {
            try
            {
                ProductDAL obj = new ProductDAL();
                return obj.DeleteProductWithNoPreference();

            }
            catch
            {
                throw;
            }
        }
        public int UpdateProductPriceBL(Product objBL)
        {
            try
            {
                ProductDAL obj = new ProductDAL();
                return obj.UpdateProductPrice(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int UpdateProductQuantityBL(Product objBL)
        {
            try
            {
                ProductDAL obj = new ProductDAL();
                return obj.UpdateProductQuantity(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int UpdateProductQuan_in_handBL(Product objBL,OrderLine obj)
        {
            try { 
            
                ProductDAL pro = new ProductDAL();
                return pro.UpdateProductQuan_in_hand(objBL,obj);

            }
            catch
            {
                throw;
            }
        }
        public DataSet FetchAllProductBL()
        {
            ProductDAL obj = new ProductDAL();
            return obj.ShowProductDetails();

        }
        public DataSet FetchSpecificProductByIDBL(Product objBL)
        {
            ProductDAL obj = new ProductDAL();
            return obj.ShowSpecificProductDetailsByID(objBL);

        }
    }
}
