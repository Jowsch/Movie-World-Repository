using System;
using System.Collections.Generic;
using Class_Library;
using MovieWorldClasses;

namespace Class_Library
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
          Int32 Index = 0;
          Int32 RecordCount = 0;

          clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_TableOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderNo = Convert.ToString(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.Customer_Id = Convert.ToString(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.Staff_Id = Convert.ToString(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrder.TotalCost = Convert.ToString(DB.DataTable.Rows[Index]["TotalCost"]);
                AnOrder.AvailableSeats = Convert.ToBoolean(DB.DataTable.Rows[Index]["AvailableSeats"]);
                AnOrder.DateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfOrder"]);
                mOrderList.Add(AnOrder);
                Index++;
            }

        }
        

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }
             public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;

            }
            set
            {
                mThisOrder = value;

            }
        }

        //       public int Add()
        //       {
        //           clsDataConnection DB = new clsDataConnection();
        //           Db.AddParameter("CustomerId", mThisOrder.customerId
        //           Db.AddParameter("staffid", mThisOrder.StaffID
        //           Db.AddParameter("TOTALCOST", mThisOrder.TOTALCOST
        //           Db.AddParameter("DATEOFORDER", mThisOrder.DATEOFORDER
        //           Db.AddParameter("AVAILABE SEATS", mThisOrder.OrderNo
        //           
        //           return Db.Execute("sproc_tblOrder_Insert");
        //       }
    }
}
