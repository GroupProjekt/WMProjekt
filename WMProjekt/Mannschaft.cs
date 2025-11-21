namespace WMProjekt;

public class Mannschaft
{
    private string Name;
    private string BildFlagge;
    private int Quartil;
    private int MaxTore;
    private int Punktzahl;
    private int Torverhaeltnis;
    private string Gruppenplatzierung; // help

    public Mannschaft(string name, string bildFlagge, int quartil)
    {
        Name = name;
        BildFlagge = bildFlagge;
        Quartil = quartil;
        if (quartil == 1)
        {
            MaxTore = 5;
        } else if (quartil == 2)
        {
            MaxTore = 3;
        } else if (quartil == 3 || quartil == 4)
        {
            MaxTore = 2;
        }
    }
    
    public string GetName()
    {
        return Name;
    }
    
    public string GetBildFlagge()
    {
        return BildFlagge;
    }
    
    public int GetQuartil(){
        return Quartil;
    }
    
    public int GetMaxTore(){
        return MaxTore;
    }

    public void SetPunktzahl(int punktzahl)
    {
        Punktzahl = punktzahl;
    }
    public int GetPunktzahl()
    {
        return Punktzahl;
    }

    public void SetTorverhaeltnis(int torverhaeltnis)
    {
        Torverhaeltnis = torverhaeltnis;
    }
    public int GetTorverhaeltnis()
    {
        return Torverhaeltnis;
    }

    public void SetGruppenplatzierung(string gruppenplatzierung)
    {
        Gruppenplatzierung = gruppenplatzierung;
    }
    public string GetGruppenplatzierung()
    {
        return Gruppenplatzierung;
    }
}