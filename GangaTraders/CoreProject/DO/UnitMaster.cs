using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DO
{
   public class UnitMaster
    {
       public int _intUnitID;
       public string _strUnitName;

	public int intUnitID
	{ 
		get { return _intUnitID; }
		set { _intUnitID = value; }
	}
	public string strUnitName
	{ 
		get { return _strUnitName; }
		set { _strUnitName = value; }
	}
    }
}
