using System;

namespace BankBiblioteka
{
    public class Bank
    {
        private double stan;
        public Bank()
        {
            stan = .0;
        }
        public Bank(double kwota)
        {
            stan = kwota;
        }
        public double Wyplata(double kwota)
        {
            if (kwota < stan) stan -= kwota;
            return stan;
        }
        public double Wplata(double kwota)
        {
            stan += kwota;
            return stan;

        }
        public double Saldo()
        {
            return stan;
        }
    }
}
