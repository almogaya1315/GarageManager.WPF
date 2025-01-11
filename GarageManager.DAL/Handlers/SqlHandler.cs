using GarageManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.DAL.Handlers
{
    public class SqlHandler
    {
        private readonly string _connectionString;

        public SqlHandler()
        {
            _connectionString = "";
        }

        public List<CustomerEntity> GetCustomers()
        {
            var output = new List<CustomerEntity>();

            using (var con = new SqlConnection(_connectionString))
            {
                var command = con.CreateCommand();
                command.CommandText = "SELECT * FROM tbl_Customers";
                //command.Parameters.Add()
                command.ExecuteNonQuery();
                if (command.ExecuteReader().Read())
                {
                    var ds = new DataSet();
                    var da = new SqlDataAdapter(command);
                    da.Fill(ds);
                    var customer = new CustomerEntity(-1);
                    output.Add(customer);
                }
            }

            return output;
        }
    }
}
