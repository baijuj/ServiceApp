using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Configuration;

namespace ServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Sales> GetSaleData()
        {
            DataSet ds = GetSaleData("");
            List<Sales> result = new List<Sales>();
            result = ds.Tables[0].AsEnumerable().Select(dataRow => new Sales { Category = dataRow.Field<string>("Category"), Quantity = dataRow.Field<int>("Quantity") }).ToList();

            return result;
        }

        public List<SalesCommon> GetQuarterlySales()
        {
            DataSet ds = GetQuarterlySales("");
            List<SalesCommon> result = new List<SalesCommon>();
            result = ds.Tables[0].AsEnumerable().Select(dataRow => new SalesCommon { Year = dataRow.Field<string>("Year"), Quarter = dataRow.Field<string>("Quarter"), Sales = dataRow.Field<int>("Sales") }).ToList();

            return result;
        }
        public List<SalesCommon> GetPurchase()
        {
            DataSet ds = GetPurchase("");
            List<SalesCommon> result = new List<SalesCommon>();
            result = ds.Tables[0].AsEnumerable().Select(dataRow => new SalesCommon { Year = dataRow.Field<string>("Year"), Quarter = dataRow.Field<string>("Quarter"), Sales = dataRow.Field<int>("Sales") }).ToList();

            return result;
        }
        public List<SalesCommon> GetRevenue()
        {
            DataSet ds = GetRevenue("");
            List<SalesCommon> result = new List<SalesCommon>();
            result = ds.Tables[0].AsEnumerable().Select(dataRow => new SalesCommon { Year = dataRow.Field<string>("Category"), Quarter = dataRow.Field<string>("Quarter"), Sales = dataRow.Field<int>("Sales") }).ToList();

            return result;
        }

        public DataSet GetSaleData(string paramValue)
        {
            SqlConnection sqlConn = new SqlConnection(WebConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
            SqlCommand sqlcomm = new SqlCommand();

            sqlcomm.Connection = sqlConn;
            using (sqlConn)
            {
                try
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        sqlcomm.CommandText = "uspGetSalesByCategory";
                        da.SelectCommand = sqlcomm;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            return new DataSet();
        }


        public DataSet GetQuarterlySales(string paramValue)
        {
            SqlConnection sqlConn = new SqlConnection(WebConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
            SqlCommand sqlcomm = new SqlCommand();

            sqlcomm.Connection = sqlConn;
            using (sqlConn)
            {
                try
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        sqlcomm.CommandText = "uspGetQuarterlySales";
                        da.SelectCommand = sqlcomm;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            return new DataSet();
        }

        public DataSet GetPurchase(string paramValue)
        {
            SqlConnection sqlConn = new SqlConnection(WebConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
            SqlCommand sqlcomm = new SqlCommand();

            sqlcomm.Connection = sqlConn;
            using (sqlConn)
            {
                try
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        sqlcomm.CommandText = "uspGetPurchase";
                        da.SelectCommand = sqlcomm;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            return new DataSet();
        }

        public DataSet GetRevenue(string paramValue)
        {
            SqlConnection sqlConn = new SqlConnection(WebConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
            SqlCommand sqlcomm = new SqlCommand();

            sqlcomm.Connection = sqlConn;
            using (sqlConn)
            {
                try
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        sqlcomm.CommandText = "uspGetRevenue";
                        da.SelectCommand = sqlcomm;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            return new DataSet();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
