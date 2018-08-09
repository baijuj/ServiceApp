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
            DataSet ds = GetDataSet("");
            List<Sales> result = new List<Sales>();
            result = ds.Tables[0].AsEnumerable().Select(dataRow => new Sales { Category = dataRow.Field<string>("Category"), Quantity = dataRow.Field<int>("Quantity") }).ToList();

            

            //result.Add(new Sales { Category = 2000, Volume = 100 });
            //result.Add(new Sales { Year = 2010, Volume = 900 });

            return result;
        }

        public DataSet GetDataSet(string paramValue)
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
                        //// This will be your input parameter and its value
                        //sqlcomm.Parameters.AddWithValue("@ParameterName", paramValue);

                        //// You can retrieve values of `output` variables
                        //var returnParam = new SqlParameter
                        //{
                        //    ParameterName = "@Error",
                        //    Direction = ParameterDirection.Output,
                        //    Size = 1000
                        //};
                        //sqlcomm.Parameters.Add(returnParam);
                        // Name of stored procedure
                        sqlcomm.CommandText = "uspGetSalesByCategory";
                        da.SelectCommand = sqlcomm;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }
                //catch (Exception ex)
                //{
                //    Console.WriteLine("SQL Error: " + ex.Message);
                //}
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
