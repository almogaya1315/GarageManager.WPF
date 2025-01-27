using GarageManager.Core.Entities;
using GarageManager.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.BL.Repositories
{
    public interface IRepository
    {
        public List<CarEntity> GetCars();
        public List<CustomerEntity> GetCustomers();

        public List<CarEntity> GetCars_EF();
    }

    public class RepositoryBase
    {
        private readonly string _connectionString;

        public RepositoryBase()
        {
            _connectionString = @"Data Source=DESKTOP-I9GEGTE\MSSQLSERVER1;Initial Catalog=LocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        }

        public SqlConnection OpenConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }

    public class GarageRepository : RepositoryBase, IRepository
    {
        private GarageContext _garageContext;


        public GarageRepository()
        {
            _garageContext = new GarageContext(new DbContextOptions<GarageContext>());
        }

        //public List<CustomerEntity> GetCustomers()
        //{
        //    var output = new List<CustomerEntity>();

        //    using (var con = new SqlConnection(_connectionString))
        //    {
        //        var command = con.CreateCommand();
        //        command.CommandText = "SELECT * FROM tbl_Customers";
        //        //command.Parameters.Add()
        //        command.ExecuteNonQuery();
        //        if (command.ExecuteReader().Read())
        //        {
        //            var ds = new DataSet();
        //            var da = new SqlDataAdapter(command);
        //            da.Fill(ds);
        //            var customer = new CustomerEntity(-1);
        //            output.Add(customer);
        //        }
        //    }

        //    return output;
        //}

        public List<CustomerEntity> GetCustomers()
        {
            using (var con = OpenConnection())
            {
                var result = new List<CustomerEntity>();

                try
                {
                    con.Open();
                    var commnd = con.CreateCommand();
                    commnd.CommandType = CommandType.StoredProcedure;
                    commnd.CommandText = "sp_GetCustomers";
                    var idParam = new SqlParameter("@Id", 3);
                    commnd.Parameters.Add(idParam);
                    var reader = commnd.ExecuteReader();

                    if (reader != null && reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var id = (int)reader["Id"];
                            var name = (string)reader["Name"];
                            var car = (int)reader["CarId"];
                            var newEntity = new CustomerEntity(id);
                            newEntity.FullName = name;
                            newEntity.CarId = car;
                            result.Add(newEntity);
                        }
                    }

                    

                }
                catch (Exception e)
                {
                    
                }

                return result;
            }
        }

        public List<CarEntity> GetCars()
        {
            using (var con = OpenConnection())
            {
                var result = new List<CarEntity>();

                try
                {
                    con.Open();

                    var commnd = con.CreateCommand();
                    commnd.CommandText = "select * from Tbl_Cars";
                    var reader = commnd.ExecuteReader();

                    if (reader != null && reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var id = (int)reader["Id"];
                            var name = (string)reader["Name"];
                            var newEntity = new CarEntity(id);
                            newEntity.Name = name;
                            result.Add(newEntity);
                        }
                    }

                    //while (reader.Read())
                    //{
                    //    var entity = result[0];
                    //    result.Add(entity);
                    //}

                    con.Close();
                }
                catch (Exception e)
                {
                }

                return result;
            }
        }


        public List<CarEntity> GetCars_EF()
        {
            using (_garageContext)
            {
                return _garageContext.Cars.ToList();
            }   
        }
        
    }
}
