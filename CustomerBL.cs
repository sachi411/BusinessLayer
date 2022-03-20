using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.Console;
using static System.Convert;
using System.Configuration;
using BusinessObject;
using DataAccessLayer;
namespace BusinessLayer
{
    public class CustomerBL
    {
        public int SaveCustomerBL(Customer objBL)
        {
            try
            {
                CustomerDAL obj = new CustomerDAL();
                return obj.AddCustomerDetails(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int DeleteCustomerBL(Customer objBL)
        {
            try
            {
                CustomerDAL obj = new CustomerDAL();
                return obj.DeleteCustomerDetails(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int UpdateCustomerFirstNameBL(Customer objBL)
        {
            try
            {
                CustomerDAL obj = new CustomerDAL();
                return obj.UpdateCustomerFirstName(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int UpdateCustomerMiddleNameBL(Customer objBL)
        {
            try
            {
                CustomerDAL obj = new CustomerDAL();
                return obj.UpdateCustomerMiddleName(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int UpdateCustomerLastNameBL(Customer objBL)
        {
            try
            {
                CustomerDAL obj = new CustomerDAL();
                return obj.UpdateCustomerLastName(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int UpdateCustomerPhoneBL(Customer objBL)
        {
            try
            {
                CustomerDAL obj = new CustomerDAL();
                return obj.UpdateCustomerPhone(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int UpdateCustomerAddressBL(Customer objBL)
        {
            try
            {
                CustomerDAL obj = new CustomerDAL();
                return obj.UpdateCustomerAddress(objBL);

            }
            catch
            {
                throw;
            }
        }
        public int UpdateCustomerEmailBL(Customer objBL)
        {
            try
            {
                CustomerDAL obj = new CustomerDAL();
                return obj.UpdateCustomerEmail(objBL);

            }
            catch
            {
                throw;
            }
        }
        public DataSet FetchAllCustomerBL()
        {
            CustomerDAL obj = new CustomerDAL();
                return obj.ShowCustomerDetails();

        }
        public DataSet FetchSpecificCustomerByIDBL(Customer objBL)
        {
            CustomerDAL obj = new CustomerDAL();
            return obj.ShowSpecificCustomerDetailsByID(objBL);

        }
        public DataSet FetchSpecificCustomerByPhoneBL(Customer objBL)
        {
            CustomerDAL obj = new CustomerDAL();
            return obj.ShowSpecificCustomerDetailsByPhone(objBL);

        }
    }
}