
using Pruebas;

namespace SaveTheOcean
{
    class Program
    {
        public static void Main()
        {
            const string Menu = "Save the ocean!\r\nQuè vols fer?\r\n1. Jugar!\r\n2. Sortir";
            const string Role = "Perfecte! Què vols ser?\r\n1. Tècnic (45 XP)\r\n2. Veterinari (80 XP)";
            const string Name = "Genial! I el teu nom?";
            const string WrongInput = "Has posat un valor no permès";
            const string Bye = "Fins aviat";
            const string StartingGame = "Hola, {0}! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:";
            const string ExtraInfo = "Aquí tens la seva fitxa, per a més informació:";
            const string TreatmentText = "La tortuga té un grau d’afectació (GA) del {0}%. Vols curar-la (1) o traslladar-la al centre (2)?";
            const string WinXp = "El tractament aplicat ha reduït el GA fins al {0}%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.";
            const string LoseXp = "El tractament aplicat ha reduït el GA fins al {0}%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.";
            const string FinalText = "Puntuació final: {0}xp\nFins el proper rescat!";

            int menuChoice = 0, roleChoice = 0, xP = 0, treatmentChoice = 0, treatmentResult = 0;
            string name;

            Console.WriteLine(Menu);
            menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine(Role);
                    roleChoice = Convert.ToInt32(Console.ReadLine());
                    switch (roleChoice)
                    {
                        case 1:
                            xP = 45;
                            Console.WriteLine(Name);
                            name = Console.ReadLine();
                            break;
                        case 2:
                            xP = 80;
                            Console.WriteLine(Name);
                            name = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine(StartingGame, name);
                            break;
                        default:
                            Console.WriteLine(WrongInput);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine(Bye);
                    break;
                default: 
                    Console.WriteLine(WrongInput);
                    break;
            }
            Rescue rescue = RandomRescue();
            Console.WriteLine(rescue.ToString());
            Console.WriteLine(ExtraInfo);
            switch (rescue.SuperFamily)
            {
                case "Tortuga marina":
                    Turtle turtle = new Turtle();
                    Console.WriteLine(turtle.ToString());
                    Console.WriteLine(TreatmentText, rescue.GA);
                    treatmentChoice = Convert.ToInt32(Console.ReadLine());
                    treatmentResult = turtle.Treatment(rescue.GA, treatmentChoice); 
                    break;
                case "Au marina":
                    SeaBird seaBird = new SeaBird();
                    Console.WriteLine(seaBird.ToString());
                    Console.WriteLine(TreatmentText, rescue.GA);
                    treatmentChoice = Convert.ToInt32(Console.ReadLine());
                    treatmentResult = seaBird.Treatment(rescue.GA, treatmentChoice);
                    break;
                case "Cetaci":
                    Cetacean cetacean = new Cetacean();
                    Console.WriteLine(cetacean.ToString());
                    Console.WriteLine(TreatmentText, rescue.GA);
                    treatmentChoice = Convert.ToInt32(Console.ReadLine());
                    treatmentResult = cetacean.Treatment(rescue.GA, treatmentChoice);
                    break;
            }
            if (treatmentResult >= 5)
            {
                Console.WriteLine(LoseXp, treatmentResult);
                Console.WriteLine(FinalText,xP - 20);
            }
            else
            {
                Console.WriteLine(WinXp, treatmentResult);
                Console.WriteLine(FinalText, xP + 50);
            }
        }

        public static Rescue RandomRescue()
        {
            const string Error = "Error del sistema";
            Random rnd = new Random();
            int type = rnd.Next(0, 3);
            string resName = "RES" + rnd.Next(0, 1000);
            int gA = rnd.Next(0, 100);
            switch (type)
            {
                case 0:
                    return new Rescue(resName, "17-06-2024", "Tortuga marina", gA, "Barcelona");
                case 1:
                    return new Rescue(resName, "13-02-2024", "Cetaci", gA, "Cadaquès");
                case 2:
                    return new Rescue(resName, "24-01-2024", "Au marina", gA, "Gavà");
                default:
                    Console.WriteLine(Error);
                    return null;
            }
        }

    }
}  