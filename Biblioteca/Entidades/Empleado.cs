namespace Biblioteca;

public class Empleado : Persona
{
    private int _NumeroDeLegajo { get; set;}
    
    public Empleado(int dni, string apellido, string nombre, string direccion, DateTime fechaNacimiento, int numeroLegajo) :base(nombre, apellido, dni, direccion, fechaNacimiento)
    {
        this._NumeroDeLegajo = numeroLegajo;
    }

    public int NumeroLegajo
    {
        get => _NumeroDeLegajo;
        set => _NumeroDeLegajo = value;
    }

    public override string ToString()
    {
        return $"{Apellido}, {Nombre} ({DNI}) Dir: {Direccion} F.Nac: {FechaDeNacimiento} Legajo: {NumeroLegajo} [EMPLEADO]";
    }

   
}