using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMProjekt;

public class Tools
{

    public List<string> NamenEinlesen()
    {
        List<string> Infos = new List<string>();
        string filePath = "S:\\IT-Ausbildung\\24FA03\\_Dateien\\Mannschaftenliste.csv";

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(';');
                    foreach (var value in values)
                    {
                        Infos.Add(value);

                    }
                }
                return Infos;
            }
        }
        else
        {
            Console.WriteLine("Datei nicht gefunden.");
        }
        return Infos;
    }
}