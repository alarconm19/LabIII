namespace Clase_1;


public static class Clase1 {
    static void Main()
    {
        PrimeraApp();
    }

    static void Ej1() {
        Console.WriteLine("Ingrese un numero: ");

        string entrada = Console.ReadLine()!;

        int.TryParse(entrada, out int numero);

        double n = 1;

        for (int i = 1; i <= numero; i++) {
            n *= i;
        }

        Console.WriteLine($"El factorial de {numero} es: {n}");
    }

    static void Ej2() {
        Console.WriteLine("Seleccione día de la semana que fue el primero de este año: ");
        Console.WriteLine("1. Lunes \n2. Martes \n3. Miercoles \n4. Jueves \n5. Viernes \n6. Sabado \n7. Domingo");
        Console.Write("Ingrese el numero: ");
        
        int.TryParse(Console.ReadLine(), out int primerDia);
        if (primerDia == 7) primerDia = 0;


        Console.WriteLine("Ese año es bisiesto? (s/n): ");
        // Lee la entrada del usuario y la convierte en minúscula
        char respuesta = char.ToLower(Console.ReadKey().KeyChar);

        // Verifica si la respuesta es 's' (sí)
        bool bisiesto = respuesta == 's';


        var fechaCreada = new DateTime(1, 1, 1);

        while ((int)fechaCreada.DayOfWeek != primerDia || bisiesto && !EsBisiesto(fechaCreada.Year))
        {
            fechaCreada = fechaCreada.AddYears(1);
        }


        Console.Write("\nIngrese el dia del mes del cual quiera saber el dia de la semana: ");
        int.TryParse(Console.ReadLine(), out int diaASaber);

        Console.Write("Ingrese el mes del cual quiera saber el dia de la semana: ");
        int.TryParse(Console.ReadLine(), out int mesASaber);

        fechaCreada = fechaCreada.AddMonths(mesASaber - 1);
        Console.WriteLine($"\nEl dia de la semana del dia {diaASaber} del mes {mesASaber} es: {fechaCreada.AddDays(diaASaber - 1).DayOfWeek}");


        Console.Write("Los dias que caen finde son: ");

        while (fechaCreada.Month == mesASaber)
        {
            if (fechaCreada.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                Console.Write($"{fechaCreada.Day} - ");

            fechaCreada = fechaCreada.AddDays(1);
        }

    }

    static bool EsBisiesto(int año)
    {
        return año % 4 == 0 && año % 100 != 0 || año % 400 == 0;
    }

    static void Prueba()
    {
        // Obtener la fecha
        var fecha = new DateTime(0001, 12, 18);


        var nuevoDiaSemana = DayOfWeek.Saturday;

        // Calcular la diferencia de días entre el día de la semana actual y el deseado
        int diferenciaDias = ((int)nuevoDiaSemana - (int)fecha.DayOfWeek + 7) % 7;

        // Crear una nueva fecha sumando la diferencia de días a la fecha actual
        var nuevaFecha = fecha.AddDays(diferenciaDias);


        // Imprimir la fecha 
        Console.WriteLine($"Fecha : {(int)nuevoDiaSemana} - {nuevaFecha.DayOfWeek}");
    }

    static void PrimeraApp()
    {
        Console.WriteLine("Ingrese el primer valor:");
        double.TryParse(Console.ReadLine(), out double valor1);

        Console.WriteLine("Ingrese el segundo valor:");
        double.TryParse(Console.ReadLine(), out double valor2);

        Console.WriteLine("\nResultados de las cuatro operaciones básicas:");
        Console.WriteLine($"Suma: {valor1} + {valor2} = {valor1 + valor2}");
        Console.WriteLine($"Resta: {valor1} - {valor2} = {valor1 - valor2}");
        Console.WriteLine($"Multiplicación: {valor1} * {valor2} = {valor1 * valor2}");
        Console.WriteLine($"División: {valor1} / {valor2} = {valor1 / valor2}");
    }
}