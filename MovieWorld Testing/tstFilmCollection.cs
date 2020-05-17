using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;
using System.Collections.Generic;

namespace MovieWorld_Testing
{
    [TestClass]
    public class tstFilmCollection
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void InstanceOK()
        {
            clsFilmCollection AllFilms = new clsFilmCollection();
            Assert.IsNotNull(AllFilms);
        }

        [TestMethod]
        public void FilmListOk()
        {
            //create an instance of the class we want to create
            clsFilmCollection AllFilms = new clsFilmCollection();
            //create test data to assign to property
            List<clsFilm> TestList = new List<clsFilm>();
            //add to list
            clsFilm TestItem = new clsFilm();
            //set properties
            TestItem.FilmName = "test film";
            TestItem.FilmDescription = "test description";
            TestItem.FilmCertificate = "u";
            TestItem.FilmReleaseDate = DateTime.Now.Date;
            TestItem.FilmShowing = true;
            TestItem.FilmDepartureDate = DateTime.Now.Date.AddYears(1);

            TestList.Add(TestItem);
            AllFilms.FilmList = TestList;

            Assert.AreEqual(AllFilms.FilmList, TestList);
        }

              
        [TestMethod]
           public void CountPropertyOkay()
           {
               //create instance of class we want to create
               clsFilmCollection AllFilms = new clsFilmCollection();
               //create some test data to assign to the property
               Int32 SomeCount = 0;
               //assign the data to the property
               AllFilms.Count = SomeCount;
           }

        [TestMethod]
        public void ThisFilmPropertyOK()
        {
            clsFilmCollection AllFilms = new clsFilmCollection();
            clsFilm TestFilm = new clsFilm();

            TestFilm.FilmName = "test film";
            TestFilm.FilmDescription = "test description";
            TestFilm.FilmCertificate = "u";
            TestFilm.FilmReleaseDate = DateTime.Now.Date;
            TestFilm.FilmShowing = true;
            TestFilm.FilmDepartureDate = DateTime.Now.Date.AddYears(1);

            AllFilms.ThisFilm = TestFilm;

            Assert.AreEqual(AllFilms.ThisFilm, TestFilm);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsFilmCollection AllFilms = new clsFilmCollection();

            List<clsFilm> TestList = new List<clsFilm>();

            clsFilm TestFilm = new clsFilm();

            TestFilm.FilmName = "test film";
            TestFilm.FilmDescription = "test description";
            TestFilm.FilmCertificate = "u";
            TestFilm.FilmReleaseDate = DateTime.Now.Date;
            TestFilm.FilmShowing = true;
            TestFilm.FilmDepartureDate = DateTime.Now.Date.AddYears(1);

            TestList.Add(TestFilm);

            AllFilms.FilmList = TestList;

            Assert.AreEqual(AllFilms.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsFilmCollection AllFilms = new clsFilmCollection();
            Assert.AreEqual(AllFilms.Count, 2);
        }
    }
}
