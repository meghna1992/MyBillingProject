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
    public class OrderTranDA
    {
        public DataTable tblOrderTransactionGetByID(int _ID)
        {
            try
            {
                var _DBAccess = new DBAccess();
                _DBAccess.AddParameter("@intOrderId", _ID);
                return _DBAccess.ExecuteDataSet("sp_tblOrderTransactionGetByID").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public DataTable tblOrderTransactionGetByList()
        {
            try
            {
                var _DBAccess = new DBAccess();
             
                return _DBAccess.ExecuteDataSet("sp_tblOrderTransactionGetByList").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public int tblOrderTransactionAddEdit(OrderTranMaster _clstblOrderTransaction, byte _byteAction, DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@intCustomerID", _clstblOrderTransaction.intCustomerID);
                _DBAccess.AddParameter("@intSNo", _clstblOrderTransaction.intSNo);
                _DBAccess.AddParameter("@intItemID", _clstblOrderTransaction.intItemID);
                _DBAccess.AddParameter("@decQty", _clstblOrderTransaction.decQty);
                _DBAccess.AddParameter("@decRate", _clstblOrderTransaction.decRate);
                _DBAccess.AddParameter("@decTotalAmt", _clstblOrderTransaction.decTotalAmt);
                if (_byteAction == 1)
                {
                    
                    var _SqlParameter = new SqlParameter("@intOrderId", 0);
                    _SqlParameter.Direction = ParameterDirection.Output;
                    _DBAccess.Parameters.Add(_SqlParameter);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblOrderTransactionAdd");
                    if (_intReturnValue > 0)
                    {
                        return Convert.ToInt32(_SqlParameter.Value);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                   
                    _DBAccess.AddParameter("@intOrderId", _clstblOrderTransaction.intOrderId);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblOrderTransactionEdit");
                    if (_intReturnValue > 0)
                    {
                        return _clstblOrderTransaction.intOrderId;
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
            return 0;
        }
        public bool tblOrderTransactionDelete(int _ID, DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@intOrderId", _ID);
              
                var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblOrderTransactionDelete");
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
