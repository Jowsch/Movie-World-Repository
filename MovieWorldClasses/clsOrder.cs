﻿using MovieWorldClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Class_Library
{
    public class clsOrder
    {

        public Boolean Find(int OrderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", OrderNo);
            DB.Execute("sproc_Tableorder_FilterByOrderNo");


            if (DB.Count == 1)


            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomer_Id = Convert.ToString(DB.DataTable.Rows[0]["CustomerId"]);
                mStaff_Id = Convert.ToString(DB.DataTable.Rows[0]["StaffId"]);
                mTotalCost = Convert.ToString(DB.DataTable.Rows[0]["TotalCost"]);
                mAvailableSeats = Convert.ToBoolean(DB.DataTable.Rows[0]["AvailableSeats"]);
                mDateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfOrder"]);
                return true;
            }
            else
            {
                return false;


            }
        }

        private Boolean mAvailableSeats;
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
        public Int32 OrderNo
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
        private string mCustomer_Id;
        public string Customer_Id
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


        private string mStaff_Id;

        public string Staff_Id
        {
            get
            {

                return mStaff_Id;
            }
            set
            {
                mStaff_Id = value;

            }
        }




        private string mTotalCost;


        public string TotalCost
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

        public string Valid(string Customer_Id, string Staff_Id, string TotalCost, string DateOfOrder)
        {
            String Error = "";
            DateTime DateTemp;

            try
            {
                DateTemp = Convert.ToDateTime(DateOfOrder);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: ";

                }
                if (DateTemp > DateTime.Now.Date)
                {

                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a Valid Date: ";
            }
            if (Staff_Id.Length == 0)
            {
                Error = Error + "The Staff Id may not be blank: ";
            }
            if (Staff_Id.Length > 50)
            {
                Error = Error + "The Staff Id must not be more than 50 characters: ";
            }
            if (Customer_Id.Length == 0)
            {
                Error = Error + "The Customer Id may not be blank: ";
            }
            if (Customer_Id.Length > 50)
            {
                Error = Error + "The Customer Id must not be more than 50 characters: ";
            }
            if (TotalCost.Length == 0)
            {
                Error = Error + "The Total Cost may not be blank: ";
            }
            if (TotalCost.Length > 50)
            {
                Error = Error + "The Total Cost must not be more than 50 characters: ";
            }
            


                return Error;
            }



        }

    }



