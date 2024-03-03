
namespace Pruebas
{
    public abstract class AAnimal
    {
        public string Name { get; set; }
        public string SuperFamily { get; set; }
        public string Species { get; set; }
        public float Weight { get; set; }

        public abstract int Treatment(int gA, int choice);
        public AAnimal(string name, string superFamily, string species, float weight)
        {
            Name = name;
            SuperFamily = superFamily;
            Species = species;
            Weight = weight;
        }
    }
}
