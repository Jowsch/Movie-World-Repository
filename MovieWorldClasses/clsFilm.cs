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

        public Int32 FilmID
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

        /*public bool Find(int FilmID)
        {
            mFilmID = 10;
            mFilmName = "Test Name";
            mFilmDescription = "Test Description";
            mFilmCertificate = "15";
            mFilmReleaseDate = Convert.ToDateTime("03/09/1996");
            mFilmDepartureDate = Convert.ToDateTime("07/09/1996");
            mFilmShowing = true;

            return true;
        }*/

        public bool Find(int FilmID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FilmID", FilmID);
            DB.Execute("sproc_tblFilmManagement_FilterByFilmID");
            if (DB.Count == 1)
            {
                mFilmID = Convert.ToInt32(DB.DataTable.Rows[0]["FilmId"]);
                mFilmName = Convert.ToString(DB.DataTable.Rows[0]["FilmName"]);
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
    }
}