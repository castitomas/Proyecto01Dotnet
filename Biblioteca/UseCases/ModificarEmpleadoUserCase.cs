namespace Biblioteca;

public class ModificarEmpleadoUseCase
{   
    public void Ejecutar(Empleado emp)
    {    
        RepositorioEmpleadoArchTexto repo = new RepositorioEmpleadoArchTexto();
        Boolean contiene = false;
        string? linea;
        using (StreamReader sr = new StreamReader("Empleados.txt"))
        {
            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                if (linea.Contains(emp.DNI.ToString()))
                    contiene = true;
            }
        }
        if (contiene is true)
            repo?.ModificarEmpleado(emp);
        else
            throw new Exception($"El empleado no existe en el repositorio.");
    }
}
