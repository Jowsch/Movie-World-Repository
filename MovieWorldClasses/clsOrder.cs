using MovieWorldClasses;
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
                mOrderNo = Convert.ToString(DB.DataTable.Rows[0]["OrderNo"]);
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
        private string mOrderNo;
        public string OrderNo
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

        public string Valid(string OrderNo, string Customer_Id, string Staff_Id, string TotalCost, string AvailableSeats, string DateOfOrder)
        {
            String Error = ""; DateTime DateTemp;
            if (OrderNo.Length == 0)
            {
                Error = Error + "The order No may not be blank: ";
            }
            if (OrderNo.Length > 6)
            {
                Error = Error + "The order No must be less than 6 characters: ";
            }
            DateTemp = Convert.ToDateTime(DateOfOrder);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future : ";
            }
            if (Staff_Id == 0)
            {
                Error = Error + "The Staff ID may not be blank: ";
            }
            if (Staff_Id.Length > 6)
            {
                Error = Error + "The Staff Id must be less than 6 characters: ";
            }
            if (CustomerId == 0)
            {
                Error = Error + "The Staff ID may not be blank: ";
            }
            if (Customer_Id.Length > 6)
            {
                Error = Error + "The Customer Id must be less than 6 characters: ";
            }

            return Error;
        }

    }
}


        
    }
}

    
   public string Valid(string OrderNo, string Customer_Id, string Staff_Id, string TotalCost, string AvailableSeats, string DateOfOrder)
    {
        String Error = "";       DateTime DateTemp;
       if(OrderNo.Length == 0)
{
               Error = Error + "The order No may not be blank: ";
           }
          if(OrderNo.Length > 6)
{
              Error = Error + "The order No must be less than 6 characters: ";
          }
          DateTemp = Convert.ToDateTime(DateOfOrder);
         if (DateTemp < DateTime.Now.Date)
         {
            Error = Error + "The date cannot be in the past : ";
        }
        if (DateTemp > DateTime.Now.Date)
      {           Error = Error + "The date cannot be in the future : ";
       }
      if (this.Staff_Id == 0) 
{
            Error = Error + "The Staff ID may not be blank: ";
       }
       if(Staff_Id.Length > 6)
{
          Error = Error + "The Staff Id must be less than 6 characters: ";
     }
     if(CustomerId == 0)
{
         Error = Error + "The Staff ID may not be blank: ";
          }
         if(Customer_Id.Length > 6){
             Error = Error + "The Customer Id must be less than 6 characters: ";
         }

       return Error;
    }

  }
}

