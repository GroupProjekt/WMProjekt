using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WMTurnierbaum
{
    internal class Tunierbaum
    {

        private readonly List<Mannschaft> mannschaften;

        public Tunierbaum(List<Mannschaft> mannschaften)
        {
            this.mannschaften = mannschaften;
        }


        public Mannschaft GetPlacement(String Kuerzel)
        {
            foreach mannschaft in mannschaften) {
                if (mannschaft.getGruppenplatzierung == Kuerzel) {
                    return mannschaft;
                }
                else
                    return null;
            }
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
        }
        
        public void achtelfinale()
        {
            List<Mannschaft> achtelfinalisten = getAchtelFinalisten();
            Spiel achtelfinale1 = new Spiel(achtelfinalisten[0], achtelfinalisten[1], false);
            achtelfinale1.startGame();

            Spiel achtelfinale2 = new Spiel(achtelfinalisten[2], achtelfinalisten[3], false);
            achtelfinale1.startGame();

            Spiel achtelfinale3 = new Spiel(achtelfinalisten[4], achtelfinalisten[5], false);
            achtelfinale1.startGame();

            Spiel achtelfinale4 = new Spiel(achtelfinalisten[6], achtelfinalisten[7], false);
            achtelfinale1.startGame();

            Spiel achtelfinale5 = new Spiel(achtelfinalisten[8], achtelfinalisten[9], false);
            achtelfinale1.startGame();

            Spiel achtelfinale6 = new Spiel(achtelfinalisten[10], achtelfinalisten[11], false);
            achtelfinale1.startGame();

            Spiel achtelfinale7 = new Spiel(achtelfinalisten[12], achtelfinalisten[13], false);
            achtelfinale1.startGame();

            Spiel achtelfinale8 = new Spiel(achtelfinalisten[14], achtelfinalisten[15], false);
            achtelfinale1.startGame();
        }
    }
}
