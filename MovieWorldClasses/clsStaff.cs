using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieWorldClasses
{
    public class clsStaff
    {
        private Boolean mStaffActive;
        public bool StaffActive
        {
            get
            {
                return mStaffActive;
      
            }
            set
            {
                mStaffActive = value;
            }
        }

        private int mStaffPhoneNo;
        public int StaffPhoneNo
        {
            get
            {
                return mStaffPhoneNo;
            }
            set
            {
                mStaffPhoneNo = value;
            }
        }

        private object mStaffName;
        public object StaffName
        {
            get
            {
                return mStaffName;

            }
            set
            {
                mStaffName = value;
            }
        }

        private object mStaffSalary;
        public object StaffSalary
        {
            get
            {
                return mStaffSalary;
            }
            set
            {
                mStaffSalary = value;
            }
        }

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaffManagement_FilterByStaffID");
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffPhoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffPhoneNo"]);
                mStaffSalary = Convert.ToDecimal(DB.DataTable.Rows[0]["StaffSalary"]);
                mStaffActive = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffActive"]); ;
                return true;
            }
            else
            {
                return false;
            }
        }


        private Int32 mStaffID;
        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

        private DateTime mStaffDOB;
        public DateTime StaffDOB
        {
            get
            {
                return mStaffDOB;
            }
            set
            {
                mStaffDOB = value;
            }
        }

        public bool Find(object staffID)
        {
            throw new NotImplementedException();

        }

        
public string Valid(string staffName, string staffPhoneNo, string staffSalary, string staffDOB)
        {
            return "";
        }
    }

}