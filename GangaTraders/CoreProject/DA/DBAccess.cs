using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace CoreProject.DA
{
    public class DBAccess
    {
        private IDbCommand _SqlCommand = new SqlCommand();
        private SqlTransaction _transaction;
      
        private SqlConnection Connection;
        private SqlTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
            }
        }
        #region Database Access

        public DBAccess(string _InitialCatalog = "", Boolean _StoredProcedure = true,Boolean _IsBegintranprocess = false)
        {
            try
            {
                var _SqlConnection = new SqlConnection();

                string cnn = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                
                _SqlConnection.ConnectionString = cnn;
                Connection = _SqlConnection;
                _SqlCommand.Connection = Connection;
                _SqlCommand.CommandTimeout = 120;

                if (_StoredProcedure == true)
                {
                    _SqlCommand.CommandType = CommandType.StoredProcedure;
                }
                if (_IsBegintranprocess == true)
                {
                    BeginTransaction();
                }
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }       
        #endregion
        #region Commit Trans
        
        private void BeginTransaction()
        {
            
            this.Connection.Open();
            this.Transaction = this.Connection.BeginTransaction();
           
            _SqlCommand.Transaction = this.Transaction;

            
        }
        public void CommitTransaction()
        {
            Transaction.Commit();
            Connection.Close();
        }
        public void RollbackTransaction()
        {
            // Rollback the transaction
            this.Transaction.Rollback();
            // Close the connection
            this.Connection.Close();
        }
        #endregion
        #region Execute Reader
        public IDataReader ExecuteReader()
        {
            try
            {
                var _IDataReader = (IDataReader)null;
                _SqlCommand.Connection.Open();
                _IDataReader = _SqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return _IDataReader;

            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }

        }
        public IDataReader ExecuteReader(string _strCommandtext)
        {
            try
            {
                var _IDataReader = (IDataReader)null;
                _SqlCommand.CommandText = _strCommandtext;
                _IDataReader = ExecuteReader();
                return _IDataReader;
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        #endregion

        #region Execute Non Query
        public int ExecuteNonQuery()
        {
            try
            {
                var i = -1;
                if (_SqlCommand.Connection.State == 0)
                {
                    _SqlCommand.Connection.Open();
                }
                
                i = _SqlCommand.ExecuteNonQuery();
                //this.Dispose();
                return i;
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        public int ExecuteNonQuery(string _strCommandtext)
        {
            try
            {
                var i = -1;
                _SqlCommand.CommandText = _strCommandtext;
                i = ExecuteNonQuery();
                return i;
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }
        }
        #endregion

        #region Execute Data Set
        public DataSet ExecuteDataSet()
        {
            try
            {
                var _SqlDataAdapter = (SqlDataAdapter)null;
                var _DataSet = (DataSet)null;
                _SqlDataAdapter = new SqlDataAdapter();
                _SqlDataAdapter.SelectCommand = (SqlCommand)_SqlCommand;
                _DataSet = new DataSet("Table");
                _SqlDataAdapter.Fill(_DataSet);
                return _DataSet;
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }

        }
        public DataSet ExecuteDataSet(string _strCommandtext)
        {
            try
            {
                var _DataSet = (DataSet)null;
                _SqlCommand.CommandText = _strCommandtext;
                _DataSet = ExecuteDataSet();
                return _DataSet;
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }

        }
        #endregion

        #region Execute GetList
        public SqlDataReader ExecuteGetList(string _strCommandtext)
        {
            try
            {
                if (_SqlCommand.Connection.State == 0)
                {
                    _SqlCommand.Connection.Open();
                }
                var _SqlDataAdapter = (SqlDataAdapter)null;
                _SqlDataAdapter = new SqlDataAdapter();
                _SqlDataAdapter.SelectCommand = (SqlCommand)_SqlCommand;
                _SqlCommand.CommandText = _strCommandtext;
                SqlDataReader dreader = _SqlDataAdapter.SelectCommand.ExecuteReader();
                return dreader;
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }

        }
        
        #endregion

        #region Execute Scalar
        public object ExecuteScalar()
        {
            try
            {
                var _object = (object)null;
                _SqlCommand.Connection.Open();
                _object = _SqlCommand.ExecuteScalar();
                this.Dispose();
                return _object;
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }

        }
        public object ExecuteScalar(string _strCommandtext)
        {
            try
            {
                var _object = (object)null;
                _SqlCommand.CommandText = _strCommandtext;
                _object = ExecuteScalar();
                return _object;
            }
            catch (Exception _Exception)
            {
                throw _Exception;
            }

        }
        #endregion

        #region Add Parameter
        public void AddParameter(IDataParameter _IDataParameter)
        {
            _SqlCommand.Parameters.Add(_IDataParameter);
        }
        public void AddParameter(string _strparameterName, object _objparameterValue)
        {
            var _SqlParameter = new SqlParameter(_strparameterName, _objparameterValue);
            _SqlCommand.Parameters.Add(_SqlParameter);
        }
        public void AddParameter(string _strparameterName, object _objparameterValue, SqlDbType _SqlDbType)
        {
            var _SqlParameter = new SqlParameter(_strparameterName, _objparameterValue);
            _SqlParameter.SqlDbType=_SqlDbType;
            _SqlCommand.Parameters.Add(_SqlParameter);
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            try
            {
                _SqlCommand.Connection.Close();
                _SqlCommand.Dispose();
            }
            catch
            {

            }
        }
        #endregion

        #region Public Properties
        public string CommandText
        {
            get
            {
                return _SqlCommand.CommandText;
            }
            set
            {
                _SqlCommand.CommandText = value;
                _SqlCommand.Parameters.Clear();
            }
        }
        public IDataParameterCollection Parameters
        {
            get
            {
                return _SqlCommand.Parameters;
            }
        }
        #endregion
    }
}
