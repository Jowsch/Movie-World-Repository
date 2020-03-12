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
            tstFilm AFilm = new tstFilm();
            Assert.IsNotNull(AFilm);
        }
    }
}
