﻿using System;
using System.Collections.Generic;

namespace MovieWorldClasses
{
    public class clsCustomerCollection
    {
        List<clsCustomers> mCustomerList = new List<clsCustomers>();

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomers_SelectAll");

            RecordCount = DB.Count;

            while(Index < RecordCount)
            {
                clsCustomers ACustomer = new clsCustomers();

                ACustomer.active = Convert.ToBoolean(DB.DataTable.Rows[Index]["active"]);
                ACustomer.customer_id = Convert.ToInt32(DB.DataTable.Rows[Index]["customer_id"]);
                ACustomer.first_name = Convert.ToString(DB.DataTable.Rows[Index]["first_name"]);
                ACustomer.last_name = Convert.ToString(DB.DataTable.Rows[Index]["last_name"]);
                ACustomer.email = Convert.ToString(DB.DataTable.Rows[Index]["email"]);
                ACustomer.create_date = Convert.ToDateTime(DB.DataTable.Rows[Index]["create_date"]);

                mCustomerList.Add(ACustomer);

                Index++;
            }

        }
       
        public List<clsCustomers> CustomerList {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count {
            get
            {
                return mCustomerList.Count;
            }
            set 
            {

            }
            }
        public clsCustomers ThisCustomer { get; set; }
    }
}