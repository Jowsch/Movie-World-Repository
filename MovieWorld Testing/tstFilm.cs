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
        String FilmDescription = "test description, test description, test description, " +
            "test description, test description, ";
        String FilmCertificate = "12";
        String FilmReleaseDate = "03/09/1996";
        String FilmDepartureDate = Convert.ToString(DateTime.Now.Date);

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
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmName = "";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmNameMin()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmName = "A";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmName = "ET";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmName = "";
            FilmName = FilmName.PadRight(249, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmNameMax()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmName = "";
            FilmName = FilmName.PadRight(250, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmName = "";
            FilmName = FilmName.PadRight(251, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmName = "";
            FilmName = FilmName.PadRight(1000, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmNameMid()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmName = "";
            FilmName = FilmName.PadRight(125, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmDescriptionExtremeMin()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmDescription = "";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmDescription = "";
            FilmName = FilmName.PadRight(19, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmDescriptionMin()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmDescription = "";
            FilmName = FilmName.PadRight(20, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(21, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(1999, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmDescriptionMax()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(2000, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(2001, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmDescriptionMid()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(1000, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmDescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(10000, 'a');
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmCertificateMinLessOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmCertificate = "";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmCertificateMin()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmCertificate = "a";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmCertificateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmCertificate = "aa";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmCertificateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmCertificate = "aa";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmCertificateMax()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmCertificate = "aaa";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmCertificateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmCertificate = "aaaa";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmCertificateMid()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmCertificate = "aa";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmCertificateExtremeMax()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            string FilmCertificate = "aaaaaaaaaa";
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmReleaseDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = new DateTime(1800, 1, 1);
            string FilmReleaseDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmReleaseDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = new DateTime(1887, 1, 1);
            string FilmReleaseDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmReleaseDateMin()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = new DateTime(1888, 1, 1);
            string FilmReleaseDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmReleaseDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = new DateTime(1889, 1, 1);
            string FilmReleaseDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmReleaseDateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(+1);
            string FilmReleaseDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmReleaseDateMax()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(+2);           
            string FilmReleaseDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmReleaseDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(+3);
            string FilmReleaseDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmReleaseDateMid()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50);
            string FilmReleaseDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmReleaseDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = new DateTime(2500, 1, 1);
            string FilmReleaseDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmReleaseDateInvalidDate()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            string FilmReleaseDate = "This is not a date!";
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmDepartureDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = new DateTime(2000, 1, 1);
            string FilmDepartureDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmDepartureDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.AddDays(-1);
            string FilmDepartureDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmDepartureDateMin()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string FilmDepartureDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmDepartureDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.AddDays(+1);
            string FilmDepartureDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmDepartureDateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(+1);
            TestDate = TestDate.AddDays(-1);
            string FilmDepartureDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmDepartureDateMax()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(+1);
            string FilmDepartureDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmDepartureDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(+1);
            TestDate = TestDate.AddDays(+1);
            string FilmDepartureDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmDepartureDateMid()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(+100);
            string FilmDepartureDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FilmDepartureDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = new DateTime(2500, 1, 1);  
            string FilmDepartureDate = TestDate.ToString();
            //invoke method
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FilmDepartureDateInvalidDate()
        {
            //create an instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            //String Error stores any error message
            String Error = "";
            string FilmDepartureDate = "This is not a date!";
            Error = AFilm.Valid(FilmName, FilmDescription, FilmCertificate, FilmReleaseDate, FilmDepartureDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
