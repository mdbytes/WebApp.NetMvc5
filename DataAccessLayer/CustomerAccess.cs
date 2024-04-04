using DataAccessInterface;
using DataObjectLayer;
using MVCWebApp.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerAccess : ICustomerAccess
    {
        public bool AddCustomer(CustomerVM customer)
        {
            var conn = Database.GetConnection();

            var cmdText = "sp_insert_customer";

            var cmd = new SqlCommand(cmdText, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 40);
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 40);
            cmd.Parameters.Add("@City", SqlDbType.NVarChar, 40);
            cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 40);
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20);

            cmd.Parameters["@FirstName"].Value = customer.FirstName;
            cmd.Parameters["@LastName"].Value = customer.LastName;
            cmd.Parameters["@City"].Value = customer.City;
            cmd.Parameters["@Country"].Value = customer.Country;
            cmd.Parameters["@Phone"].Value = customer.Phone;

            var result = 0;

            try
            {
                conn.Open();

                result = (int)cmd.ExecuteNonQuery();

                if (result != -1)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
    

        public bool DeleteCustomer(int id)
        {
            var conn = Database.GetConnection();

            var cmdText = "sp_delete_customer_by_id";

            var cmd = new SqlCommand(cmdText, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int);
            
            cmd.Parameters["@Id"].Value = id;
            
            var result = 0;

            try
            {
                conn.Open();

                result = (int)cmd.ExecuteNonQuery();

                if (result != -1)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
    

        public CustomerVM GetCustomerById(int id)
        {
            // Make return variable if appropriate
            CustomerVM customer = null;

            // connection
            var conn = Database.GetConnection();

            // command text
            var cmdText = "sp_select_customer_by_id";

            // command
            var cmd = new SqlCommand(cmdText, conn);

            // command type
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int);

            cmd.Parameters["@Id"].Value = id;

            try
            {
                conn.Open();

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        customer = new CustomerVM();
                        customer.Id = reader.GetInt32(0);
                        customer.FirstName = reader.GetString(1);
                        customer.LastName = reader.GetString(2);
                        customer.City = reader.GetString(3);
                        customer.Country = reader.GetString(4);
                        customer.Phone = reader.GetString(5);

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return customer;
        }

        public List<CustomerVM> GetCustomers()
        {
            // Make return variable if appropriate
            List<CustomerVM> customers = new List<CustomerVM>();

            // connection
            var conn = Database.GetConnection();

            // command text
            var cmdText = "sp_select_customer_all";

            // command
            var cmd = new SqlCommand(cmdText, conn);

            // command type
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CustomerVM customer = new CustomerVM()
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            City = reader.GetString(3),
                            Country = reader.GetString(4),
                            Phone = reader.GetString(5),
                           
                    };
                        customers.Add(customer);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return customers;
        }

        public bool UpdateCustomer(CustomerVM customer)
        {
            var conn = Database.GetConnection();

            var cmdText = "sp_update_customer_by_id";

            var cmd = new SqlCommand(cmdText, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 40);
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 40);
            cmd.Parameters.Add("@City", SqlDbType.NVarChar, 40);
            cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 40);
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20);

            cmd.Parameters["@Id"].Value= customer.Id;
            cmd.Parameters["@FirstName"].Value = customer.FirstName;
            cmd.Parameters["@LastName"].Value = customer.LastName;
            cmd.Parameters["@City"].Value = customer.City;
            cmd.Parameters["@Country"].Value= customer.Country;
            cmd.Parameters["@Phone"].Value = customer.Phone;

            var result = 0;

            try
            {
                conn.Open();

                result = (int)cmd.ExecuteNonQuery();

                if (result != -1)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
    }
}

