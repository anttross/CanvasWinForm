using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CanvasWinForm
{
    class Canvas_DB
    {

        public static DataTable getNewOrders()
        {           
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Canvas_DB"].ConnectionString;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Canvas_DB_Get_New_Orders";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable getClient(int orderID)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Canvas_DB"].ConnectionString;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Canvas_DB_Get_Client_By_OrderID";
            cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable getPictures(int orderID)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Canvas_DB"].ConnectionString;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Canvas_DB_Get_Pictures_By_OrderID";
            cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable getTexts(int orderID)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Canvas_DB"].ConnectionString;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Canvas_DB_Get_Texts_By_OrderID";
            cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public static void updateOrderStatus(int orderID)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Canvas_DB"].ConnectionString;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Canvas_DB_Update_Order_Status";
            cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
