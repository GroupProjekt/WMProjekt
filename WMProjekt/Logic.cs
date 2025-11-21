using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace WMProjekt;

public class Logic
{
    private List<Mannschaft> alleMannschaften = new List<Mannschaft>();
    private List<Mannschaft> q1 = new List<Mannschaft>();
    private List<Mannschaft> q2 = new List<Mannschaft>();
    private List<Mannschaft> q3 = new List<Mannschaft>();
    private List<Mannschaft> q4 = new List<Mannschaft>();

    public void MannschaftenErstellen()
    {
        List<string> tempInfo = new List<string>();
        Tools reader = new Tools();
        tempInfo = reader.NamenEinlesen();
        int i = 1;
        while (tempInfo.Count > 0)
        {
            Mannschaft m = new Mannschaft(tempInfo[0], tempInfo[1], Convert.ToInt32(tempInfo[2]));
            alleMannschaften.Add(m);
            tempInfo.RemoveRange(0,3);          
            Debug.WriteLine(m.GetName());
        }
    }

    public void GruppenErstellen()
    {
        q1.AddRange(alleMannschaften.GetRange(0, 8));
        q2.AddRange(alleMannschaften.GetRange(8, 8));
        q3.AddRange(alleMannschaften.GetRange(16, 8));
        q4.AddRange(alleMannschaften.GetRange(24, 8));
    }

}