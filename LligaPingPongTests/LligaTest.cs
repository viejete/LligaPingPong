using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class LligaTest
    {

        [TestMethod()]
        private void testJugadorsNotNull()
        {
            Lliga lliga = new Lliga();
            lliga.nouJugador(new Jugador());
            Assert.IsNotNull(lliga.getJugadors());
        }
    }
}