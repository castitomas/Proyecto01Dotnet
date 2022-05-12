namespace Biblioteca;

public class ListaDeClientesUseCase
{   
    public List<Cliente> Ejecutar()
    {    
        RepositorioClienteArchTexto repo = new RepositorioClienteArchTexto();
        return repo.GetClientes();
    }
}