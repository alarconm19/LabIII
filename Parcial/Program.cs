namespace Parcial;

internal class MatrizLineal(int[] m)
{
    public void multiplica_x_escalar(int n)
    {
        foreach (int t in m)
        {
            Console.Write(" " + t * 2);
        }
    }
}

internal static class Program
{

    static void Main()
    {
        int[] m = new int[2];
        m[0] = 2;
        m[1] = m[0];
        MatrizLineal mat = new MatrizLineal(m);
        mat.multiplica_x_escalar(2);
        Console.ReadLine();
    }
}