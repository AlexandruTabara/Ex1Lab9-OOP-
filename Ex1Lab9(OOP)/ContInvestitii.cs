using System;

class ContInvestitii : ContEconomii
{
    byte ziuaExtragerii;
    public ContInvestitii(byte ziuaExtragerii, decimal rataDobanzii)
            :base(rataDobanzii)
    {
        this.ziuaExtragerii = ziuaExtragerii;
    }
    public override void ExtrageNumerar(decimal valoare)
    {
        if (DateTime.Now.Day >= ziuaExtragerii)
        {
            base.ExtrageNumerar(valoare);
        }
        else
        {
            Console.WriteLine("Termenul de extragere nu a fost atins");
        }
    }
    public override string ToString()
    {
        return $"cont de economii {base.ToString()} ziua extragerii {ziuaExtragerii}";
    }
}


