namespace Biblioteca;

public class ModificarClienteUseCase
{   
    public void Ejecutar(Cliente cli)
    {    
        RepositorioClienteArchTexto repo = new RepositorioClienteArchTexto();
        Boolean contiene = false;
        string? linea;
        using (StreamReader sr = new StreamReader("Clientes.txt"))
        {
            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                if (linea.Contains(cli.DNI.ToString()))
                    contiene = true;
            }
        }
        if (contiene is true)
            repo?.ModificarCliente(cli);
        else
            throw new Exception($"El cliente no existe en el repositorio.");
    }
}
