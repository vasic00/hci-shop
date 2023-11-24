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
    public class MySqlNarudzbaArtikl : INarudzbaArtikl
    {

        private static readonly string INSERT = "INSERT INTO `narudzba_artikl`(NARUDZBA_IdNarudzba, ARTIKL_Barkod, Cijena, Kolicina) " +
            "VALUES (@NARUDZBA_IdNarudzba, @ARTIKL_Barkod, @Cijena, @Kolicina)";
        public void Insert(Narudzba n, Artikl a)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@NARUDZBA_IdNarudzba", n.Id);
                cmd.Parameters.AddWithValue("@ARTIKL_Barkod", a.Barkod);
                cmd.Parameters.AddWithValue("@Cijena", a.Cijena);
                cmd.Parameters.AddWithValue("@Kolicina", a.Kolicina);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlNarudzbaArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
