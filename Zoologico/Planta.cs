using System.ComponentModel;

namespace Zoologico
{
    public abstract class Planta : ISerVivo
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public EspeciesPlanta Especie { get; init; }
        public bool Hidratada { get; set; }

        protected Planta() {}
        protected Planta(bool hidratada)
        {
            Hidratada = hidratada;
        }

        public void Hidratar()
        {
            Console.WriteLine("Se esta regando la planta...");
            Hidratada = true;
            Console.WriteLine("La planta esta hidratada.");
        }
    }

    public class PlantaCarnivora : Planta
    {
        public bool Alimentada { get; set; }
        public static TiposComida Comida => TiposComida.Insectos;

        public PlantaCarnivora() {}
        public PlantaCarnivora(bool hidratada, bool alimentada)
        {
            Especie = EspeciesPlanta.PlantaCarnivora;
            Alimentada = alimentada;
            Hidratada = hidratada;
        }

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

    public enum EspeciesPlanta
    {
        [Description("Planta carnívora")]
        PlantaCarnivora
    }
}
