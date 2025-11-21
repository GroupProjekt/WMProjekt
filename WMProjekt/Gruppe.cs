using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WMProjekt
{
    internal class Gruppe
    {
        



        char bezeichnung;
        List<string> mannschaften = new List<string>();
        List<string> spieltag1 = new List<string>();
        List<string> spieltag2 = new List<string>();
        List<string> spieltag3 = new List<string>();

        public void listeFüllen()
        {
         mannschaften.Add("Deutschland");
         mannschaften.Add("Spanien");
         mannschaften.Add("Frankreich");
         mannschaften.Add("England");
        }

        public void spieleEinteilen()
        {
            spieltag1.Add(mannschaften[0] + " vs. " + mannschaften[1]);
            spieltag1.Add(mannschaften[2] + " vs. " + mannschaften[3]);

            spieltag2.Add(mannschaften[0] + " vs. " + mannschaften[2]);
            spieltag2.Add(mannschaften[1] + " vs. " + mannschaften[3]);

            spieltag3.Add(mannschaften[0] + " vs. " + mannschaften[3]);
            spieltag3.Add(mannschaften[1] + " vs. " + mannschaften[2]);
        }


        public List<string> GetAlleSpiele()
        {
            listeFüllen();
            spieleEinteilen();

            List<string> alleSpiele = new List<string>();
            alleSpiele.AddRange(spieltag1);

            alleSpiele.AddRange(spieltag2);

            alleSpiele.AddRange(spieltag3);

            return alleSpiele;
        }
    }
}
