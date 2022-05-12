namespace Biblioteca;

public class EliminarEmpleadoUseCase
{
    public void Ejecutar(int DNI)
    {
        RepositorioEmpleadoArchTexto repo = new RepositorioEmpleadoArchTexto();
        Boolean contiene = false;
        string? linea;
        using (StreamReader sr = new StreamReader("Empleados.txt"))
        {
            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                if (linea.Contains(DNI.ToString()))
                    contiene = true;
            }
        }
        if (contiene is true)
            repo.EliminarEmpleado(DNI);
        else
            throw new Exception ($"El empleado con DNI {DNI} no existe en el repositorio.");   
    }
}