using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;
using System;

namespace MovieWorld_Testing
{
    [TestClass]
    public class tstFilm
    {
        //good test data
        String FilmId = "35";
        String FilmName = "Frazers Film";
        String FilmDescription = "Frazer made a Film";
        String FilmCertificate = "12";
        String FilmReleaseDate = "03/09/1996";
        String FilmDepartureDate = "09/03/2020";

        [TestMethod]
        public void DescriptionPropertyOk()
        {
            clsFilm film = new clsFilm();
            String TestData = "a film about...";
            film.FilmDescription = TestData;
            Assert.AreEqual(film.FilmDescription, TestData);
        }

        [TestMethod]
        public void CertificatePropertyOK()
        {
            clsFilm film = new clsFilm();
            String TestData = "U";
            film.FilmCertificate = TestData;
            Assert.AreEqual(film.FilmCertificate, TestData);
        }

        [TestMethod]
        public void ReleaseDatePropertyOK()
        {
            clsFilm film = new clsFilm();
            DateTime TestData = DateTime.Now.Date;
            film.FilmReleaseDate = TestData;
            Assert.AreEqual(film.FilmReleaseDate, TestData);
        }

        [TestMethod]
        public void DepartureDatePropertyOK()
        {
            clsFilm film = new clsFilm();
            DateTime TestData = DateTime.Now.Date;
            film.FilmDepartureDate = TestData;
            Assert.AreEqual(film.FilmDepartureDate, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsFilm film = new clsFilm();
            String TestData = "U";
            film.FilmName = TestData;
            Assert.AreEqual(film.FilmName, TestData);
        }

        [TestMethod]
        public void ShowingPropertyOK()
        {
            clsFilm film = new clsFilm();
            Boolean TestData = true;
            film.FilmShowing = TestData;
            Assert.AreEqual(film.FilmShowing, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsFilm AFilm = new clsFilm();
            Boolean Found = false;
            Int32 FilmID = 1;
            Found = AFilm.Find(FilmID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFilmIDFound()
        {
            clsFilm AFilm = new clsFilm();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FilmID = 3;
            Found = AFilm.Find(FilmID);
            if (AFilm.FilmID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFilmNameFound()
        {
            clsFilm AFilm = new clsFilm();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FilmID = 3;
            Found = AFilm.Find(FilmID);
            if (AFilm.FilmName != "Test Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFilmDescriptionFound()
        {
            clsFilm AFilm = new clsFilm();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FilmID = 3;
            Found = AFilm.Find(FilmID);
            if (AFilm.FilmDescription != "Test Description")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFilmCertificateFound()
        {
            clsFilm AFilm = new clsFilm();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FilmID = 3;
            Found = AFilm.Find(FilmID);
            if (AFilm.FilmCertificate != "15")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFilmReleaseDateFound()
        {
            clsFilm AFilm = new clsFilm();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FilmID = 3;
            Found = AFilm.Find(FilmID);
            if (AFilm.FilmReleaseDate !=Convert.ToDateTime("03/09/1996"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFilmDepartureDateFound()
        {
            clsFilm AFilm = new clsFilm();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FilmID = 3;
            Found = AFilm.Find(FilmID);
            if (AFilm.FilmDepartureDate != Convert.ToDateTime("07/09/1996"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFilmShowingFound()
        {
            clsFilm AFilm = new clsFilm();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FilmID = 3;
            Found = AFilm.Find(FilmID);
            if (AFilm.FilmShowing != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsFilm AFilm = new clsFilm();
            String Error = "";
            Error = AFilm.Valid(FilmId, FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            Assert.AreEqual(Error, "");
        }
    }
}
