using System;

abstract class ContBancar
{
    protected decimal sold;
    private readonly Guid guid= Guid.NewGuid();

    public virtual void ExtrageNumerar(decimal valoare)
    {
       if(valoare <= sold)
        {
            sold -= valoare;
            Console.WriteLine($"Valorea {sold} a fost extrasa din contul {guid}");
        }
       else
        {
            Console.WriteLine("Fonduri insuficiente");
        }
    }

    public virtual void DepuneNumerar(decimal sumaDepusa)
    {
        sold += sumaDepusa;
        Console.WriteLine($"Valorea {sumaDepusa} a fost depusa in contul {guid}");

    }

    public override string ToString()
    {
        return $"cont {guid} | sold curent {sold}";
    }
}


