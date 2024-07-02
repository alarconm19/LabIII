
namespace Zoologico
{
    public abstract class Animal : ISerVivo
    {
        public string? Nombre { get; set; }
        public ClaseAnimal Clase { get; init; }
        public EspeciesAnimal Especie { get; init; }
        public TiposComida Comida { get; init; }
        public bool Enfermo { get; set; }
        public bool Alimentado { get; set; }

        protected Animal() {}
        protected Animal(string? nombre, bool enfermo, bool alimentado)
        {
            Nombre = nombre;
            Enfermo = enfermo;
            Alimentado = alimentado;
        }

        public void Alimentar()
        {
            Console.WriteLine($"Se esta alimentando al animal con {Comida}...");
            Alimentado = true;
            Console.WriteLine("El animal ha comido. ");
        }

        public void Curar()
        {
            Console.WriteLine("Se esta curando al animal...");
            Enfermo = false;
            Console.WriteLine("El animal ha sido curado. ");
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} / Especie: {Clase} / Alimentado : {Alimentado} / Enfermo: {Enfermo} / Tipo de comida: {Comida}";
        }
    }

    public enum ClaseAnimal
    {
        Mamifero,
        Ave,
        Pez
    }
}
