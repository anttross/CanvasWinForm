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
        public static string insert_ALL(string eMail, string phone, string address, string fullName, string city, int zip, int POB,
         int amount, int pattern, int delivery, DataTable dtPictures, DataTable dtTexts)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Canvas_DB"].ToString();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "Canvas_DB_Insert_ALL";
            cmd.Parameters.Add(new SqlParameter("@EMail", eMail));
            cmd.Parameters.Add(new SqlParameter("@Phone", phone));
            cmd.Parameters.Add(new SqlParameter("@Address", address));
            cmd.Parameters.Add(new SqlParameter("@FullName", fullName));
            cmd.Parameters.Add(new SqlParameter("@City", city));
            cmd.Parameters.Add(new SqlParameter("@Zip", zip));
            cmd.Parameters.Add(new SqlParameter("@POB", POB));

            cmd.Parameters.Add(new SqlParameter("@OrderDate", DateTime.Now));
            cmd.Parameters.Add(new SqlParameter("@Amount", amount));
            cmd.Parameters.Add(new SqlParameter("@Pattern", pattern));
            cmd.Parameters.Add(new SqlParameter("@Delivery", delivery));

            cmd.Parameters.Add(new SqlParameter("@Pictures_Tbl", dtPictures));

            cmd.Parameters.Add(new SqlParameter("@Texts_Tbl", dtTexts));

            con.Open();
            string res = cmd.ExecuteScalar().ToString();
            con.Close();
            return res;
        }



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
            if (dt != null)
                return dt;
            else
            {
                dt.NewRow();
                return dt;
            }
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

        public static void updateOrderStatus(int orderID, int status)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Canvas_DB"].ConnectionString;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Canvas_DB_Update_Order_Status";
            cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
            cmd.Parameters.Add(new SqlParameter("@Status", status));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //#region manual picture
        //public static int insertPicture(int ord_ID, string fileName, byte[] fileBody, int fileSize, float size, int top, int left, float angle)
        //{
        //    SqlConnection con = new SqlConnection();
        //    SqlCommand cmd = new SqlCommand();
        //    con.ConnectionString = "Data Source=DESKTOP-BUV55UA; Initial Catalog=Canvas_DB; Integrated Security=true; ";
        //    cmd.Connection = con;
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.CommandText = "Canvas_DB_Picture_Insert";
        //    cmd.Parameters.Add(new SqlParameter("@OrderID", ord_ID));
        //    cmd.Parameters.Add(new SqlParameter("@FileName", fileName));
        //    cmd.Parameters.Add(new SqlParameter("@FileBody", fileBody));
        //    cmd.Parameters.Add(new SqlParameter("@FileSize", fileSize));
        //    cmd.Parameters.Add(new SqlParameter("@Size", size));
        //    cmd.Parameters.Add(new SqlParameter("@Top", top));
        //    cmd.Parameters.Add(new SqlParameter("@Left", left));
        //    cmd.Parameters.Add(new SqlParameter("@Angle", angle));

        //    con.Open();
        //    int res = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        //    con.Close();
        //    return res;
        //}
        //#endregion
    }
}
