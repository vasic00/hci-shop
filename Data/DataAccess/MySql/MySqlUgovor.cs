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
    public class MySqlUgovor : IUgovor
    {
        private static readonly string SELECT_JMB = "SELECT IdUgovor, Od, Do, Plata, JMB, Prezime, Ime " +
            "FROM ugovor_o_zaposlenju " +
            "INNER JOIN zaposlena_osoba ON ZAPOSLENA_OSOBA_JMB=JMB " +
            "WHERE ZAPOSLENA_OSOBA_JMB=@ZAPOSLENA_OSOBA_JMB";
        private static readonly string INSERT = "INSERT INTO ugovor_o_zaposlenju (Od, Do, Plata, ZAPOSLENA_OSOBA_JMB) VALUES (@Od, @Do, @Plata, @ZAPOSLENA_OSOBA_JMB)";
        private static readonly string UPDATE = "UPDATE ugovor_o_zaposlenju SET Od=@Od, Do=@Do, Plata=@Plata WHERE IdUgovor=@IdUgovor";
        private static readonly string DELETE = "DELETE FROM ugovor_o_zaposlenju WHERE IdUgovor=@IdUgovor";

        public void CreateUgovor(Ugovor ugovor)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Od", ugovor.Od);
                cmd.Parameters.AddWithValue("@Do", ugovor.Do);
                cmd.Parameters.AddWithValue("@Plata", ugovor.Plata);
                cmd.Parameters.AddWithValue("@ZAPOSLENA_OSOBA_JMB", ugovor.ZaposlenaOsoba.Jmb);
                cmd.ExecuteNonQuery();
                ugovor.Id = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlUgovor", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void DeleteUgovor(Ugovor ugovor)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdUgovor", ugovor.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlUgovor", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public List<Ugovor> GetUgovoriByJMB(string jmb)
        {

            List<Ugovor> result = new List<Ugovor>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_JMB;
                cmd.Parameters.AddWithValue("@ZAPOSLENA_OSOBA_JMB", jmb);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Ugovor()
                    {
                        Id = reader.GetInt32(0),
                        Od = reader.GetDateTime(1),
                        Do = reader.GetDateTime(2),
                        Plata = reader.GetDecimal(3),
                        ZaposlenaOsoba = new ZaposlenaOsoba() { Jmb = reader.GetString(4), Prezime = reader.GetString(5), Ime = reader.GetString(6) }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlUgovor", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void UpdateUgovor(Ugovor ugovor)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Od", ugovor.Od);
                cmd.Parameters.AddWithValue("@Do", ugovor.Do);
                cmd.Parameters.AddWithValue("@Plata", ugovor.Plata);
                cmd.Parameters.AddWithValue("@IdUgovor", ugovor.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlUgovor", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
