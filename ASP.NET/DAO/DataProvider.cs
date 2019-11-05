using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private static SqlConnection conn = new SqlConnection("Data Source=TAN;Initial Catalog=WebBanHang;Integrated Security=True");
        //
        private static SqlConnection OpenConnection()
        {
            if ((conn.State == ConnectionState.Closed) || (conn.State == ConnectionState.Broken))
            {
                conn.Open();
            }
            return conn;
        }
        public static DataTable ExecuteSelectQuery(String query)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dtbResult = new DataTable();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(dtbResult);
                return dtbResult;
            }
            catch (SqlException e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable ExecuteSelectQuery(String query, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dtbResult = new DataTable();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(param);
                adapter.SelectCommand = cmd;
                adapter.Fill(dtbResult);
                return dtbResult;
            }
            catch (SqlException e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public static Int32 ExecuteInsertQuery(String query, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            Int32 rowsAffected;
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(param);
                adapter.InsertCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (SqlException e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
        public static Int32 ExecuteUpdateQuery(String query, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            Int32 rowsAffected;
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(param);
                adapter.UpdateCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (SqlException e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
        public static Int32 ExecuteDeleteQuery(String query, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            Int32 rowsAffected;
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(param);
                adapter.DeleteCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (SqlException e)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}