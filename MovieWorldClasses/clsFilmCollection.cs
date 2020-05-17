using System;
using System.Collections.Generic;

namespace MovieWorldClasses
{
    public class clsFilmCollection
    {
        List<clsFilm> mFilmList = new List<clsFilm>();
        clsFilm mThisFilm = new clsFilm();
        

        public clsFilmCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            PopulateArray(DB);

            DB.Execute("sproc_tblFilm_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount) 
            {
                clsFilm AFilm = new clsFilm();

                AFilm.FilmID = Convert.ToInt32(DB.DataTable.Rows[Index]["FilmId"]);
                AFilm.FilmName = Convert.ToString(DB.DataTable.Rows[Index]["FilmName"]);
                AFilm.FilmDescription = Convert.ToString(DB.DataTable.Rows[Index]["FilmDescription"]);
                AFilm.FilmCertificate = Convert.ToString(DB.DataTable.Rows[Index]["FilmCertificate"]);
                AFilm.FilmReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["FilmReleaseDate"]);
                AFilm.FilmDepartureDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["FilmDepartureDate"]);
                AFilm.FilmShowing = Convert.ToBoolean(DB.DataTable.Rows[Index]["FilmShowing"]);
                //add the record to the private data member
                mFilmList.Add(AFilm);
                //point at the next record
                Index++;
            }
        }

        public List<clsFilm> FilmList
        {
            get
            {
                return mFilmList;
            }

            set
            {
                mFilmList = value;
            }
        }
        public clsFilm ThisFilm
        {
            get
            {
                return mThisFilm;
            }
            set
            {
                mThisFilm = value;
            }
        }


        public int Count {
            get
            {
                return mFilmList.Count;
            }

            set
            {

            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FilmName", mThisFilm.FilmName);
            DB.AddParameter("@FilmDescription", mThisFilm.FilmDescription);
            DB.AddParameter("@FilmCertificate", mThisFilm.FilmCertificate);
            DB.AddParameter("@FilmReleaseDate", mThisFilm.FilmReleaseDate);
            DB.AddParameter("@FilmDepartureDate", mThisFilm.FilmDepartureDate);
            DB.AddParameter("@FilmShowing", mThisFilm.FilmShowing);

            return DB.Execute("sproc_TblFilmManagement_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FilmId", mThisFilm.FilmID);
            DB.Execute("sproc_TblFilmManagement_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FilmName", mThisFilm.FilmName);
            DB.AddParameter("@FilmDescription", mThisFilm.FilmDescription);
            DB.AddParameter("@FilmCertificate", mThisFilm.FilmCertificate);
            DB.AddParameter("@FilmReleaseDate", mThisFilm.FilmReleaseDate);
            DB.AddParameter("@FilmDepartureDate", mThisFilm.FilmDepartureDate);
            DB.AddParameter("@FilmShowing", mThisFilm.FilmShowing);

            DB.Execute("sproc_TblFilmManagement_Update");
        }

        public void ReportByFilmName(string FilmName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FilmName", FilmName);
            DB.Execute("sproc_TblFilmManagement_FilterByFilmName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mFilmList = new List<clsFilm>();
            while(Index < RecordCount)
            {
                clsFilm AFilm = new clsFilm();

                AFilm.FilmID = Convert.ToInt32(DB.DataTable.Rows[Index]["FilmId"]);
                AFilm.FilmName = Convert.ToString(DB.DataTable.Rows[Index]["FilmName"]);
                AFilm.FilmDescription = Convert.ToString(DB.DataTable.Rows[Index]["FilmDescription"]);
                AFilm.FilmCertificate = Convert.ToString(DB.DataTable.Rows[Index]["FilmCertificate"]);
                AFilm.FilmReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["FilmReleaseDate"]);
                AFilm.FilmDepartureDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["FilmDepartureDate"]);
                AFilm.FilmShowing = Convert.ToBoolean(DB.DataTable.Rows[Index]["FilmShowing"]);
                //add the record to the private data member
                mFilmList.Add(AFilm);
                //point at the next record
                Index++;
            }
        }
    }
}