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

        public bool Find(int customerNum)
        {
            mCustomerID = 26;
            mFirstName = "Joe";
            mLastName = "Bloggs";
            mEmail = "JoeBloggs@outlook.com";
            mActive = true;
            mCreateDate = Convert.ToDateTime("13/01/1999");
            return true;
        }
    }
}