using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using HomeWorkLayots.Data.Interfaces;
using HomeWorkLayots.Data.Model;

namespace HomeWorkLayots.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private string _connectionString = @"Data Source=LAPTOP-06F37EVB;Initial Catalog=HomeWork4;Integrated Security=True";

        IEnumerable<Category> ICategoryRepository.GetCategories()
        {
            var res = new List<Category>();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = _connectionString;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                using (var dt = new DataTable())
                {
                    command.CommandText = "SELECT * FROM Catalog";
                    dt.Load(command.ExecuteReader());
                    foreach (var dataRow in dt.AsEnumerable())
                    {
                        var item = new Category();
                        item.ID = Convert.ToInt32(dataRow["ID"]);
                        item.Name = Convert.ToString(dataRow["Name"]);
                        res.Add(item);
                    }
                }
                connection.Close();
            }
            return res;
        }
    }
}
