namespace CajeroAutomatico;

internal abstract class CajeroAutomatico
{
    public class Cuenta(string numeroCuenta, Usuario titular, decimal saldoInicial)
    {
        public string NumeroCuenta { get; } = numeroCuenta;
        public Usuario Titular { get; set; } = titular;
        decimal Saldo { get; set; } = saldoInicial;
        public List<Transaccion> HistorialTransacciones { get; set; } = [];
        public decimal LimiteRetiro { get; set; } // Inicialmente no se puede retirar en negativo

        public void Depositar(decimal monto, Cajero cajero)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto debe ser mayor que cero.");
            }

            Saldo += monto;
            HistorialTransacciones.Add(new Transaccion(cajero, DateTime.Now, monto, TipoTransaccion.Deposito));
        }

        public void Extraer(decimal monto, Cajero cajero)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto debe ser mayor que cero.");
            }

            if (Saldo + LimiteRetiro < monto)
            {
                throw new InvalidOperationException("Saldo insuficiente para realizar la extracción.");
            }

            Saldo -= monto;
            HistorialTransacciones.Add(new Transaccion(cajero, DateTime.Now, monto, TipoTransaccion.Extraccion));
        }
    }

    public class Usuario(string nombre, bool esJubilado, Cuenta cuenta)
    {
        public string Nombre { get; set; } = nombre;
        public bool EsJubilado { get; set; } = esJubilado;
        public Cuenta Cuenta { get; set; } = cuenta;
    }

    public class Cajero(string direccion, int numeroCajero)
    {
        public string Direccion { get; set; } = direccion;
        public int NumeroCajero { get; set; } = numeroCajero;
    }

    public class Transaccion(Cajero cajero, DateTime fecha, decimal monto, TipoTransaccion tipo)
    {
        public Cajero Cajero { get; set; } = cajero;
        public DateTime Fecha { get; set; } = fecha;
        public decimal Monto { get; set; } = monto;
        public TipoTransaccion Tipo { get; set; } = tipo;
    }

    public enum TipoTransaccion
    {
        Deposito,
        Extraccion
    }

    static void VerificarCreditoPreacordado(Usuario usuario)
    {
        var fechaInicio = DateTime.Now.AddMonths(-2);
        decimal saldoAcumulado = 0;

        foreach (var transaccion in usuario.Cuenta.HistorialTransacciones)
        {
            if (transaccion.Fecha >= fechaInicio && transaccion.Tipo == TipoTransaccion.Deposito)
            {
                saldoAcumulado += transaccion.Monto;
            }
        }

        if (saldoAcumulado <= 20000) return;
        usuario.Cuenta.LimiteRetiro = 80000;
        Console.WriteLine($"Se ha ofrecido un crédito preacordado de 80000 al usuario {usuario.Nombre}.");
    }



    static void Main()
    {
        List<Usuario> usuarios = [];

        List<Cajero> cajeros =
        [
                new Cajero("Calle 1", 1),
                new Cajero("Avenida 2", 2),
                new Cajero("Plaza 3", 3)
        ];

        while (true)
        {
            Console.WriteLine("\n--- Cajero Automático ---");
            Console.WriteLine("1. Crear cuenta");
            Console.WriteLine("2. Realizar depósito");
            Console.WriteLine("3. Realizar extracción");
            Console.WriteLine("4. Verificar crédito preacordado");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            
            string opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    CrearCuenta(usuarios);
                    break;

                case "2":
                    RealizarDeposito(usuarios, cajeros);
                    break;

                case "3":
                    RealizarExtraccion(usuarios, cajeros);
                    break;

                case "4":
                    VerificarCreditoPreacordado(usuarios);
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    static void CrearCuenta(List<Usuario> usuarios)
    {
        Console.WriteLine("\n--- Crear cuenta ---");
        
        Console.Write("Ingrese el nombre del usuario: ");
        string nombre = Console.ReadLine()!;

        Console.Write("¿Es jubilado? (s/n): ");
        bool esJubilado = Console.ReadLine()!.ToLower() == "s";

        Console.Write("Ingrese el saldo inicial: ");
        decimal saldoInicial = decimal.Parse(Console.ReadLine()!);

        var cuenta = new Cuenta(Guid.NewGuid().ToString(), new Usuario(nombre, esJubilado, null!), saldoInicial);
        var usuario = new Usuario(nombre, esJubilado, cuenta);

        cuenta.Titular = usuario;

        usuarios.Add(usuario);

        Console.WriteLine($"Cuenta creada con éxito para {nombre}. Número de cuenta: {cuenta.NumeroCuenta}");
    }

    static void RealizarDeposito(List<Usuario> usuarios, List<Cajero> cajeros)
    {
        Console.WriteLine("\n--- Realizar depósito ---");

        var usuario = SeleccionarUsuario(usuarios);
        if (usuario == null!)
        {
            return;
        }

        var cajero = SeleccionarCajero(cajeros);
        if (cajero == null!)
        {
            return;
        }

        Console.Write("Ingrese el monto a depositar: ");
        decimal monto = decimal.Parse(Console.ReadLine()!);

        try
        {
            usuario.Cuenta.Depositar(monto, cajero);
            Console.WriteLine($"Depósito de {monto} realizado con éxito.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void RealizarExtraccion(List<Usuario> usuarios, List<Cajero> cajeros)
    {
        Console.WriteLine("\n--- Realizar extracción ---");

        var usuario = SeleccionarUsuario(usuarios);
        if (usuario == null!)
        {
            return;
        }

        var cajero = SeleccionarCajero(cajeros);
        if (cajero == null!)
        {
            return;
        }

        Console.Write("Ingrese el monto a extraer: ");
        decimal monto = decimal.Parse(Console.ReadLine()!);

        try
        {
            usuario.Cuenta.Extraer(monto, cajero);
            Console.WriteLine($"Extracción de {monto} realizada con éxito.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void VerificarCreditoPreacordado(List<Usuario> usuarios)
    {
        Console.WriteLine("\n--- Verificar crédito preacordado ---");

        var usuario = SeleccionarUsuario(usuarios);
        if (usuario == null!)
        {
            return;
        }

        VerificarCreditoPreacordado(usuario);
    }

    static Usuario SeleccionarUsuario(List<Usuario> usuarios)
    {
        Console.Write("Ingrese el nombre del usuario: ");
        string nombre = Console.ReadLine()!;

        var usuario = usuarios.Find(u => u.Nombre == nombre);

        if (usuario != null) return usuario;
        Console.WriteLine($"Usuario {nombre} no encontrado.");
        return null!;

    }

    static Cajero SeleccionarCajero(List<Cajero> cajeros)
    {
        Console.WriteLine("\nCajeros disponibles:");
        for (int i = 0; i < cajeros.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {cajeros[i].Direccion} - Número de cajero: {cajeros[i].NumeroCajero}");
        }

        Console.Write("Seleccione un cajero (1, 2, 3...): ");
        int indice = int.Parse(Console.ReadLine()!);

        if (indice >= 1 && indice <= cajeros.Count) return cajeros[indice - 1];
        Console.WriteLine("Índice de cajero inválido.");
        return null!;

    }
}
