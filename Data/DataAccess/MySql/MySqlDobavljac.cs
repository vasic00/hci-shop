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
    public class MySqlDobavljac : IDobavljac
    {
        private static readonly string SELECT = "SELECT IdDobavljac, Naziv FROM dobavljac";
        private static readonly string INSERT = "INSERT INTO dobavljac (Naziv) VALUES (@Naziv)";
        private static readonly string UPDATE = "UPDATE dobavljac SET Naziv=@Naziv WHERE IdDobavljac=@IdDobavljac";
        public List<Dobavljac> GetDobavljaci()
        {
            List<Dobavljac> result = new List<Dobavljac>();
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
                    result.Add(new Dobavljac()
                    {
                        Id = reader.GetInt32(0),
                        Naziv = reader.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlDobavljac", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void InsertDobavljac(Dobavljac dobavljac)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Naziv", dobavljac.Naziv);
                cmd.ExecuteNonQuery();
                dobavljac.Id = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlDobavljac", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void UpdateDobavljac(Dobavljac dobavljac)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Naziv", dobavljac.Naziv);
                cmd.Parameters.AddWithValue("@IdDobavljac", dobavljac.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlDobavljac", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
