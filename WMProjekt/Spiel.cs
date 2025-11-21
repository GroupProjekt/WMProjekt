using System;
using WMProjekt;

public class Spiel
{
    public Mannschaft m1 { get; set; }
    public Mannschaft m2 { get; set; }
    private bool gruppenphase;
    public int toreMannschaft1 {  get; set; }
    public int toreMannschaft2 { get; set; }
    
    public Spiel(Mannschaft m1, Mannschaft m2, bool gruppenphase)
    {
        this.m1 = m1;
        this.m2 = m2;
        this.gruppenphase = gruppenphase;
        toreMannschaft1 = toreBerechnen(m1);
        toreMannschaft2 = toreBerechnen(m2);
    }

    public void gruppenphaseStart() 
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
        String ergebnis = Gewinner();

        // Solange unentschieden, Tore neu berechnen
        while ("Unentschieden" == ergebnis)
        {
            toreMannschaft1 = toreBerechnen(m1);
            toreMannschaft2 = toreBerechnen(m2);
            ergebnis = Gewinner();
        }

        // Gewinner zurückgeben
        switch (ergebnis)
        {
            case "M1":
                return m1;
            case "M2":
                return m2;
            default:
                return null;
        }
    }

    private int toreBerechnen(Mannschaft mannschaft)
    {
        Random rnd = new Random();
        int tore = rnd.Next(0, mannschaft.GetMaxTore());
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
            m1.SetPunktzahl(m1.GetPunktzahl() + 1);
            m2.SetPunktzahl(m2.GetPunktzahl() + 1);
        }
        else if (Gewinner() == "M1")
        {
            m1.SetPunktzahl(m1.GetPunktzahl() + 3);
        }
        else if (Gewinner() == "M2")
        {
            m2.SetPunktzahl(m2.GetPunktzahl() + 3);
        }
    }

    private void addVerhaeltnis()
    {
        m1.SetTorverhaeltnis(m1.GetTorverhaeltnis() + Verhaeltnis());
        // * -1 um das Verhältnis umzukehren
        m2.SetTorverhaeltnis(m2.GetTorverhaeltnis() + (Verhaeltnis() * (-1)));
    }

    private int Verhaeltnis()
    {
        // Gibt das Verhältnis von M1 zurück
        int verhaeltnis = toreMannschaft1 - toreMannschaft2;
        return verhaeltnis;
    }
}