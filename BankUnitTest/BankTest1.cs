using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankBiblioteka;

namespace BankUnitTest
{
    [TestClass]
    public class BankTest1
    {
        [TestMethod]
        public void TestKonstruktor()
        {
            double kwota = 15000.97;
            double zero = .0;

            Bank EmptyBank = new Bank();
            Bank FullBank = new Bank(kwota);

            double kwotaEmpty = EmptyBank.Saldo();
            double kwotaFull = FullBank.Saldo();

            Assert.AreEqual(kwota, kwotaFull, "B³¹d konstruktora z argumentem");
            Assert.AreEqual(zero, kwotaEmpty, "B³¹d konstruktora bez argumentu");
        }
        [TestMethod]
        public void TestWplata()
        {
            double kwota = 15000.97;
            double wplata = 5000.0;

            Bank TestBank = new Bank(kwota);
            double kwotaPoWplacie = TestBank.Wplata(wplata);

            double suma = kwota + wplata;

            Assert.AreEqual(suma, kwotaPoWplacie, "B³¹d wp³aty");
        }
        [TestMethod]
        public void TestWyplata()
        {
            double kwota = 15000.97;
            double wyplata = 5000.0;
            double zaWysokaWyplata = 50000.0;

            Bank TestBank = new Bank(kwota);
            double kwotaPoWyplacie = TestBank.Wyplata(wyplata);
            double kwotaPoNieudanejWyplacie = TestBank.Wyplata(zaWysokaWyplata);

            double suma = kwota - wyplata;

            Assert.AreEqual(suma, kwotaPoWyplacie, "B³¹d wyp³aty");
            Assert.AreEqual(suma, kwotaPoNieudanejWyplacie, "Wyp³ata kwoty wy¿szej ni¿ dostêpna");
        }
    }
}
