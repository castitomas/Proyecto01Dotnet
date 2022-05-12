namespace Biblioteca;

public class ListaDeEmpleadosUseCase
{   
    public List<Empleado> Ejecutar()
    {    
        RepositorioEmpleadoArchTexto repo = new RepositorioEmpleadoArchTexto();
        return repo.GetEmpleados();
    }
}