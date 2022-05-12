namespace Biblioteca;

public class AgregarClienteUseCase 
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
        // var lineas = File.ReadAllLines("Clientes.txt");
        // foreach (var linea in lineas)
        // {
        //     if (linea.Contains(cli.DNI.ToString()))
        //         contiene = true;
        // }
        if (contiene is false)
            repo?.AgregarCliente(cli);
        else 
            throw new Exception($"El cliente con DNI {cli.DNI} ya existe en el repositorio.");
        
    }
}
