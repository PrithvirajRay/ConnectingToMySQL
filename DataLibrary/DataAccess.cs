﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAccess//: IDataAccess
    {
        public async Task <List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }

     //   public List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
     //   {
     //       throw new NotImplementedException();
     //   }

        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);


            }
        }

      //  void IDataAccess.SaveData<T>(string sql, T parameters, string connectionString)
      //  {
      //      throw new NotImplementedException();
       // }
    }
}
