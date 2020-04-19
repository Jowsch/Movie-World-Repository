using System;
using System.Collections.Generic;

namespace MovieWorldClasses
{
    public class clsCustomerCollection
    {
        List<clsCustomers> mCustomerList = new List<clsCustomers>();
        clsCustomers mThisCustomer = new clsCustomers();

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomers_SelectAll");

            PopulateArray(DB);
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
        public clsCustomers ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@first_name", mThisCustomer.first_name);
            DB.AddParameter("@last_name", mThisCustomer.last_name);
            DB.AddParameter("@email", mThisCustomer.email);
            DB.AddParameter("@active", mThisCustomer.active);
            DB.AddParameter("@create_date", mThisCustomer.create_date);

            return DB.Execute("sproc_tblCustomers_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@customer_id", mThisCustomer.customer_id);
            DB.Execute("sproc_tblCustomers_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@customer_id", mThisCustomer.customer_id);
            DB.AddParameter("@first_name", mThisCustomer.first_name);
            DB.AddParameter("@last_name", mThisCustomer.last_name);
            DB.AddParameter("@email", mThisCustomer.email);
            DB.AddParameter("@active", mThisCustomer.active);
            DB.AddParameter("@create_date", mThisCustomer.create_date);

            DB.Execute("sproc_tblCustomers_Update");
        }

        public void ReportByEmail(String Email)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Email", Email);
            DB.Execute("sproc_tblCustomers_FilterByEmail");

            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            RecordCount = DB.Count;

            mCustomerList = new List<clsCustomers>();

            while (Index < RecordCount)
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
    }
}