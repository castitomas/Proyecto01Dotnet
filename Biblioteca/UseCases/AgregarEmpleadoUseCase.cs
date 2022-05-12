namespace Biblioteca;

public class AgregarEmpleadoUseCase 
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
        if (contiene is false)
            repo?.AgregarEmpleado(emp);
        else 
            throw new Exception($"El empleado con DNI {emp.DNI} ya existe en el repositorio.");
        
    }
}