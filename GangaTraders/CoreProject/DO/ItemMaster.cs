using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DO
{
    public class ItemMaster
    {
        public int _intItemID;
        public string _strItemName;
        public int _intUnitID;
        public Int64 _strHSNNo;

        public int intItemID
        {
            get { return _intItemID; }
            set { _intItemID = value; }
        }
        public string strItemName
        {
            get { return _strItemName; }
            set { _strItemName = value; }
        }
        public int intUnitID
        {
            get { return _intUnitID; }
            set { _intUnitID = value; }
        }
        public Int64 strHSNNo
        {
            get { return _strHSNNo; }
            set { _strHSNNo = value; }
        }
    }

}
