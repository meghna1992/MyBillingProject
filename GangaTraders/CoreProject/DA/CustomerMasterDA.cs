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
    public class CustomerMasterDA
    {
        public DataTable tblCustomerMasterGetByID(int _ID)
        {
            try
            {
                var _DBAccess = new DBAccess();
                _DBAccess.AddParameter("@intCustomerID", _ID);

                return _DBAccess.ExecuteDataSet("sp_tblCustomerMasterGetByID").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public DataTable tblCustomerMasterGetByList()
        {
            try
            {
                var _DBAccess = new DBAccess();
              
                return _DBAccess.ExecuteDataSet("sp_tblCustomerMasterGetByList").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public int tblCustomerMasterAddEdit(CustomerMaster _clstblCustomerMaster, byte _byteAction, DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@strCustomerName", _clstblCustomerMaster.strCustomerName);
                _DBAccess.AddParameter("@strGSTINNo", _clstblCustomerMaster.strGSTINNo);
                _DBAccess.AddParameter("@strState", _clstblCustomerMaster.strState);
                _DBAccess.AddParameter("@strStateCode", _clstblCustomerMaster.strStateCode);
                _DBAccess.AddParameter("@strPayementTerm", _clstblCustomerMaster.strPayementTerm);
                _DBAccess.AddParameter("@strTransportationMode", _clstblCustomerMaster.strTransportationMode);
                _DBAccess.AddParameter("@strAddress", _clstblCustomerMaster.strAddress);
                if (_byteAction == 1)
                {
                    var _SqlParameter = new SqlParameter("@intCustomerID", 0);
                    _SqlParameter.Direction = ParameterDirection.Output;
                    _DBAccess.Parameters.Add(_SqlParameter);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblCustomerMasterAdd");
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
                    
                    _DBAccess.AddParameter("@intCustomerID", _clstblCustomerMaster.intCustomerID);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblCustomerMasterEdit");
                    if (_intReturnValue > 0)
                    {
                        return _clstblCustomerMaster.intCustomerID;
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
        public bool tblCustomerMasterDelete(int _ID,  DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@intCustomerID", _ID);
            
                var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblCustomerMasterDelete");
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
