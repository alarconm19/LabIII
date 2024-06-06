namespace Zoologico
{
    public class Cuidador
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public Turno Turno { get; set; }

        public Cuidador() {}
        public Cuidador(string? nombre, int edad, Turno turno)
        {
            Nombre = nombre;
            Edad = edad;
            Turno = turno;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} / Edad: {Edad} / Turno: {Turno}";
        }
    }

    public enum Turno
    {
        Mañana,
        Tarde,
        Noche
    }
}
