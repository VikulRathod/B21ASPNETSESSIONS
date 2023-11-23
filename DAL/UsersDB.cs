using Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UsersDB : IUsersDB
    {
        public bool Insert(User user, out int registrationNumber)
        {
            string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("usp_Register", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);

                SqlParameter status = new SqlParameter();
                status.ParameterName = "@Status";
                status.Direction = ParameterDirection.Output;
                status.SqlDbType = SqlDbType.Bit;

                cmd.Parameters.Add(status);

                SqlParameter regno = new SqlParameter();
                regno.ParameterName = "@RegNo";
                regno.Direction = ParameterDirection.Output;
                regno.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(regno);

                con.Open();

                cmd.ExecuteNonQuery();

                registrationNumber = (int)regno.Value;
                return (bool)status.Value;
            }
        }
    }
}
