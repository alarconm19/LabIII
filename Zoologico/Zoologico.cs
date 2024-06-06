
namespace Zoologico
{
    public class Zoologico
    {
        public List<Animal>? Animales { get; set; }
        public List<Planta>? Plantas { get; set; }
        public List<Cuidador>? Cuidadores { get; set; }

        public Zoologico() {}
        public Zoologico(List<Animal> animales, List<Planta> plantas, List<Cuidador> cuidadores)
        {
            Animales = animales;
            Plantas = plantas;
            Cuidadores = cuidadores;
        }

        public List<Animal>? GetAnimales()
        {
            return Animales;
        }

        public List<Planta>? GetPlantas()
        {
            return Plantas;
        }

        public List<Cuidador>? GetCuidadores()
        {
            return Cuidadores;
        }
    }
}
