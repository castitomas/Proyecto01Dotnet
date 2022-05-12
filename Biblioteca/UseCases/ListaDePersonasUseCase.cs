namespace Biblioteca;
using System.Collections.Generic;


public class ListaDePersonasUseCase 
{   
    public List<Persona> Ejecutar()
    {    
        RepositorioEmpleadoArchTexto repoE = new RepositorioEmpleadoArchTexto();
        RepositorioClienteArchTexto repoC = new RepositorioClienteArchTexto();
        
        List<Cliente> listaClientes = repoC.GetClientes();
        List<Empleado> listaEmpleados = repoE.GetEmpleados();

        List<Persona> listaPersonas = new List<Persona>();

        foreach(var c in listaClientes)
        {
            listaPersonas.Add(c);
        }
        foreach(var e in listaEmpleados)
        {
            listaPersonas.Add(e);
        }

        listaPersonas.Sort();

        return listaPersonas;
    }
}