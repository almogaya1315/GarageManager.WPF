﻿using GarageManager.Core.Entities;
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
        public GarageRepository()
        {

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
    }
}
