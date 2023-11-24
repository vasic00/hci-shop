using MySql.Data.MySqlClient;
using Prodavnica.Data.DataAccess.Exceptions;
using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Prodavnica.Data.DataAccess.MySql
{
    public class MySqlArtikl : IArtikl
    {
        private static readonly string SELECT =
            @"SELECT Barkod, a.Naziv, Cijena, Kolicina, ta.IdTipArtikla, ta.Naziv
              FROM `artikl` a
              INNER JOIN `tip_artikla` ta ON a.TIP_ARTIKLA_IdTipArtikla=ta.IdTipArtikla";
        private static readonly string SELECT_TIP = "SELECT Barkod, a.Naziv, Cijena, Kolicina, ta.IdTipArtikla, ta.Naziv " +
            "FROM artikl a INNER JOIN tip_artikla ta ON a.TIP_ARTIKLA_IdTipArtikla=ta.IdTipArtikla " +
            "WHERE TIP_ARTIKLA_IdTipArtikla=@TIP_ARTIKLA_IdTipArtikla";
        private static readonly string INSERT =
            @"INSERT INTO `artikl`(Naziv, Cijena, Kolicina, TIP_ARTIKLA_IdTipArtikla)
              VALUES (@Naziv, @Cijena, @Kolicina, @TIP_ARTIKLA_IdTipArtikla)";
        private static readonly string UPDATE =
            @"UPDATE `artikl` SET Naziv=@Naziv, Cijena=@Cijena, Kolicina=@Kolicina, TIP_ARTIKLA_IdTipArtikla=@TIP_ARTIKLA_IdTipArtikla
              WHERE Barkod=@Barkod";
        private static readonly string DELETE = "DELETE FROM `artikl` WHERE Barkod=@Barkod";
        private static readonly string UPDATE_NAZIV_CIJENA =
            @"UPDATE `artikl` SET Naziv=@Naziv, Cijena=@Cijena WHERE Barkod=@Barkod";
        private static readonly string SELECT_FILTER = "SELECT Barkod, a.Naziv, Cijena, Kolicina, ta.IdTipArtikla, ta.Naziv " +
            "FROM artikl a " +
            "INNER JOIN tip_artikla ta on a.TIP_ARTIKLA_IdTipArtikla=ta.IdTipArtikla " +
            "WHERE Barkod LIKE @str OR a.Naziv LIKE @str OR ta.Naziv LIKE @str";
        private static readonly string COUNT = "SELECT Count(*) FROM Artikl WHERE TIP_ARTIKLA_IdTipArtikla=@TIP_ARTIKLA_IdTipArtikla";

        public List<Artikl> GetArtikli()
        {
            List<Artikl> result = new List<Artikl>();
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
                    result.Add(new Artikl()
                    {
                        Barkod = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Cijena = reader.GetDecimal(2),
                        Kolicina = reader.GetInt16(3),
                        TipArtikla = new TipArtikla() { Id = reader.GetInt32(4), Naziv = reader.GetString(5),}
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public List<Artikl> GetArtikliByTipArtikla(TipArtikla tipArtikla)
        {
            List<Artikl> result = new List<Artikl>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_TIP;
                cmd.Parameters.AddWithValue("@TIP_ARTIKLA_IdTipArtikla", tipArtikla.Id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Artikl()
                    {
                        Barkod = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Cijena = reader.GetDecimal(2),
                        Kolicina = reader.GetInt16(3),
                        TipArtikla = new TipArtikla() { Id = reader.GetInt32(4), Naziv = reader.GetString(5), }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void SaveArtikl(Artikl artikl)
        {
            if (artikl.Barkod <= 0)
            {
                InsertArtikl(artikl);
            }
            else
            {
                UpdateArtikl(artikl);
            }
        }

        private void InsertArtikl(Artikl artikl)
        {

            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Naziv", artikl.Naziv);
                cmd.Parameters.AddWithValue("@Cijena", artikl.Cijena);
                cmd.Parameters.AddWithValue("@Kolicina", artikl.Kolicina);
                cmd.Parameters.AddWithValue("@TIP_ARTIKLA_IdTipArtikla", artikl.TipArtikla.Id);
                cmd.ExecuteNonQuery();
                artikl.Barkod = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        private void UpdateArtikl(Artikl artikl)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Barkod", artikl.Barkod);
                cmd.Parameters.AddWithValue("@Naziv", artikl.Naziv);
                cmd.Parameters.AddWithValue("@Cijena", artikl.Cijena);
                cmd.Parameters.AddWithValue("@Kolicina", artikl.Kolicina);
                cmd.Parameters.AddWithValue("@TIP_ARTIKLA_IdTipArtikla", artikl.TipArtikla.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void DeleteArtiklByBarkod(int barkod)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@Barkod", barkod);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void UpdateNazivAndCijena(Artikl artikl)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_NAZIV_CIJENA;
                cmd.Parameters.AddWithValue("@Barkod", artikl.Barkod);
                cmd.Parameters.AddWithValue("@Naziv", artikl.Naziv);
                cmd.Parameters.AddWithValue("@Cijena", artikl.Cijena);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
        public List<Artikl> GetArtikli(string filter)
        {
            List<Artikl> result = new List<Artikl>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_FILTER;
                cmd.Parameters.AddWithValue("@str", filter + "%");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Artikl()
                    {
                        Barkod = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Cijena = reader.GetDecimal(2),
                        Kolicina = reader.GetInt16(3),
                        TipArtikla = new TipArtikla() { Id = reader.GetInt32(4), Naziv = reader.GetString(5), }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        private static readonly string SELECT_BY_RACUN = "SELECT Barkod, a.Naziv, ra.Cijena, ra.Kolicina "
                + "FROM racun_artikl ra, artikl a "
                + "WHERE ARTIKL_Barkod=Barkod AND RACUN_IdRacun=@RACUN_IdRacun";
        public List<Artikl> GetArtikliByRacun(Racun racun)
        {
            List<Artikl> result = new List<Artikl>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_RACUN;
                cmd.Parameters.AddWithValue("@RACUN_IdRacun", racun.Id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Artikl()
                    {
                        Barkod = Int32.Parse(reader.GetString(0)),
                        Naziv = reader.GetString(1),
                        Cijena = reader.GetDecimal(2),
                        Kolicina = reader.GetInt16(3),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        private static readonly string SELECT_WITH_KOLICINA = "SELECT Barkod, Naziv, Cijena, Kolicina " +
            "FROM artikl WHERE Kolicina > 0";
        public List<Artikl> GetArtikliWithKolicina()
        {
            List<Artikl> result = new List<Artikl>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_WITH_KOLICINA;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Artikl()
                    {
                        Barkod = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Cijena = reader.GetDecimal(2),
                        Kolicina = reader.GetInt16(3),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        private static readonly string SELECT_BY_NARUDZBA = "SELECT a.Naziv, na.Cijena, na.Kolicina "
                + "FROM narudzba_artikl na, artikl a "
                + "WHERE ARTIKL_Barkod=Barkod AND NARUDZBA_IdNarudzba=@NARUDZBA_IdNarudzba";

        public List<Artikl> GetArtikliByNarudzba(Narudzba narudzba)
        {
            List<Artikl> result = new List<Artikl>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_NARUDZBA;
                cmd.Parameters.AddWithValue("@NARUDZBA_IdNarudzba", narudzba.Id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Artikl()
                    {
                        Naziv = reader.GetString(0),
                        Cijena = reader.GetDecimal(1),
                        Kolicina = reader.GetInt16(2),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public int GetCountByTipArtikla(TipArtikla tipArtikla)
        {
            List<Artikl> result = new List<Artikl>();
            MySqlConnection conn = null;
            MySqlCommand cmd;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = COUNT;
                cmd.Parameters.AddWithValue("@TIP_ARTIKLA_IdTipArtikla", tipArtikla.Id);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
