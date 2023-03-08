using System;

class ContCurent : ContBancar
{
    private const decimal  PlafonDescoperireCard = 5000;
    public override void ExtrageNumerar(decimal valoareaExtrasa)
    {
        if(valoareaExtrasa <= sold + PlafonDescoperireCard)
        {
            sold -= valoareaExtrasa;
            Console.WriteLine($"Am extras suma {valoareaExtrasa}");
        }
    }

    public override string ToString()
    {
        return $"Cont curent {base.ToString()}";
    }
}




