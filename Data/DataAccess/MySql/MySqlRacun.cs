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
    public class MySqlRacun : IRacun
    {

        private static readonly string INSERT = "INSERT INTO `racun`(VrijemeIzdavanja, RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB, KASA_IdKasa)" +
            " VALUES (@VrijemeIzdavanja, @RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB, @KASA_IdKasa)";
        private static readonly string SELECT = "SELECT IdRacun, VrijemeIzdavanja, JMB, Prezime, Ime, IdKasa "
                + "FROM racun "
                + "INNER JOIN zaposlena_osoba ON JMB = RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB "
                + "INNER JOIN kasa ON IdKasa = KASA_IdKasa ";
        private static readonly string SELECT_ZO = "SELECT IdRacun, VrijemeIzdavanja, JMB, Prezime, Ime, IdKasa "
                + "FROM racun, zaposlena_osoba, kasa "
                + "WHERE KASA_IdKasa = IdKasa AND RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB = JMB AND RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB=@RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB ";
        private static readonly string SELECT_NO_ZO = "SELECT IdRacun, VrijemeIzdavanja, JMB, Prezime, Ime, IdKasa "
               + "FROM racun, zaposlena_osoba, kasa "
               + "WHERE KASA_IdKasa = IdKasa AND RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB = JMB ";

        public void Insert(Racun r)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@VrijemeIzdavanja", DateTime.Now);
                cmd.Parameters.AddWithValue("@RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB", r.ZaposlenaOsoba.Jmb);
                cmd.Parameters.AddWithValue("@KASA_IdKasa", r.Kasa.Id);
                cmd.ExecuteNonQuery();
                r.Id = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlRacun", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public List<Racun> GetRacuni()
        {
            List<Racun> result = new List<Racun>();
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
                    result.Add(new Racun()
                    {
                        Id = reader.GetInt32(0),
                        VrijemeIzdavanja = reader.GetDateTime(1),
                        ZaposlenaOsoba = new ZaposlenaOsoba()
                        {
                            Jmb = reader.GetString(2),
                            Prezime = reader.GetString(3),
                            Ime = reader.GetString(4),
                        },
                        Kasa = new Kasa() { Id = reader.GetInt32(5) }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlRacun", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public List<Racun> GetRacuniByZo(ZaposlenaOsoba zo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            List<Racun> result = new List<Racun>();
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ZO;
                cmd.Parameters.AddWithValue("@RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB", zo.Jmb);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Racun()
                    {
                        Id = reader.GetInt32(0),
                        VrijemeIzdavanja = reader.GetDateTime(1),
                        ZaposlenaOsoba = new ZaposlenaOsoba()
                        {
                            Jmb = reader.GetString(2),
                            Prezime = reader.GetString(3),
                            Ime = reader.GetString(4),
                        },
                        Kasa = new Kasa() { Id = reader.GetInt32(5) }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlRacun", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return result;
        }

        private static readonly string SELECT_ZO_DAN ="AND DAY(VrijemeIzdavanja)=@Dan ";
        private static readonly string SELECT_ZO_MJESEC ="AND MONTH(VrijemeIzdavanja)=@Mjesec ";
        private static readonly string SELECT_ZO_GODINA ="AND YEAR(VrijemeIzdavanja)=@Godina ";
        private static readonly string SELECT_ZO_KASA = "AND KASA_IdKasa=@KASA_IdKasa";


        public List<Racun> GetRacuniByZo(ZaposlenaOsoba zo, string dan, string mjesec, string godina, string kasa)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            List<Racun> result = new List<Racun>();
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                if (zo != null)
                {
                    cmd.CommandText = SELECT_ZO;
                    cmd.Parameters.AddWithValue("@RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB", zo.Jmb);
                }
                else cmd.CommandText = SELECT_NO_ZO;
                if (dan != null)
                    cmd.CommandText += SELECT_ZO_DAN;
                if (mjesec != null)
                    cmd.CommandText += SELECT_ZO_MJESEC;
                if (godina != null)
                    cmd.CommandText += SELECT_ZO_GODINA;
                if (kasa != null)
                    cmd.CommandText += SELECT_ZO_KASA;
                if (dan != null)
                    cmd.Parameters.AddWithValue("@Dan", dan);
                if (mjesec != null)
                    cmd.Parameters.AddWithValue("@Mjesec", mjesec);
                if (godina != null)
                    cmd.Parameters.AddWithValue("@Godina", godina);
                if (kasa != null)
                    cmd.Parameters.AddWithValue("@KASA_IdKasa", kasa);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Racun()
                    {
                        Id = reader.GetInt32(0),
                        VrijemeIzdavanja = reader.GetDateTime(1),
                        ZaposlenaOsoba = new ZaposlenaOsoba()
                        {
                            Jmb = reader.GetString(2),
                            Prezime = reader.GetString(3),
                            Ime = reader.GetString(4),
                        },
                        Kasa = new Kasa() { Id = reader.GetInt32(5) }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlRacun", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return result;
        }
    }
}
