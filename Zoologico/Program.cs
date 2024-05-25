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


internal abstract class Administracion
{
    enum TipoAnimal
    {
        Mamifero,
        Ave,
        Pez
    }

    enum TipoComida
    {
        Carne,
        Frutas,
        Semillas,
        PecesPequenos,
        Algas,
        Insectos
    }

    interface ISerVivo;

    abstract class Animal(string nombre, bool enfermo, bool alimentado) : ISerVivo
    {
        string Nombre { get; } = nombre;
        protected TipoAnimal Especie { get; init; }
        protected TipoComida Comida { get; init; }
        bool Enfermo { get; set; } = enfermo;
        bool Alimentado { get; set; } = alimentado;

        public void Alimentar()
        {
            Console.WriteLine($"Se esta alimentando al animal con {Comida}...");
            Alimentado = true;
            Console.WriteLine("El animal ha comido. ");
        }

        public void Curar()
        {
            Console.WriteLine("Se esta curando al animal...");
            Enfermo = true;
            Console.WriteLine("El animal ha sido curado. ");
        }

        

        public override string ToString()
        {
            return $"Nombre: {Nombre} / Especie: {Especie} / Alimentado : {Alimentado} / Enfermo: {Enfermo} / Tipo de comida: {Comida}";
        }
    }

    abstract class Mamifero : Animal
    {
        protected Mamifero(string nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Especie = TipoAnimal.Mamifero;
        }

        public void Amamantar()
        {
            Console.WriteLine("El mamifero esta amamantando...");
        }
    }

    class Leon : Mamifero
    {
        public Leon(string nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Comida = TipoComida.Carne;
        }
    }

    class Chimpance : Mamifero
    {
        public Chimpance(string nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Comida = TipoComida.Frutas;
        }
    }

    abstract class Ave : Animal
    {
        protected Ave(string nombre, bool enfermo, bool alimentado)
                : base(nombre, enfermo, alimentado)
        {
            Especie = TipoAnimal.Ave;
        }

        public void Volar()
        {
            Console.WriteLine("El ave esta volando...");
        }
    }

    class AguilaReal : Ave
    {
        public AguilaReal(string nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Comida = TipoComida.Carne;
        }
    }

    class Pio : Ave
    {
        public Pio(string nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Comida = TipoComida.Semillas;
        }
    }

    abstract class Pez : Animal
    {
        protected Pez(string nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Especie = TipoAnimal.Pez;
        }

        public void Nadar()
        {
            Console.WriteLine("El pez esta nadando...");
        }
    }

    class PezPayaso : Pez
    {
        public PezPayaso(string nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Comida = TipoComida.PecesPequenos;
        }
    }

    class PezDorado : Pez
    {
        public PezDorado(string nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Comida = TipoComida.Algas;
        }
    }


    abstract class Planta(bool hidratada) : ISerVivo
    {
        protected bool Hidratada { get; set; } = hidratada;

        public void Hidratar()
        {
            Console.WriteLine("Se esta regando la planta...");
            Hidratada = true;
            Console.WriteLine("La planta esta hidratada.");
        }
    }

    class PlantaCarnivora(bool hidratada, bool alimentada) : Planta(hidratada)
    {
        bool Alimentada { get; } = alimentada;
        static TipoComida Comida => TipoComida.Insectos;

        public void Alimentar()
        {
            Console.WriteLine($"Se esta alimentado a la planta carnivora con {Comida}...");
            Hidratada = true;
            Console.WriteLine("La planta esta alimentada.");
        }

        public override string ToString()
        {
            return $"Alimentada: {Alimentada} / Hidratada {Hidratada} / Tipo de comida: {Comida}";
        }
    }


    enum Turno
    {
        Mañana,
        Tarde,
        Noche
    }

    class Cuidador(string nombre, int edad, Turno turno)
    {
        string Nombre { get; } = nombre;
        int Edad { get; } = edad;
        Turno Turno { get; } = turno;

        public override string ToString()
        {
            return $"Nombre: {Nombre} / Edad: {Edad} / Turno: {Turno}";
        }
    }


    abstract class Negocio
    {
        public static void Main()
        {
            List<ISerVivo> zoologico = [];
            List<Cuidador> cuidadores = [];

            int opcionMenuPrinc;

            do
            {
                Console.WriteLine("\n\t\t Administracion de Zoologico ");
                Console.WriteLine(
                        "1. Agregar animal o planta \n2. Agregar cuidador \n3. Alimentar animal o planta \n4. Curar o hidratar \n5. Mostrar todos los seres vivos del zoologico. \n6. Mostrar todos los cuidadores. \n7. Salir");
                Console.Write("Seleccione una opcion: ");

                opcionMenuPrinc = int.Parse(Console.ReadLine() ?? string.Empty);

                switch (opcionMenuPrinc)
                {
                    case 1:
                        Console.WriteLine("\n1. Animal \n2. Planta");
                        Console.Write("Opcion: ");
                        int aniorplan = int.Parse(Console.ReadLine()!);

                        switch (aniorplan)
                        {
                            case 1:
                                Console.Write("Ingrese el nombre: ");
                                string nombre = Console.ReadLine()!;

                                Console.Write("\n¿Esta enfermo? s/n: ");
                                // Lee la entrada del usuario y la convierte en minúscula
                                char respuesta = char.ToLower(Console.ReadKey().KeyChar);
                                // Verifica si la respuesta es 's' (sí)
                                bool enfermo = respuesta == 's';

                                Console.Write("\n¿Esta alimentado? s/n: ");
                                respuesta = char.ToLower(Console.ReadKey().KeyChar);
                                bool alimentado = respuesta == 's';


                                Console.WriteLine("\nSeleccione el tipo de animal: \n1. Mamifero \n2. Ave \n3. Pez");
                                Console.Write("Opcion: ");
                                int tipoani = int.Parse(Console.ReadLine()!);

                                switch (tipoani)
                                {
                                    case 1:
                                        Console.WriteLine("\n1. Leon \n2. Chimpance");
                                        Console.Write("Opcion: ");
                                        int tipomami = int.Parse(Console.ReadLine()!);

                                        switch (tipomami)
                                        {
                                            case 1:
                                                var leon = new Leon(nombre, enfermo, alimentado);
                                                zoologico.Add(leon);
                                                break;

                                            case 2:
                                                var chimpance = new Chimpance(nombre, enfermo, alimentado);
                                                zoologico.Add(chimpance);
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
                                                var aguila = new AguilaReal(nombre, enfermo, alimentado);
                                                zoologico.Add(aguila);
                                                break;

                                            case 2:
                                                var pio = new Pio(nombre, enfermo, alimentado);
                                                zoologico.Add(pio);
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
                                                var pezPayaso = new PezPayaso(nombre, enfermo, alimentado);
                                                zoologico.Add(pezPayaso);
                                                break;

                                            case 2:
                                                var pezDorado = new PezDorado(nombre, enfermo, alimentado);
                                                zoologico.Add(pezDorado);
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
                                zoologico.Add(plantacarnivora);

                                break;
                        }

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:
                        foreach (var serVivo in zoologico)
                        {
                            Console.WriteLine(serVivo);
                        }

                        break;

                    case 6:

                        break;
                }

            } while (opcionMenuPrinc != 7);
        }
    }
}