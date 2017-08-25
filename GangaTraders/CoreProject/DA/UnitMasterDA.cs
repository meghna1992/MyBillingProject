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
    public class UnitMasterDA
    {
        public DataTable tblUnitMasterGetByID(int _ID)
        {
            try
            {
                var _DBAccess = new DBAccess();
                _DBAccess.AddParameter("@intUnitID", _ID);
             
                return _DBAccess.ExecuteDataSet("sp_tblUnitMasterGetByID").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public DataTable tblUnitMasterGetByList()
        {
            try
            {
                var _DBAccess = new DBAccess();
              
                return _DBAccess.ExecuteDataSet("sp_tblUnitMasterGetByList").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public int tblUnitMasterAddEdit(UnitMaster _clstblUnitMaster, byte _byteAction, DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@strUnitName", _clstblUnitMaster.strUnitName);
                if (_byteAction == 1)
                {
                  
                    var _SqlParameter = new SqlParameter("@intUnitID", 0);
                    _SqlParameter.Direction = ParameterDirection.Output;
                    _DBAccess.Parameters.Add(_SqlParameter);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblUnitMasterAdd");
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
                    _DBAccess.AddParameter("@intUnitID", _clstblUnitMaster.intUnitID);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblUnitMasterEdit");
                    if (_intReturnValue > 0)
                    {
                        return _clstblUnitMaster.intUnitID;
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
        public bool tblUnitMasterDelete(int _ID, DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@intUnitID", _ID);
              
                var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblUnitMasterDelete");
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
