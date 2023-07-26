using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaySupplier.Models;
using Dapper;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace PaySupplier.Controllers
{
    public class CProfile
    {
        string connectionString = connection.GetConnectionString();

        public bool CreateProfile(MProfile profile)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO profiles (name, description, status, dateCreated) VALUES (@name, @description, @status, @dateCreated)";
                    int rowsAffected = connection.Execute(sql, profile);
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Manejo de errores 
                return false;
            }
        }
        public bool UpdateProfile(MProfile profile)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE profiles SET name = @name, description = @description, status = @status, dateCreated = @dateCreated WHERE id = @id";
                    int rowsAffected = connection.Execute(sql, profile);
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Manejo de errores 
                return false;
            }
        }

        public List<MProfile> GetProfiles()
        {
            List<MProfile> profiles = new List<MProfile>();
            try
            {
                
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * profiles WHERE status = 1";        
                    profiles = connection.Query<MProfile>(sqlQuery).ToList();
                    return profiles;
                }
            }
            catch (Exception)
            {
                // Manejo de errores
                
                return profiles; 
            }
        }

    }
}
