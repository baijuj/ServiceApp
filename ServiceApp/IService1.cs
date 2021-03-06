﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Sales> GetSaleData();

        [OperationContract]
        List<SalesCommon> GetQuarterlySales();

        [OperationContract]
        List<SalesCommon> GetPurchase();

        [OperationContract]
        List<SalesCommon> GetRevenue();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Sales
    {
        [DataMember]
        public string Category { get; set; }

        [DataMember]
        public int Quantity { get; set; }
    }

    [DataContract]
    public class SalesCommon
    {
        [DataMember]
        public string Year { get; set; }

        [DataMember]
        public string Quarter { get; set; }

        [DataMember]
        public int Sales { get; set; }
    }
}
