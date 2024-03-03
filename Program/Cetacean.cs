using System;

namespace Pruebas
{
    public class Cetacean : AAnimal
    {
        const string DefaultName = "Oumou";
        const string DefaultSuperFamily = "Cetaci";
        const string DefaultSpecies = "Dofí llistat";
        const float DefaultWeight = 20.5f;

        /// <summary>
        /// Sobreescriptura del mètode ToString en format taula
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string dolphinInfo = "+-------------------------------------------------------------+\n";
            dolphinInfo += "|                       FITXA                                 |\n";
            dolphinInfo += "+-------------------------------------------------------------+\n";
            dolphinInfo += "| # Nom | Superfamília |    Espècie     |    Pes aproximat    |\n";
            dolphinInfo += "+-------------------------------------------------------------+\n";
            dolphinInfo += $"| {Name} |    {SuperFamily}    |  {Species}  |       {Weight}kg        |\n";
            dolphinInfo += "+-------------------------------------------------------------+\n";

            return dolphinInfo;
        }
        /// <summary>
        /// Operació del grau d'afectació cambiant la formula en funció del paràmetre c
        /// </summary>
        /// <param int name="gA"></param>
        /// <param int name="c"></param>
        /// <returns>int</returns>
        public override int Treatment(int gA, int c)
        {
            return (int)(gA - (c == 1 ? (Math.Log10(gA) - 25) : Math.Log10(gA)));
        }
        public Cetacean(string name, string superFamily, string species, float weight) : base (name, superFamily, species, weight) { }
        public Cetacean () : base(DefaultName, DefaultSuperFamily, DefaultSpecies, DefaultWeight) { }
    }
}
