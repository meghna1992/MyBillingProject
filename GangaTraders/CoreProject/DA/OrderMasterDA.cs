using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CoreProject.DO;
using CoreProject.DA;
using CoreProject.Manage;
using Microsoft.ApplicationBlocks.Data;
namespace CoreProject.DA
{
    public class OrderMasterDA
    {
        public DataTable OrderDetailGetByID(int _ID)
        {
            try
            {
                var _DBAccess = new DBAccess();
                _DBAccess.AddParameter("@intOrderTaxID", _ID);
                return _DBAccess.ExecuteDataSet("sp_OrderDetailGetByID").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public DataTable OrderDetailGetByList()
        {
            try
            {
                var _DBAccess = new DBAccess();
              
                return _DBAccess.ExecuteDataSet("sp_OrderDetailGetByList").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public int OrderDetailAddEdit(OrderMaster _clsOrderDetail, byte _byteAction, DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@intOrderId", _clsOrderDetail.intOrderId);
                _DBAccess.AddParameter("@InvoiceNo", _clsOrderDetail.InvoiceNo);
                _DBAccess.AddParameter("@InvoiceDate", _clsOrderDetail.InvoiceDate);
                _DBAccess.AddParameter("@OrderDate", _clsOrderDetail.OrderDate);
                _DBAccess.AddParameter("@FreightFwd", _clsOrderDetail.FreightFwd);
                _DBAccess.AddParameter("@TotalAmtBeforeTax", _clsOrderDetail.TotalAmtBeforeTax);
                _DBAccess.AddParameter("@CGSTPerc", _clsOrderDetail.CGSTPerc);
                _DBAccess.AddParameter("@SGSTPerc", _clsOrderDetail.SGSTPerc);
                _DBAccess.AddParameter("@IGSTPerc", _clsOrderDetail.IGSTPerc);
                _DBAccess.AddParameter("@CGST", _clsOrderDetail.CGST);
                _DBAccess.AddParameter("@SGST", _clsOrderDetail.SGST);
                _DBAccess.AddParameter("@IGST", _clsOrderDetail.IGST);
                _DBAccess.AddParameter("@TotalAmtGST", _clsOrderDetail.TotalAmtGST);
                _DBAccess.AddParameter("@roundOff", _clsOrderDetail.roundOff);
                _DBAccess.AddParameter("@GrandTotal", _clsOrderDetail.GrandTotal);
                if (_byteAction == 1)
                {
                   
                    _DBAccess.AddParameter("@intOrderTaxID", _clsOrderDetail.intOrderTaxID);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_OrderDetailAdd");
                    if (_intReturnValue > 0)
                    {
                        return Convert.ToInt32(_intReturnValue);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                   
                    _DBAccess.AddParameter("@intOrderTaxID", _clsOrderDetail.intOrderTaxID);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_OrderDetailEdit");
                    if (_intReturnValue > 0)
                    {
                        return _clsOrderDetail.intOrderTaxID;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public bool OrderDetailDelete(int _ID,  DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@intOrderTaxID", _ID);
             
                var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_OrderDetailDelete");
                if (_intReturnValue > 0)
                {
                    return true;
                }
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
            return false;
        }
    }
}
