namespace Biblioteca;

public abstract class Persona :IComparable
{
    private string _nombre;
    private string _apellido;
    private int _DNI;
    private string _direccion { get; set; }
    private DateTime _FechaDeNacimiento { get; set; }


    public Persona(string nombre, string apellido, int dni, string direccion, DateTime fechaNacimiento)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.DNI = dni;
        this.Direccion = direccion;
        this.FechaDeNacimiento = fechaNacimiento;
    }

    public string Nombre
    {
        get => _nombre;
        set => _nombre = value;
    }

    public string Apellido
    {
        get => _apellido;
        set => _apellido = value;
    }

    public int DNI
    {
        get => _DNI;
        set => _DNI = value;
    }

    public string Direccion
    {
        get => _direccion;
        set => _direccion = value;
    }

    public DateTime FechaDeNacimiento 
    {
        get => _FechaDeNacimiento;
        set => _FechaDeNacimiento = value;
    }

    public int CompareTo(object? obj)
    {
        int result = 0;
        if (obj is Persona)
        {
            string apellido = ((Persona)obj).Apellido;
            result = this.Apellido.CompareTo(apellido);
            if (result == 0)
            {
                string nombre = ((Persona)obj).Nombre;
                result = this.Nombre.CompareTo(nombre);
            }
        }
        return result;
    }
}