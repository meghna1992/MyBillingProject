using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DO
{
     public class CustomerMaster
    {
        public int _intCustomerID;
        public string _strCustomerName;
        public string _strGSTINNo;
        public string _strState;
        public string _strStateCode;
        public string _strPayementTerm;
        public string _strTransportationMode;
        public string _strAddress;

        public int intCustomerID
        {
            get { return _intCustomerID; }
            set { _intCustomerID = value; }
        }
        public string strCustomerName
        {
            get { return _strCustomerName; }
            set { _strCustomerName = value; }
        }
        public string strGSTINNo
        {
            get { return _strGSTINNo; }
            set { _strGSTINNo = value; }
        }
        public string strState
        {
            get { return _strState; }
            set { _strState = value; }
        }
        public string strStateCode
        {
            get { return _strStateCode; }
            set { _strStateCode = value; }
        }
        public string strPayementTerm
        {
            get { return _strPayementTerm; }
            set { _strPayementTerm = value; }
        }
        public string strTransportationMode
        {
            get { return _strTransportationMode; }
            set { _strTransportationMode = value; }
        }
        public string strAddress
        {
            get { return _strAddress; }
            set { _strAddress = value; }
        }
    }
}
