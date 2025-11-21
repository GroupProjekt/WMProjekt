public class Spiel
{
    private Mannschaft m1;
    private Mannschaft m2;
    private bool gruppenphase;
    private int toreMannschaft1 = toreBerechnen(m1);
    // test
    private int toreMannschaft2 = toreBerechnen(m2);
    public Spiel(Mannschaft m1, Mannschaft m2, bool gruppenphase)
    {
        this.m1 = m1;
        this.m2 = m2;
        this.gruppenphase = gruppenphase;
    }



    private int toreBerechnen(Mannschaft mannschaft)
    {
        Random rnd = new Random();
        int tore = rnd.Next(0, mannschaft.getMaxTore());
        return tore;
    }
}