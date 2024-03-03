using System;

namespace Pruebas
{
    public class Rescue
    {
        const string DefaultNum = "RES123";
        const int DefaultGA = 37;
        const string DefaultLocation = "Gavà";
        public string RescueNum { get; set; }
        public string RescueDate { get; set; }
        public string SuperFamily { get; set; }
        public int GA {  get; set; }
        public string Location { get; set; }

        public Rescue(string rescueNum, string rescueDate, string superFamily, int gA, string location)
        {
            RescueNum = rescueNum;
            RescueDate = rescueDate;
            SuperFamily = superFamily;
            GA = gA;
            Location = location;
        }
        /// <summary>
        /// Sobreescriptura del mètode ToString en format taula
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string rescueInfo = "+-------------------------------------------------------------+\n";
            rescueInfo += "|                       RESCAT                                |\n";
            rescueInfo += "+-------------------------------------------------------------+\n";
            rescueInfo += $"| # Rescat | Data rescat | Superfamília  | GA | Localització |\n";
            rescueInfo += "+-------------------------------------------------------------+\n";
            rescueInfo += $"|  {RescueNum}  | {RescueDate}  |   {SuperFamily}   | {GA} |   {Location}  |\n";
            rescueInfo += "+-------------------------------------------------------------+\n";

            return rescueInfo;
        }
    }
}
