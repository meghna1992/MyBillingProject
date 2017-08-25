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
   public class ItemMasterDA
    {
        public DataTable tblItemMasterGetByID(int _ID)
        {
            try
            {
                var _DBAccess = new DBAccess();
                _DBAccess.AddParameter("@intItemID", _ID);
              
                return _DBAccess.ExecuteDataSet("sp_tblItemMasterGetByID").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public DataTable tblItemMasterGetByList()
        {
            try
            {
                var _DBAccess = new DBAccess();
                
                return _DBAccess.ExecuteDataSet("sp_tblItemMasterGetByList").Tables[0];
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public int tblItemMasterAddEdit(ItemMaster _clstblItemMaster, byte _byteAction, DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@strItemName", _clstblItemMaster.strItemName);
                _DBAccess.AddParameter("@intUnitID", _clstblItemMaster.intUnitID);
                _DBAccess.AddParameter("@strHSNNo", _clstblItemMaster.strHSNNo);
                if (_byteAction == 1)
                {
                   
                    var _SqlParameter = new SqlParameter("@intItemID", 0);
                    _SqlParameter.Direction = ParameterDirection.Output;
                    _DBAccess.Parameters.Add(_SqlParameter);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblItemMasterAdd");
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
                   
                    _DBAccess.AddParameter("@intItemID", _clstblItemMaster.intItemID);
                    var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblItemMasterEdit");
                    if (_intReturnValue > 0)
                    {
                        return _clstblItemMaster.intItemID;
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
        public bool tblItemMasterDelete(int _ID,DBAccess _DBAccess)
        {
            try
            {
                _DBAccess.Parameters.Clear();
                _DBAccess.AddParameter("@intItemID", _ID);
               
                var _intReturnValue = _DBAccess.ExecuteNonQuery("sp_tblItemMasterDelete");
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
