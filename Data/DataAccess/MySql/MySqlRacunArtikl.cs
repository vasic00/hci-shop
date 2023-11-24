using MySql.Data.MySqlClient;
using Prodavnica.Data.DataAccess.Exceptions;
using Prodavnica.Data.Model;
using System;
using System.Data;

namespace Prodavnica.Data.DataAccess.MySql
{
    internal class MySqlRacunArtikl : IRacunArtikl
    {
        private static readonly string PROCEDURE = "create_racun_artikl";
        public void Insert(Racun r, Artikl a)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = PROCEDURE;
                cmd.Parameters.AddWithValue("@racunId", r.Id);
                cmd.Parameters["@racunId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@artiklBarkod", a.Barkod);
                cmd.Parameters["@artiklBarkod"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@raCijena", a.Cijena);
                cmd.Parameters["@raCijena"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("raKolicina", a.Kolicina);
                cmd.Parameters["@raKolicina"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@b", MySqlDbType.Byte);
                cmd.Parameters["@b"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                Console.WriteLine(cmd.Parameters["@b"].Value);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlRacunArtikl", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
