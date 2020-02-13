using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieWorld_Testing
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsFilm AFilm = new clsFilm();
            Assert.IsNotNull(AFilm);
        }
    }
}
