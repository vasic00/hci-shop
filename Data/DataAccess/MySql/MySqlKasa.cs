using MySql.Data.MySqlClient;
using Prodavnica.Data.DataAccess.Exceptions;
using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess.MySql
{
    public class MySqlKasa : IKasa
    {
        private static readonly string SELECT = "SELECT IdKasa FROM kasa ORDER BY IdKasa";
        private static readonly string INSERT = "INSERT INTO kasa (IdKasa) VALUES (NULL)";

        public List<Kasa> GetKase()
        {
            List<Kasa> result = new List<Kasa>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Kasa()
                    {
                        Id = reader.GetInt32(0),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlKasa", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }



        public void InsertKasa()
        {

            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlKasa", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
