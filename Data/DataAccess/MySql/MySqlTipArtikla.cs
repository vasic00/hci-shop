using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Prodavnica.Data.DataAccess.Exceptions;
using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess.MySql
{
    public class MySqlTipArtikla : ITipArtikla
    {
        private static readonly string SELECT = "SELECT IdTipArtikla, Naziv FROM `tip_artikla` ORDER BY Naziv";
        private static readonly string INSERT = "INSERT INTO `tip_artikla`(Naziv) VALUES (@Naziv)";
        private static readonly string UPDATE = "UPDATE `tip_artikla` SET Naziv=@Naziv WHERE IdTipArtikla=@IdTipArtikla";
        private static readonly string DELETE = "DELETE FROM `tip_artikla` WHERE IdTipArtikla=@IdTipArtikla";
        private static readonly string SELECT_ID = "SELECT IdTipArtikla, Naziv FROM tip_artikla WHERE IdTipArtikla=@IdTipArtikla";

        public List<TipArtikla> GetTipoviArtikala()
        {
            List<TipArtikla> result = new List<TipArtikla>();
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
                    result.Add(new TipArtikla()
                    {
                        Id = reader.GetInt32(0),
                        Naziv = reader.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTipArtikla", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public void SaveTipArtikla(TipArtikla TipArtikla)
        {
            if (TipArtikla.Id <= 0)
            {
                InsertTipArtikla(TipArtikla);
            }
            else
            {
                UpdateTipArtikla(TipArtikla);
            }
        }

        private void InsertTipArtikla(TipArtikla TipArtikla)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Naziv", TipArtikla.Naziv);
                cmd.ExecuteNonQuery();
                TipArtikla.Id = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTipArtikla", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        private void UpdateTipArtikla(TipArtikla TipArtikla)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@IdTipArtikla", TipArtikla.Id);
                cmd.Parameters.AddWithValue("@Naziv", TipArtikla.Naziv);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTipArtikla", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public void DeleteTipArtiklaById(int id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdTipArtikla", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTipArtikla", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public TipArtikla GetTipArtiklaById(int id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            TipArtikla tipArtikla = new TipArtikla();

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ID;
                cmd.Parameters.AddWithValue("@IdTipArtikla", id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tipArtikla.Id = reader.GetInt32(0);
                    tipArtikla.Naziv = reader.GetString(1);
                }
                return tipArtikla;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlTipArtikla", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
