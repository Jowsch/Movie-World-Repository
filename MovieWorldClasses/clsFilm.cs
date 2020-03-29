using System;
using MovieWorldClasses;

namespace MovieWorldClasses
{
    public class clsFilm
    {
        private Int32 mFilmID;
        private string mFilmName;
        private string mFilmDescription;
        private string mFilmCertificate;
        private DateTime mFilmReleaseDate;
        private DateTime mFilmDepartureDate;
        private bool mFilmShowing;

        public int FilmID
        {
            get
            {
                return mFilmID;
            }
            set
            {
                mFilmID = value;
            }
        }

        public string FilmName
        {
            get
            {
                return mFilmName;
            }
            set
            {
                mFilmName = value;
            }
        }
        public string FilmDescription
        {
            get
            {
                return mFilmDescription;
            }
            set
            {
                mFilmDescription = value;
            }
        }

        public string FilmCertificate
        {
            get
            {
                return mFilmCertificate;
            }
            set
            {
                mFilmCertificate = value;
            }
        }

        public DateTime FilmReleaseDate
        {
            get
            {
                return mFilmReleaseDate;
            }
            set
            {
                mFilmReleaseDate = value;
            }
        }

        public DateTime FilmDepartureDate
        {
            get
            {
                return mFilmDepartureDate;
            }
            set
            {
                mFilmDepartureDate = value;
            }
        }

        public bool FilmShowing
        {
            get
            {
                return mFilmShowing;
            }
            set
            {
                mFilmShowing = value;
            }
        }

        public bool Find(int FilmID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FilmID", FilmID);
            DB.Execute("sproc_tblFilmManagement_FilterByFilmID");
            if (DB.Count == 1)
            {
                mFilmID = Convert.ToInt32(DB.DataTable.Rows[0]["FilmId"]);
                mFilmName = Convert.ToString(DB.DataTable.Rows[0]["FilmName"]);
                mFilmDescription = Convert.ToString(DB.DataTable.Rows[0]["FilmDescription"]);
                mFilmCertificate = Convert.ToString(DB.DataTable.Rows[0]["FilmCertificate"]);
                mFilmReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["FilmReleaseDate"]);
                mFilmDepartureDate = Convert.ToDateTime(DB.DataTable.Rows[0]["FilmDepartureDate"]);
                mFilmShowing = Convert.ToBoolean(DB.DataTable.Rows[0]["FilmShowing"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string filmName, string filmDescription, string filmCertificate, string filmReleaseDate, string filmDepartureDate)
        {
            //create string to hold variable for the error 
            String Error = "";
            DateTime DateTemp;

            if (filmName.Length == 0)
            {
                Error = Error + "The Film Name may not be blank : ";
            }

            if (filmName.Length > 250)
            {
                //max length set to 250 as this well exceeds any current film title length
                Error = Error + "The Film Name may not exceed 250 characters : ";
            }

            if (filmDescription.Length < 20)
            {
                Error = Error + "The Film Description may not be less than 20 characters long : ";
            }

            if (filmDescription.Length > 2000)
            {
                Error = Error + "The Film Description may not be More than 2000 characters long : ";
            }

            if (filmCertificate.Length == 0)
            {
                Error = Error + "The Film Certificate may not be blank : ";
            }

            if (filmCertificate.Length > 3)
            {
                Error = Error + "The Film Certificate may not be longer than 3 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(filmReleaseDate);
                if (DateTemp < new DateTime(1888, 1, 1))
                {
                    Error = Error + "No films were released at this date, please enter valid date : ";
                }

                if (DateTemp > DateTime.Now.Date.AddYears(+2))
                {
                    Error = Error + "Release dates can't be added more than 2 years in advance : ";
                }
            }
            catch
            {
                Error = Error + "The date entered was not a valid date";
            }

            try
            {
                DateTemp = Convert.ToDateTime(filmDepartureDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "Departure Date can't be set before todays date : ";
                }

                if (DateTemp > DateTime.Now.Date.AddYears(+1))
                {
                    Error = Error + "Departure dates can't be set more than one year in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date entered was not a valid date";
            }

            return Error;
        }
    }
}