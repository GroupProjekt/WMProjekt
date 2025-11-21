using WMProjekt;

public class Spiel
{
    private Mannschaft m1;
    private Mannschaft m2;
    private bool gruppenphase;
    private int toreMannschaft1 = toreBerechnen(m1);
    private int toreMannschaft2 = toreBerechnen(m2);
    
    public Spiel(Mannschaft m1, Mannschaft m2, bool gruppenphase)
    {
        this.m1 = m1;
        this.m2 = m2;
        this.gruppenphase = gruppenphase;
    }

    public void startGame() 
    {
        if (gruppenphase)
        {
            addPunkte();
            addVerhaeltnis();
        }
    }
    public string getErgebnis()
    {
        return $"{toreMannschaft1}:{toreMannschaft2}";
    }

    public Mannschaft getGewinner()
    {
        if (Gewinner() == "M1")
        {
            return m1;
        }
        else if (Gewinner() == "M2")
        {
            return m2;
        }
        else
        {
            return null;
        }
    }

    private int toreBerechnen(Mannschaft mannschaft)
    {
        Random rnd = new Random();
        int tore = rnd.Next(0, mannschaft.getMaxTore());
        return tore;
    }

    private string Gewinner() 
    {
        if (toreMannschaft1 == toreMannschaft2)
        {
            return "Unentschieden";
        }
        else if (toreMannschaft1 > toreMannschaft2)
        {
            return "M1";
        }
        else
        {
            return "M2";
        }
    }

    private void addPunkte()
    {
        if (Gewinner() == "Unentschieden")
        {
            m1.setPunktzahl(m1.getPunktzahl() + 1);
            m2.setPunktzahl(m2.getPunktzahl() + 1);
        }
        else if (Gewinner() == "M1")
        {
            m1.setPunktzahl(m1.getPunktzahl() + 3);
        }
        else if (Gewinner() == "M2")
        {
            m2.setPunktzahl(m2.getPunktzahl() + 3);
        }
    }

    private void addVerhaeltnis()
    {
        m1.setTorverhaeltnis(m1.getTorverhaeltnis() + Verhaeltnis());
        // * -1 um das Verhältnis umzukehren
        m2.setTorverhaeltnis(m2.getTorverhaeltnis() + (Verhaeltnis() * (-1)));
    }

    private int Verhaeltnis()
    {
        // Gibt das Verhältnis von M1 zurück
        int verhaeltnis = toreMannschaft1 - toreMannschaft2;
        return verhaeltnis;
    }
}