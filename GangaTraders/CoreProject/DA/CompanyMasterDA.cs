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
    public class CompanyMasterDA
    {
        public DataTable tblCompanyMasterGetByID(int _ID)
        {
            try
            {
                var _DBAccess = new DBAccess();
                _DBAccess.AddParameter("@intCompanyID", _ID);
           
                return _DBAccess.ExecuteDataSet("sp_tblCompanyMasterGetByID").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public DataTable tblCompanyMasterGetByList()
        {
            try
            {
                var _DBAccess = new DBAccess();
               
                return _DBAccess.ExecuteDataSet("sp_tblCompanyMasterGetByList").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public int tblCompanyMasterAddEdit(CompanyMaster _clstblCompanyMaster, byte _byteAction, DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@strMobileNO", _clstblCompanyMaster.strMobileNO);
                _DBAccess.AddParameter("@strMobileNO1", _clstblCompanyMaster.strMobileNO1);
                _DBAccess.AddParameter("@strOfficeAddress", _clstblCompanyMaster.strOfficeAddress);
                _DBAccess.AddParameter("@strOfficeWorkAddress", _clstblCompanyMaster.strOfficeWorkAddress);
                _DBAccess.AddParameter("@strGSTINNo", _clstblCompanyMaster.strGSTINNo);
                _DBAccess.AddParameter("@strACNo", _clstblCompanyMaster.strACNo);
                _DBAccess.AddParameter("@strBankName", _clstblCompanyMaster.strBankName);
                _DBAccess.AddParameter("@strBranch", _clstblCompanyMaster.strBranch);
                _DBAccess.AddParameter("@IFSCCode", _clstblCompanyMaster.IFSCCode);
                if (_byteAction == 1)
                {
                 
                    var _SqlParameter = new SqlParameter("@intCompanyID", 0);
                    _SqlParameter.Direction = ParameterDirection.Output;
                    _DBAccess.Parameters.Add(_SqlParameter);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblCompanyMasterAdd");
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
                   
                    _DBAccess.AddParameter("@intCompanyID", _clstblCompanyMaster.intCompanyID);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblCompanyMasterEdit");
                    if (_intReturnValue > 0)
                    {
                        return _clstblCompanyMaster.intCompanyID;
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
        public bool tblCompanyMasterDelete(int _ID, DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@intCompanyID", _ID);
              
                var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblCompanyMasterDelete");
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
