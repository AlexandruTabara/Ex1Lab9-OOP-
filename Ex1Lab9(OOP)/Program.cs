using System;

namespace Ex1Lab9_OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            ContBancar contCurent = new ContCurent();
            ContBancar contInvestitii = new ContInvestitii(23, 0.5m);
            ContBancar contEconomii = new ContEconomii(0.5m);

            contCurent.DepuneNumerar(1000);
            contInvestitii.DepuneNumerar(1000);
            contInvestitii.DepuneNumerar(700);
            contEconomii.DepuneNumerar(1000);
            contEconomii.DepuneNumerar(1000);
            contEconomii.DepuneNumerar(1000);

            contCurent.ExtrageNumerar(1000);
            contCurent.ExtrageNumerar(1000);
            contCurent.ExtrageNumerar(1000);
            contCurent.ExtrageNumerar(1000);
            contCurent.ExtrageNumerar(1000);
        }
    }
}






