﻿using clinicDenoDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace clinicDenoDB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        Clinic GetClinicByName(string givenClinicName);
        [OperationContract]
        int CreateClinic( string address, string phoneNum, string email, string clinicName, string clinicType, TimeSpan startTime, TimeSpan endTime);
        [OperationContract]
        List<Clinic> GetAllClinic();
        [OperationContract]
        int CreateClinicAdmin(string email, string phoneNum, string firstName, string lastName, DateTime dob, string gender, string password, string clinicId, string verificationId);
        [OperationContract]
        void UpdateAdminVerifyStatus(string verificationId);
        [OperationContract]
        string AdminLoginVerify(string email, string password);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "clinicDenoDB.ContractType".
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
}
