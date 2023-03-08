using System;

class ContEconomii : ContBancar
{
    private readonly decimal rataDobanzii;

    public ContEconomii(decimal rataDobanzii)
    {
        this.rataDobanzii = rataDobanzii;
    }
    public override void DepuneNumerar(decimal sumaDepusa)
    {
        base.DepuneNumerar(sumaDepusa);
        sold *= ( 1 + rataDobanzii );
        Console.WriteLine($"soldul a fost reactualizat la noua suma de {sold}");
    }

    public override string ToString()
    {
        return $"cont de economii {base.ToString()}  rata dobanzii {rataDobanzii}";
    }
}


