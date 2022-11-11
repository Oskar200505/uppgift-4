using uppgift_4;

void Djur()
{
    Djur.Hund hund = new Djur.Hund();
    hund.setNamn("Ubbe");
    Console.WriteLine("namn:)" + hund.getNamn());
    hund.setsvansenslängd(23);
    Console.WriteLine("Längd på svansen:)" + hund.getSvansenslängd());
    hund.skäll();
}
Djur();