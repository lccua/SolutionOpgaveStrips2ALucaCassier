using StripsBL.DTOs;
using StripsBL.Interfaces;
using StripsBL.Model;
using StripsDL.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Repositories
{
    public class StripsRepository : IStripsRepository
    {
        private string connectionString;

        public StripsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Strip> GeefStripsReeks(int reeksId)
        {
            string sql = "SELECT t1.*,t2.Naam FROM Strip t1 inner join Reeks t2 on t1.Reeks=t2.Id WHERE t1.Reeks=@id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                try
                {
                    List<Strip> strips = new List<Strip>();
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", reeksId);
                    IDataReader reader = cmd.ExecuteReader();

                    Reeks reeks = null;

                    while (reader.Read())
                    {
                        if (reeks == null) reeks = new Reeks(reeksId, (string)reader["Naam"]);

                        // Use a conditional cast to handle the possibility of null
                        int? nr = reader["Nr"] != DBNull.Value ? (int?)reader["Nr"] : null;

                        Strip strip = new Strip((int)reader["Id"], (string)reader["Titel"], nr);
                        strip.Reeks = reeks;

                        strips.Add(strip);
                    }
                    reader.Close();
                    return strips;
                }
                catch (Exception ex)
                {
                    throw new Exception("GeefStripsReeks", ex);
                }
            }
        }

        public Reeks GetReeks(int reeksId)
        {
            string sql = "SELECT * FROM Reeks WHERE Id=@Id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", reeksId);
                    IDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    Reeks reeks = new Reeks((int)dr["Id"], (string)dr["Naam"]);
                    dr.Close();
                    return reeks;
                }
                catch (Exception ex)
                {
                    throw new Exception("GetReeks", ex);
                }
            }
        }


    }
}
