using System;

namespace Pruebas
{
    public class SeaBird : AAnimal
    {
        const string DefaultName = "Pingu";
        const string DefaultSuperFamily = "Au marina";
        const string DefaultSpecies = "Pinguí Emperador";
        const float DefaultWeight = 4.5f;
        /// <summary>
        /// Sobreescriptura del mètode ToString en format taula
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string dolphinInfo = "+-------------------------------------------------------------+\n";
            dolphinInfo += "|                       FITXA                                 |\n";
            dolphinInfo += "+-------------------------------------------------------------+\n";
            dolphinInfo += "| # Nom |   Superfamília   |     Espècie      | Pes aproximat |\n";
            dolphinInfo += "+-------------------------------------------------------------+\n";
            dolphinInfo += $"| {Name} |   {SuperFamily}   | {Species} |     {Weight}kg     |\n";
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
            return gA - (c == 1 ? (gA * gA + 5) : (gA * gA));
        }

        public SeaBird(string name, string superFamily, string species, float weight) : base(name, superFamily, species, weight) { }
        public SeaBird() : base(DefaultName, DefaultSuperFamily, DefaultSpecies, DefaultWeight) { }
    }
}
