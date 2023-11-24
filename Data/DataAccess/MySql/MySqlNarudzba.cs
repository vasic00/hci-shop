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
    internal class MySqlNarudzba : INarudzba
    {
        private static readonly string SELECT = "SELECT IdNarudzba, Datum, IdDobavljac, Naziv " +
            "FROM narudzba " +
            "INNER JOIN dobavljac ON IdDobavljac=DOBAVLJAC_IdDobavljac ";
        private static readonly string INSERT = "INSERT INTO `narudzba`(Datum, DOBAVLJAC_IdDobavljac) " +
            "VALUES (@Datum, @DOBAVLJAC_IdDobavljac)";
        public List<Narudzba> GetNarudzbe()
        {
            List<Narudzba> result = new List<Narudzba>();
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
                    result.Add(new Narudzba()
                    {
                        Id = reader.GetInt32(0),
                        Datum = reader.GetDateTime(1),
                        Dobavljac = new Dobavljac()
                        {
                            Id = reader.GetInt32(2),
                            Naziv = reader.GetString(3)
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlNarudzba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        private static readonly string SELECT_D = "WHERE IdDobavljac=@IdDobavljac ";
        private static readonly string SELECT_D_DAN = "AND DAY(Datum)=@Dan ";
        private static readonly string SELECT_D_MJESEC = "AND MONTH(Datum)=@Mjesec ";
        private static readonly string SELECT_D_GODINA = "AND YEAR(Datum)=@Godina ";
        public List<Narudzba> GetNarudzbe(Dobavljac d, string dan, string mjesec, string godina)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            List<Narudzba> result = new List<Narudzba>();
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                if (d != null)
                    cmd.CommandText += SELECT_D;
                if (dan != null)
                    cmd.CommandText += SELECT_D_DAN;
                if (mjesec != null)
                    cmd.CommandText += SELECT_D_MJESEC;
                if (godina != null)
                    cmd.CommandText += SELECT_D_GODINA;
                if (d != null)
                    cmd.Parameters.AddWithValue("@IdDobavljac", d.Id);
                if (dan != null)
                    cmd.Parameters.AddWithValue("@Dan", dan);
                if (mjesec != null)
                    cmd.Parameters.AddWithValue("@Mjesec", mjesec);
                if (godina != null)
                    cmd.Parameters.AddWithValue("@Godina", godina);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Narudzba()
                    {
                        Id = reader.GetInt32(0),
                        Datum = reader.GetDateTime(1),
                        Dobavljac = new Dobavljac()
                        {
                            Id = reader.GetInt32(2),
                            Naziv = reader.GetString(3)
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlNarudzba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return result;
        }

        public void Insert(Narudzba n)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                if (n.Datum != null)
                    cmd.Parameters.AddWithValue("@Datum", n.Datum);
                else cmd.Parameters.AddWithValue("@Datum", DateTime.Now);
                cmd.Parameters.AddWithValue("@DOBAVLJAC_IdDobavljac", n.Dobavljac.Id);
                cmd.ExecuteNonQuery();
                n.Id = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlNarudzba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
