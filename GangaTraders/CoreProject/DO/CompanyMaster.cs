using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DO
{
    public class CompanyMaster
    {
        public int _intCompanyID;
        public string _strMobileNO;
        public string _strMobileNO1;
        public string _strOfficeAddress;
        public string _strOfficeWorkAddress;
        public string _strGSTINNo;
        public string _strACNo;
        public string _strBankName;
        public string _strBranch;
        public string _IFSCCode;

        public int intCompanyID
        {
            get { return _intCompanyID; }
            set { _intCompanyID = value; }
        }
        public string strMobileNO
        {
            get { return _strMobileNO; }
            set { _strMobileNO = value; }
        }
        public string strMobileNO1
        {
            get { return _strMobileNO1; }
            set { _strMobileNO1 = value; }
        }
        public string strOfficeAddress
        {
            get { return _strOfficeAddress; }
            set { _strOfficeAddress = value; }
        }
        public string strOfficeWorkAddress
        {
            get { return _strOfficeWorkAddress; }
            set { _strOfficeWorkAddress = value; }
        }
        public string strGSTINNo
        {
            get { return _strGSTINNo; }
            set { _strGSTINNo = value; }
        }
        public string strACNo
        {
            get { return _strACNo; }
            set { _strACNo = value; }
        }
        public string strBankName
        {
            get { return _strBankName; }
            set { _strBankName = value; }
        }
        public string strBranch
        {
            get { return _strBranch; }
            set { _strBranch = value; }
        }
        public string IFSCCode
        {
            get { return _IFSCCode; }
            set { _IFSCCode = value; }
        }
    }
}
