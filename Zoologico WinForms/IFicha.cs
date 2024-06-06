namespace Zoologico_WinForms;

public interface IFicha<out T>
{
    T? Objeto { get; }
}