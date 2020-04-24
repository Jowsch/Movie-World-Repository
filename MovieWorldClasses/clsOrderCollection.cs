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
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
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
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisOrder.Customer_Id);
            DB.AddParameter("@StaffId", mThisOrder.Staff_Id);
            DB.AddParameter("@TotalCost", mThisOrder.TotalCost);
            DB.AddParameter("@DateOfOrder", mThisOrder.DateOfOrder);
            DB.AddParameter("@AvailableSeats", mThisOrder.OrderNo);
                   
                   return DB.Execute("sproc_Tableorder_Insert");
               }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("sproc_TableOrder_Delete");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@CustomerID", mThisOrder.Customer_Id);
            DB.AddParameter("@StaffId", mThisOrder.Staff_Id);
            DB.AddParameter("@TotalCost", mThisOrder.TotalCost);
            DB.AddParameter("@DateOfOrder", mThisOrder.DateOfOrder);
            DB.AddParameter("@AvailableSeats", mThisOrder.OrderNo);

            DB.Execute("sproc_TableOrder_Update");
        }
//        public void ReportByCustomerId(String CustomerId)
//        {
//            clsDataConnection DB = new clsDataConnection();

//            DB.AddParameter("@CustomerId", CustomerId);
//            DB.Execute("sproc_TableOrder_FilterByCustomerId");

 //           PopulateArray(DB);
 //       }

//        public void PopulateArray(clsDataConnection DB)
//        {
//            Int32 Index = 0;
//            Int32 RecordCount = 0;

//            RecordCount = DB.Count;

//            mOrderList = new List<clsOrder>();
//
//           while (Index < RecordCount)
//            {
//                clsOrder AnOrder = new clsOrder();

//                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
//                AnOrder.Customer_Id = Convert.ToString(DB.DataTable.Rows[Index]["CustomerId"]);
//                AnOrder.Staff_Id = Convert.ToString(DB.DataTable.Rows[Index]["StaffId"]);
 //               AnOrder.TotalCost = Convert.ToString(DB.DataTable.Rows[Index]["TotalCost"]);
 //               AnOrder.AvailableSeats = Convert.ToBoolean(DB.DataTable.Rows[Index]["AvailableSeats"]);
 //               AnOrder.DateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfOrder"]);
//
 //               mOrderList.Add(AnOrder);
//
 //               Index++;
 //           }
 //       }
    }

    }

