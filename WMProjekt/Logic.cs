using System.Diagnostics;

namespace WMProjekt;

public class Logic
{
    private List<Mannschaft> alleManschaften = new List<Mannschaft>();

    public void MannschaftenErstellen()
    {
        List<string> tempInfo = new List<string>();
        Tools reader = new Tools();
        tempInfo = reader.NamenEinlesen();
        int i = 1;
        while (tempInfo.Count > 0)
        {
            Mannschaft m = new Mannschaft(tempInfo[0], tempInfo[1], Convert.ToInt32(tempInfo[2]));
            alleManschaften.Add(m);
            tempInfo.RemoveRange(0,3);          
            Debug.WriteLine(m.GetName());
        }
    }

    public void GruppenErstellen()
    {

    }

}