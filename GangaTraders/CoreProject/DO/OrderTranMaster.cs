using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DO
{
    public class OrderTranMaster
    {
        public int _intOrderId;
        public int _intCustomerID;
        public int _intSNo;
        public int _intItemID;
        public decimal _decQty;
        public decimal _decRate;
        public decimal _decTotalAmt;

        public int intOrderId
        {
            get { return _intOrderId; }
            set { _intOrderId = value; }
        }
        public int intCustomerID
        {
            get { return _intCustomerID; }
            set { _intCustomerID = value; }
        }
        public int intSNo
        {
            get { return _intSNo; }
            set { _intSNo = value; }
        }
        public int intItemID
        {
            get { return _intItemID; }
            set { _intItemID = value; }
        }
        public decimal decQty
        {
            get { return _decQty; }
            set { _decQty = value; }
        }
        public decimal decRate
        {
            get { return _decRate; }
            set { _decRate = value; }
        }
        public decimal decTotalAmt
        {
            get { return _decTotalAmt; }
            set { _decTotalAmt = value; }
        }
    }
}
