﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspTask1_a_.DataAccessLayer
{
    public class DataAccessLayer
    {
        private static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AspWebApp"].ConnectionString);

        public string insert(string txtID, string txtName, string txtMobile, string txtAddress)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("ContactInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ContactID", txtID);
            cmd.Parameters.AddWithValue("@Name", txtName);
            cmd.Parameters.AddWithValue("@Mobile", txtMobile);
            cmd.Parameters.AddWithValue("@Address", txtAddress);
            cmd.ExecuteNonQuery();
            return null;
            conn.Close();
        }

        public string update(string txtID, string txtName, string txtMobile, string txtAddress)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("ContactUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ContactID", txtID);
            cmd.Parameters.AddWithValue("@Name", txtName);
            cmd.Parameters.AddWithValue("@Mobile", txtMobile);
            cmd.Parameters.AddWithValue("@Address", txtAddress);
            cmd.ExecuteNonQuery();
            return null;
            conn.Close();
        }

        public DataTable fillGridView()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("ContactViewAll", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
            conn.Close();
        }

        
       

        public string delete(string ContactID)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("ContactDeleteByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ContactID",ContactID);
            cmd.ExecuteNonQuery();
            return null;
            conn.Close();
        }

        public void view(string ContactID)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("ContactViewByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ContactID", ContactID);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
        }
        

        
     

    }
}