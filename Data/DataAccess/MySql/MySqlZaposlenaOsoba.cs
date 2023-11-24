using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Prodavnica.Data.DataAccess.Exceptions;
using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Prodavnica.Data.DataAccess.MySql
{
    public class MySqlZaposlenaOsoba : IZaposlenaOsoba
    {
        private static readonly string SELECT = "SELECT JMB, Prezime, Ime FROM zaposlena_osoba";
        private static readonly string SELECT_LOGIN = "SELECT JMB, Prezime, Ime FROM zaposlena_osoba WHERE KorisnickoIme=@KorisnickoIme AND Lozinka=@Lozinka";
        private static readonly string SELECT_JMB = "SELECT JMB, Prezime, Ime FROM zaposlena_osoba WHERE JMB=@JMB";
        private static readonly string SELECT_RADNIK_NA_KASI = "SELECT JMB, Prezime, Ime FROM zaposlena_osoba, radnik_na_kasi WHERE JMB=ZAPOSLENA_OSOBA_JMB";
        private static readonly string SELECT_ADMINISTRATOR = "SELECT JMB, Prezime, Ime FROM zaposlena_osoba, administrator WHERE JMB=ZAPOSLENA_OSOBA_JMB";
        private static readonly string SELECT_KORISNICKO_IME = "SELECT KorisnickoIme FROM zaposlena_osoba WHERE JMB=@JMB";
        private static readonly string UPDATE = "UPDATE zaposlena_osoba SET Prezime=@Prezime, Ime=@Ime WHERE JMB=@JMB";
        private static readonly string UPDATE_USERNAME = "UPDATE zaposlena_osoba SET KorisnickoIme=@KorisnickoIme WHERE JMB=@JMB";
        private static readonly string UPDATE_PASSWORD = "UPDATE zaposlena_osoba SET Lozinka=@Lozinka WHERE JMB=@JMB";
        private static readonly string INSERT = "INSERT INTO zaposlena_osoba (JMB, Prezime, Ime, KorisnickoIme, Lozinka) VALUES (@JMB, @Prezime, @Ime, @KorisnickoIme, @Lozinka)";
        private static readonly string INSERT_RADNIK_NA_KASI = "INSERT INTO radnik_na_kasi (ZAPOSLENA_OSOBA_JMB) VALUES (@ZAPOSLENA_OSOBA_JMB)";

        public List<ZaposlenaOsoba> getZaposleneOsobe()
        {
            List<ZaposlenaOsoba> result = new List<ZaposlenaOsoba>();
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
                    result.Add(new ZaposlenaOsoba()
                    {
                        Jmb = reader.GetString(0),
                        Prezime = reader.GetString(1),
                        Ime = reader.GetString(2),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public ZaposlenaOsoba getZaposlenaOsoba(string korisnickoIme, string lozinka)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            ZaposlenaOsoba result = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_LOGIN;
                cmd.Parameters.AddWithValue("@KorisnickoIme", korisnickoIme);
                cmd.Parameters.AddWithValue("@Lozinka", lozinka);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = new ZaposlenaOsoba()
                    {
                        Jmb = reader.GetString(0),
                        Prezime = reader.GetString(1),
                        Ime = reader.GetString(2)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return result;
        }

        public ZaposlenaOsoba getZaposlenaOsobaByJMB(string jmb)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            ZaposlenaOsoba result;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_JMB;
                cmd.Parameters.AddWithValue("@JMB", jmb);
                reader = cmd.ExecuteReader();
                result = new ZaposlenaOsoba()
                {
                    Jmb = reader.GetString(0),
                    Prezime = reader.GetString(1),
                    Ime = reader.GetString(2)
                };
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return result;
        }

        public List<ZaposlenaOsoba> getRadnikeNaKasi()
        {
            List<ZaposlenaOsoba> result = new List<ZaposlenaOsoba>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_RADNIK_NA_KASI;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new ZaposlenaOsoba()
                    {
                        Jmb = reader.GetString(0),
                        Prezime = reader.GetString(1),
                        Ime = reader.GetString(2),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public List<ZaposlenaOsoba> getAdministratori()
        {
            List<ZaposlenaOsoba> result = new List<ZaposlenaOsoba>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ADMINISTRATOR;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new ZaposlenaOsoba()
                    {
                        Jmb = reader.GetString(0),
                        Prezime = reader.GetString(1),
                        Ime = reader.GetString(2),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public string GetKorisnickoIme(ZaposlenaOsoba zaposlenaOsoba)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            string result = "";

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_KORISNICKO_IME;
                cmd.Parameters.AddWithValue("@JMB", zaposlenaOsoba.Jmb);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void UpdatePassword(ZaposlenaOsoba zaposlenaOsoba, string newPassword)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_PASSWORD;
                cmd.Parameters.AddWithValue("@Lozinka", newPassword);
                cmd.Parameters.AddWithValue("@JMB", zaposlenaOsoba.Jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void UpdateUserName(ZaposlenaOsoba zaposlenaOsoba, string userName)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_USERNAME;
                cmd.Parameters.AddWithValue("@KorisnickoIme", userName);
                cmd.Parameters.AddWithValue("@JMB", zaposlenaOsoba.Jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void UpdateZaposlenaOsoba(ZaposlenaOsoba zaposlenaOsoba)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Prezime", zaposlenaOsoba.Prezime);
                cmd.Parameters.AddWithValue("@Ime", zaposlenaOsoba.Ime);
                cmd.Parameters.AddWithValue("@JMB", zaposlenaOsoba.Jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void InsertZaposlenaOsoba(ZaposlenaOsoba zaposlenaOsoba, string userName, string password)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@JMB", zaposlenaOsoba.Jmb);
                cmd.Parameters.AddWithValue("@Prezime", zaposlenaOsoba.Prezime);
                cmd.Parameters.AddWithValue("@Ime", zaposlenaOsoba.Ime);
                cmd.Parameters.AddWithValue("@KorisnickoIme", userName);
                cmd.Parameters.AddWithValue("Lozinka", password);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void InsertRadnikNaKasi(ZaposlenaOsoba zaposlenaOsoba)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_RADNIK_NA_KASI;
                cmd.Parameters.AddWithValue("@ZAPOSLENA_OSOBA_JMB", zaposlenaOsoba.Jmb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlZaposlenaOsoba", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
