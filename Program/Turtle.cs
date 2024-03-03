using System;

namespace Pruebas
{
    public class Turtle : AAnimal
    {
        const string DefaultName = "Valpa";
        const string DefaultSuperFamily = "Tortuga marina";
        const string DefaultSpecies = "Tortuga Careta";
        const float DefaultWeight = 7f;
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
            dolphinInfo += $"| {Name} |  {SuperFamily}  |  {Species}  |     {Weight}kg       |\n";
            dolphinInfo += "+-------------------------------------------------------------+\n";

            return dolphinInfo;
        }
        /// <summary>
        /// Operació del grau d'afectació
        /// </summary>
        /// <param int name="gA"></param>
        /// <param int name="c"></param>
        /// <returns>int</returns>
        public override int Treatment(int gA, int c)
        {
            return ((gA - 2) * (2 * gA + 3)) - 5;
        }

        public Turtle(string name, string superFamily, string species, float weight) : base(name, superFamily, species, weight) { }
        public Turtle() : base(DefaultName, DefaultSuperFamily, DefaultSpecies, DefaultWeight) { }
    }
}
