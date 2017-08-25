using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DO
{
    public class OrderMaster
    {
        public int _intOrderTaxID;
        public string _intOrderId;
        public int _InvoiceNo;
        public DateTime _InvoiceDate;
        public DateTime _OrderDate;
        public int _FreightFwd;
        public decimal _TotalAmtBeforeTax;
        public int _CGSTPerc;
        public int _SGSTPerc;
        public int _IGSTPerc;
        public decimal _CGST;
        public decimal _SGST;
        public decimal _IGST;
        public decimal _TotalAmtGST;
        public decimal _roundOff;
        public decimal _GrandTotal;

        public int intOrderTaxID
        {
            get { return _intOrderTaxID; }
            set { _intOrderTaxID = value; }
        }
        public string intOrderId
        {
            get { return _intOrderId; }
            set { _intOrderId = value; }
        }
        public int InvoiceNo
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        }
        public DateTime InvoiceDate
        {
            get { return _InvoiceDate; }
            set { _InvoiceDate = value; }
        }
        public DateTime OrderDate
        {
            get { return _OrderDate; }
            set { _OrderDate = value; }
        }
        public int FreightFwd
        {
            get { return _FreightFwd; }
            set { _FreightFwd = value; }
        }
        public decimal TotalAmtBeforeTax
        {
            get { return _TotalAmtBeforeTax; }
            set { _TotalAmtBeforeTax = value; }
        }
        public int CGSTPerc
        {
            get { return _CGSTPerc; }
            set { _CGSTPerc = value; }
        }
        public int SGSTPerc
        {
            get { return _SGSTPerc; }
            set { _SGSTPerc = value; }
        }
        public int IGSTPerc
        {
            get { return _IGSTPerc; }
            set { _IGSTPerc = value; }
        }
        public decimal CGST
        {
            get { return _CGST; }
            set { _CGST = value; }
        }
        public decimal SGST
        {
            get { return _SGST; }
            set { _SGST = value; }
        }
        public decimal IGST
        {
            get { return _IGST; }
            set { _IGST = value; }
        }
        public decimal TotalAmtGST
        {
            get { return _TotalAmtGST; }
            set { _TotalAmtGST = value; }
        }
        public decimal roundOff
        {
            get { return _roundOff; }
            set { _roundOff = value; }
        }
        public decimal GrandTotal
        {
            get { return _GrandTotal; }
            set { _GrandTotal = value; }
        }
    }
}
