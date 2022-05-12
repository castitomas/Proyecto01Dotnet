namespace Biblioteca;

public class Cliente : Persona, IComparable
{
    private DateTime _UltimaFechaDeCompra;

    public Cliente(int dni, string apellido, string nombre, string direccion, DateTime fechaNacimiento, DateTime ultimaFechaCompra) :base(nombre, apellido, dni, direccion, fechaNacimiento)
    {
        this._UltimaFechaDeCompra = ultimaFechaCompra;
    }

    public DateTime UltimaFechaDeCompra
    {
        get => _UltimaFechaDeCompra;
        set => _UltimaFechaDeCompra = value;
    }

    public String DiasDesdeUltimaCompra
    {
        get { return (DateTime.Now - _UltimaFechaDeCompra).Days.ToString();}
    }

    public override string ToString()
    {
        return $"{Apellido}, {Nombre} ({DNI}) Dir: {Direccion} F.Nac: {FechaDeNacimiento} Ultima compra: {UltimaFechaDeCompra} [CLIENTE]";
    }

}