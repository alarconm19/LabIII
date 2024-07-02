/* Un zoológico desea desarrollar un sistema para gestionar sus animales y cuidadores.
El sistema debe permitir la creación y gestión de diferentes tipos de animales, incluyendo mamíferos,
aves, peces y una planta carnívora. Cada animal debe tener un nombre, una especie y un tipo de comida
asociado. Los mamíferos deben ser capaces de amamantar, las aves deben poder volar y los peces deben poder
nadar. Además, se requiere la capacidad de crear una planta carnívora que se alimente de otros seres vivos.
Los cuidadores serán responsables de alimentar a los animales. Cada cuidador debe tener un nombre y
ser capaz de alimentar a los animales bajo su cuidado con la comida adecuada. Esto incluye tanto a
los animales convencionales como a la planta carnívora.
El zoológico debe tener la capacidad de administrar tanto a los animales como a los cuidadores.
Esto implica la capacidad de agregar, eliminar y actualizar la información de los animales y cuidadores.
Además, el zoológico debe ser capaz de mostrar la lista de animales y cuidadores disponibles.
El sistema debe ser implementado en C# y ejecutarse por consola. Los alumnos deberán utilizar herencia,
polimorfismo, interfaces y métodos virtuales para garantizar la flexibilidad y extensibilidad del sistema.
Además, se debe implementar la inyección de dependencias para permitir que los cuidadores alimenten a
cualquier tipo de animal, incluida la planta carnívora.
*/

namespace Zoologico;

internal static class Administracion
{
    public static void Main()
    {
        List<ISerVivo> seresVivos = [];
        List<Cuidador> cuidadores = [];

        int opcionMenuPrinc;

        do
        {
            Console.WriteLine("\n\t\t Administracion de Zoologico ");
            Console.WriteLine("1. Agregar animal o planta." +
                            "\n2. Agregar cuidador." +
                            "\n3. Mostrar todos los seres vivos del zoologico." +
                            "\n4. Mostrar todos los cuidadores." +
                            "\n5. Salir");
            Console.Write("Seleccione una opcion: ");

            opcionMenuPrinc = int.Parse(Console.ReadLine() ?? string.Empty);

            switch (opcionMenuPrinc)
            {
                case 1:
                    Console.WriteLine("\n1. Animal \n2. Planta");
                    Console.Write("Opcion: ");
                    var aniorplan = int.Parse(Console.ReadLine()!);

                    switch (aniorplan)
                    {
                        case 1:
                            Console.Write("Ingrese el nombre: ");
                            var nombreAnimal = Console.ReadLine()!;

                            Console.Write("\n¿Esta enfermo? s/n: ");
                            // Lee la entrada del usuario y la convierte en minúscula
                            var respuesta = char.ToLower(Console.ReadKey().KeyChar);
                            // Verifica si la respuesta es 's' (sí)
                            var enfermo = respuesta == 's';

                            Console.Write("\n¿Esta alimentado? s/n: ");
                            respuesta = char.ToLower(Console.ReadKey().KeyChar);
                            var alimentado = respuesta == 's';


                            Console.WriteLine("\nSeleccione el tipo de animal: \n1. Mamifero \n2. Ave \n3. Pez");
                            Console.Write("Opcion: ");
                            var tipoani = int.Parse(Console.ReadLine()!);

                            switch (tipoani)
                            {
                                case 1:
                                    Console.WriteLine("\n1. Leon \n2. Chimpance");
                                    Console.Write("Opcion: ");
                                    var tipomami = int.Parse(Console.ReadLine()!);

                                    switch (tipomami)
                                    {
                                        case 1:
                                            var leon = new Leon(nombreAnimal, enfermo, alimentado);
                                            seresVivos.Add(leon);
                                            break;

                                        case 2:
                                            var chimpance = new Chimpance(nombreAnimal, enfermo, alimentado);
                                            seresVivos.Add(chimpance);
                                            break;
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("\n1. Aguila Real \n2. Pio");
                                    Console.Write("Opcion: ");
                                    int tipoave = int.Parse(Console.ReadLine()!);

                                    switch (tipoave)
                                    {
                                        case 1:
                                            var aguila = new AguilaReal(nombreAnimal, enfermo, alimentado);
                                            seresVivos.Add(aguila);
                                            break;

                                        case 2:
                                            var pio = new Pio(nombreAnimal, enfermo, alimentado);
                                            seresVivos.Add(pio);
                                            break;
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("\n1. Pez payaso \n2. Pez dorado");
                                    Console.Write("Opcion: ");
                                    int tipopez = int.Parse(Console.ReadLine()!);

                                    switch (tipopez)
                                    {
                                        case 1:
                                            var pezPayaso = new PezPayaso(nombreAnimal, enfermo, alimentado);
                                            seresVivos.Add(pezPayaso);
                                            break;

                                        case 2:
                                            var pezDorado = new PezDorado(nombreAnimal, enfermo, alimentado);
                                            seresVivos.Add(pezDorado);
                                            break;
                                    }
                                    break;
                            }
                            break;

                        case 2:
                            Console.Write("\n¿Esta alimentada? s/n: ");
                            respuesta = char.ToLower(Console.ReadKey().KeyChar);
                            bool alimentada = respuesta == 's';

                            Console.Write("\n¿Esta hidratada? s/n: ");
                            respuesta = char.ToLower(Console.ReadKey().KeyChar);
                            bool hidratada = respuesta == 's';

                            var plantacarnivora = new PlantaCarnivora(hidratada, alimentada);
                            seresVivos.Add(plantacarnivora);

                            break;
                    }

                    break;

                case 2:
                    Console.WriteLine("Ingrese el nombre del cuidador: ");
                    var nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese la edad del cuidador: ");
                    var edad = int.Parse(Console.ReadLine()!);

                    Console.WriteLine("Turno: \n1. Mañana.\n2. Tarde.\n3. Noche.");
                    Console.Write("Seleccione: ");
                    var turno = (Turno) int.Parse(Console.ReadLine()!);

                    Cuidador cuidador = new Cuidador(nombre, edad, turno);
                    cuidadores.Add(cuidador);

                    break;
                case 3:
                    foreach (var serVivo in seresVivos)
                    {
                        Console.WriteLine(serVivo);
                    }
                    break;

                case 4:
                    foreach(var cui in cuidadores)
                    {
                        Console.WriteLine(cui.ToString());
                    }
                    break;

                case 5:
                    break;
            }

        } while (opcionMenuPrinc != 5);
    }
}