using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WMProjekt
{
    public class Tunierbaum
    {   private Mannschaft siegerAchtel1;
        private Mannschaft siegerAchtel2;
        private Mannschaft siegerAchtel3;
        private Mannschaft siegerAchtel4;
        private Mannschaft siegerAchtel5;
        private Mannschaft siegerAchtel6;
        private Mannschaft siegerAchtel7;
        private Mannschaft siegerAchtel8;
        private Mannschaft siegerViertel1;
        private Mannschaft siegerViertel2;
        private Mannschaft siegerViertel3;
        private Mannschaft siegerViertel4;
        private Mannschaft siegerHalb1;
        private Mannschaft siegerHalb2;
        private Mannschaft siegerFinale;

        private List<Spiel> allMatches = new List<Spiel>();

        private readonly List<Mannschaft> mannschaften;

        public Tunierbaum(List<Mannschaft> mannschaften)
        {
            this.mannschaften = mannschaften;
        }

        public Mannschaft GetPlacement(String Kuerzel)
        {
            Mannschaft richtigeMannschaft = mannschaften[0];
            foreach (Mannschaft mannschaft in mannschaften) {
                if (mannschaft.GetGruppenplatzierung() == Kuerzel) {
                    return mannschaft;
                }
            }
            return richtigeMannschaft;
        }
        
        public List<Mannschaft> getAchtelFinalisten()
        {
            List<Mannschaft> achtelfinalisten = new List<Mannschaft>();
            achtelfinalisten.Append(GetPlacement("A1"));
            achtelfinalisten.Append(GetPlacement("B2"));

            achtelfinalisten.Append(GetPlacement("A2"));
            achtelfinalisten.Append(GetPlacement("B1"));

            achtelfinalisten.Append(GetPlacement("C1"));
            achtelfinalisten.Append(GetPlacement("D2"));

            achtelfinalisten.Append(GetPlacement("C2"));
            achtelfinalisten.Append(GetPlacement("D1"));

            achtelfinalisten.Append(GetPlacement("E1"));
            achtelfinalisten.Append(GetPlacement("F2"));

            achtelfinalisten.Append(GetPlacement("F1"));
            achtelfinalisten.Append(GetPlacement("E2"));

            achtelfinalisten.Append(GetPlacement("G1"));
            achtelfinalisten.Append(GetPlacement("H2"));

            achtelfinalisten.Append(GetPlacement("G2"));
            achtelfinalisten.Append(GetPlacement("H1"));

            return achtelfinalisten;
        }
        
        public void achtelfinale()
        {
            List<Mannschaft> achtelfinalisten = getAchtelFinalisten();
            Spiel achtelfinale1 = new Spiel(achtelfinalisten[0], achtelfinalisten[1], false);
            this.siegerAchtel1 = achtelfinale1.getGewinner();

            Spiel achtelfinale2 = new Spiel(achtelfinalisten[2], achtelfinalisten[3], false);
            this.siegerAchtel2 = achtelfinale2.getGewinner();

            Spiel achtelfinale3 = new Spiel(achtelfinalisten[4], achtelfinalisten[5], false);
            this.siegerAchtel3 = achtelfinale3.getGewinner();

            Spiel achtelfinale4 = new Spiel(achtelfinalisten[6], achtelfinalisten[7], false);
            this.siegerAchtel4 = achtelfinale4.getGewinner();

            Spiel achtelfinale5 = new Spiel(achtelfinalisten[8], achtelfinalisten[9], false);
            this.siegerAchtel5 = achtelfinale5.getGewinner();

            Spiel achtelfinale6 = new Spiel(achtelfinalisten[10], achtelfinalisten[11], false);
            this.siegerAchtel6 = achtelfinale6.getGewinner();

            Spiel achtelfinale7 = new Spiel(achtelfinalisten[12], achtelfinalisten[13], false);
            this.siegerAchtel7 = achtelfinale7.getGewinner();

            Spiel achtelfinale8 = new Spiel(achtelfinalisten[14], achtelfinalisten[15], false);
            this.siegerAchtel8 = achtelfinale8.getGewinner();

            this.allMatches.Append(achtelfinale1);
            this.allMatches.Append(achtelfinale2);
            this.allMatches.Append(achtelfinale3);
            this.allMatches.Append(achtelfinale4);
            this.allMatches.Append(achtelfinale5);
            this.allMatches.Append(achtelfinale6);
            this.allMatches.Append(achtelfinale7);
            this.allMatches.Append(achtelfinale8);
        }

        public void viertelfinale()
        {
            Spiel viertelfinale1 = new Spiel(siegerAchtel1, siegerAchtel2, false);
            siegerViertel1 = viertelfinale1.getGewinner();

            Spiel viertelfinale2 = new Spiel(siegerAchtel3, siegerAchtel4, false);
            siegerViertel2 = viertelfinale2.getGewinner();

            Spiel viertelfinale3 = new Spiel(siegerAchtel5, siegerAchtel6, false);
            siegerViertel3 = viertelfinale3.getGewinner();

            Spiel viertelfinale4 = new Spiel(siegerAchtel7, siegerAchtel8, false);
            siegerViertel4 = viertelfinale4.getGewinner();

            this.allMatches.Append(viertelfinale1);
            this.allMatches.Append(viertelfinale2);
            this.allMatches.Append(viertelfinale3);
            this.allMatches.Append(viertelfinale4);
        }

        public void halbfinale()
        {
            Spiel halbfinale1 = new Spiel(siegerViertel1, siegerViertel2, false);
            siegerHalb1 = halbfinale1.getGewinner();

            Spiel halbfinale2 = new Spiel(siegerViertel3 , siegerViertel4, false);
            siegerHalb2 = halbfinale2.getGewinner();

            this.allMatches.Append(halbfinale1);
            this.allMatches.Append(halbfinale2);
        }

        public void finale()
        {
            Spiel finale = new Spiel(siegerHalb1 , siegerHalb2, false);
            siegerFinale = finale.getGewinner();

            this.allMatches.Append(finale);
        }

        public void alleSpieleAbAchtelfinaleDurchspielen()
        {
            achtelfinale();
            viertelfinale();
            halbfinale();
            finale();
        }
        public List<Spiel> getAllResults()
        {
            return this.allMatches;
        }
    }
}
