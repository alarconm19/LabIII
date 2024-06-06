namespace Zoologico
{
    public abstract class Ave : Animal
    {
        protected Ave() { }
        protected Ave(string? nombre, bool enfermo, bool alimentado)
                : base(nombre, enfermo, alimentado)
        {
            Clase = ClaseAnimal.Ave;
        }

        public static void Volar()
        {
            Console.WriteLine("El ave esta volando...");
        }
    }

    public class AguilaReal : Ave
    {
        public AguilaReal() { }
        public AguilaReal(string? nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Especie = EspeciesAnimal.AguilaReal;
            Comida = TiposComida.Carne;
        }
    }

    public class Pio : Ave
    {
        public Pio() { }
        public Pio(string? nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Especie = EspeciesAnimal.Pio;
            Comida = TiposComida.Semillas;
        }
    }
}
