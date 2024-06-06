namespace Zoologico
{
    public abstract class Mamifero : Animal
    {
        protected Mamifero() {}
        protected Mamifero(string? nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Clase = ClaseAnimal.Mamifero;
        }

        public static void Amamantar()
        {
            Console.WriteLine("El mamifero esta amamantando...");
        }
    }

    public class Leon : Mamifero
    {
        public Leon() {}
        public Leon(string? nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Especie = EspeciesAnimal.Leon;
            Comida = TiposComida.Carne;
        }
    }

    public class Chimpance : Mamifero
    {
        public Chimpance() {}
        public Chimpance(string? nombre, bool enfermo, bool alimentado) : base(nombre, enfermo, alimentado)
        {
            Especie = EspeciesAnimal.Chimpance;
            Comida = TiposComida.Frutas;
        }
    }
}
