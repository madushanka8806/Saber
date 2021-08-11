using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace SaberWebservice
{
    /// <summary>
    /// Summary description for SaberWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SaberWebService : System.Web.Services.WebService
    {
        SqlConnection sqlCon = null;

        public SqlConnection getConnection()
        {
            try
            {
                sqlCon = new SqlConnection("Data Source=.;Initial Catalog=Saber;User ID=sa;Password=6605");
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connection to Db" + ex);
            }
            return sqlCon;
        }

        public Tuple <SqlConnection, SqlTransaction> getTransaction()
        {
            SqlConnection con = getConnection();
            SqlTransaction transaction;
            transaction= con.BeginTransaction();
            return new Tuple<SqlConnection, SqlTransaction>(con, transaction);
        }

        [WebMethod]
        public string AddItem(int ItemCode, string ItemName, string UOM, int AvailableQty)
        {
            int temp = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into ItemMaster values('" + ItemCode + "','" + ItemName + "','" + UOM + "','" + AvailableQty + "');", sqlCon);

                temp = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return temp.ToString();
        }

        [WebMethod]
        public DataSet SearchItembyCode(int ItemCode)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();

                SqlCommand cmd =
                new SqlCommand("Select * from ItemMaster where ItemCode= '" + ItemCode + "'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "ItemMaster");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching product" + ex);
            }
            return ds;
        }

        [WebMethod]
        public DataSet SearchItembyName(string ItemName)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();

                SqlCommand cmd =
                new SqlCommand("Select * from ItemMaster where ItemName= '" + ItemName + "'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "ItemMaster");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching product" + ex);
            }
            return ds;
        }

        [WebMethod]
        public bool AddStock(int ItemCode, string ItemName, string UOM, int Qty, string TransactionType, string DocNumber, string Date)
        {
            SqlConnection con;
            SqlTransaction transaction;

            var tuple = getTransaction();
            con = tuple.Item1;
            transaction = tuple.Item2;

            try
            {
                new SqlCommand("insert into ItemTransaction values('" + ItemCode + "','" + TransactionType + "','" + DocNumber + "','" + Qty + "','" + Convert.ToDateTime(Date) + "');", con, transaction)
                   .ExecuteNonQuery();
                new SqlCommand("update ItemMaster set AvailableQty=AvailableQty+ " + Qty + " where ItemCode='" + ItemCode + "' ", con, transaction)
                   .ExecuteNonQuery();
                /*new SqlCommand("INSERT Qwery3 ", con, transaction)
                   .ExecuteNonQuery();*/
                transaction.Commit();
                return true;
            }
            catch (SqlException sqlError)
            {
                transaction.Rollback();
                return false;
            }
        }

        [WebMethod]
        public bool PlaceOrder(int ItemCode, string ItemName, string UOM, int Qty, string TransactionType, string DocNumber, string Date)
        {
            SqlConnection con;
            SqlTransaction transaction;

            var tuple = getTransaction();
            con = tuple.Item1;
            transaction = tuple.Item2;

            try
            {
                new SqlCommand("insert into ItemTransaction values('" + ItemCode + "','" + TransactionType + "','" + DocNumber + "','" + Qty + "','" + Convert.ToDateTime(Date) + "');", con, transaction)
                   .ExecuteNonQuery();
                new SqlCommand("update ItemMaster set AvailableQty=AvailableQty- " + Qty + " where ItemCode='" + ItemCode + "'", con, transaction)
                   .ExecuteNonQuery();
                /*new SqlCommand("INSERT Qwery3 ", con, transaction)
                   .ExecuteNonQuery();*/
                transaction.Commit();
                return true;
            }
            catch (SqlException sqlError)
            {
                transaction.Rollback();
                return false;
            }
        }
    }
}
