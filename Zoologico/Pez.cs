namespace Zoologico
{
    public abstract class Pez : Animal
    {
        protected Pez() { }
        protected Pez(string? nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Clase = ClaseAnimal.Pez;
        }

        public static void Nadar()
        {
            Console.WriteLine("El pez esta nadando...");
        }
    }

    public class PezPayaso : Pez
    {
        public PezPayaso() { }
        public PezPayaso(string? nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Especie = EspeciesAnimal.PezPayaso;
            Comida = TiposComida.PecesPequenos;
        }
    }

    public class PezDorado : Pez
    {
        public PezDorado() { }
        public PezDorado(string? nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Especie = EspeciesAnimal.PezDorado;
            Comida = TiposComida.Algas;
        }
    }
}
