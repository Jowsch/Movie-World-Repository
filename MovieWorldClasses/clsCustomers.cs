using System;

namespace MovieWorldClasses
{
    public class clsCustomers
    {
        private Int32 mCustomerID;
        private String mFirstName;
        private DateTime mCreateDate;
        private String mLastName;
        private String mEmail;
        private bool mActive;
        public Int32 customer_id
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        public DateTime create_date {
            get
            {
                return mCreateDate;
            }
            set
            {
                mCreateDate = value;
            }
        }
        public string first_name {
            get
            {
                return mFirstName;
            }

            set
            {
                mFirstName = value;
            }
        }
        public string last_name {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public string email {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        public bool active {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public bool Find(int customer_id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@customer_id", customer_id);
            DB.Execute("sproc_tblCustomers_FilterByCustomerID");

            if (DB.Count == 1)
            {
            mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customer_id"]);
            mFirstName = Convert.ToString(DB.DataTable.Rows[0]["first_name"]);
            mLastName = Convert.ToString(DB.DataTable.Rows[0]["last_name"]);
            mEmail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
            mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["active"]);
            mCreateDate = Convert.ToDateTime(DB.DataTable.Rows[0]["create_date"]);
            return true;
            }
            
            else
            {
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string email, string createDate)
        {
            String Error = "";
            DateTime DateTemp;

            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank : ";
            }
          
            if (firstName.Length > 50)
            {
              
                Error = Error + "The first name must be less than 50 characters : ";
            }
            try
            {
              
                DateTemp = Convert.ToDateTime(createDate);
                if (DateTemp < DateTime.Now.Date)
                {
                   
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                { 
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            if (lastName.Length == 0)
            {
                Error = Error + "Your last name may not be blank : ";
            }
            if (lastName.Length > 50)
            {
                Error = Error + "your last name must be less than 50 characters : ";
            }
            if (email.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }
            if (email.Length > 50)
            {
                Error = Error + "The email must be less than 50 characters : ";
            }
            if (!email.Contains("@"))
            {
                Error = Error + "Email isnt in correct format 'doesnt contain @': ";
            }
            return Error;
        }
    }
}