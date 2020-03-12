using MovieWorldClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Class_Library
{
    public class clsOrder
    {
        private Boolean mAVailableSeats;
        public bool AvailableSeats
        {
            get
            {
                return mAvailableSeats;
            }
            set
            {

                mAvailableSeats = value;
            }
        }
        private DateTime mDateOfOrder;
        public DateTime DateOfOrder
        {
            get
            {
                return mDateOfOrder;
            }
            set
            {
                mDateOfOrder = value;
            }
        }
        private Int32 mOrderNo;
        public int OrderNo
        {
            get
            {

                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
        private Int32 mCustomer_Id;
            public int CUstomerId
        {
            get
            {
                return mCustomer_Id;
            }
            set
            {
                mCustomer_Id = value;
            }
        }
        private int mStaff_Id;

        public int Staff_Id
        {
            get
            {
                //return private data
                return mStaff_Id;
            }
            set
            {
                //set the private data
                mStaff_Id = value;
            }
        }

        private decimal mTotalCost;
        private bool mAvailableSeats;

        public decimal TotalCost
        {
            get
            {
                return mTotalCost;
            }
            set
            {
                mTotalCost = value;
            }
        }




        public bool Find(int OrderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", OrderNo);
            DB.Execute("sproc_tblAddress_FilterByOrderNo");       


            if(DB.Count == 1)


    {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomer_Id = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_Id"]);
                mStaff_Id = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_Id"]);
                mTotalCost = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalCost"]);
                mAvailableSeats = Convert.ToBoolean(DB.DataTable.Rows[0]["AvailableSeats"]);
                mDateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfOrder"]);
                return true;
            }
        }
    }
