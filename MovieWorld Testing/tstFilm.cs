using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;
using System;

namespace MovieWorld_Testing
{
    [TestClass]
    public class tstFilm
    {
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
    }
}
