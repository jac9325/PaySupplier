using MySql.Data.MySqlClient;
using PaySupplier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PaySupplier.Controllers
{
    public  class CUser
    {
        
        public static MUser LoginUser(string userData, string passwordData)
        {
            string connectionString = connection.GetConnectionString();
            MUser currentUser = new MUser();
            try
            {

                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "SELECT * FROM users WHERE user = @user and password = @password";

                    // Use the Query method to execute the query and return a list of objects    
                    var userQuery = connection.Query<MUser>(sql, new { user = userData, password = passwordData });
                    currentUser = userQuery.FirstOrDefault();
                    return currentUser;
                }
            }
            catch (Exception)
            {
                // Manejo de errores

                return currentUser;
            }
        }
    }
}
