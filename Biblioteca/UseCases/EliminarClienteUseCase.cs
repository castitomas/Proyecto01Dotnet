namespace Biblioteca;

public class EliminarClienteUseCase
{
    public void Ejecutar(int DNI)
    {
        RepositorioClienteArchTexto repo = new RepositorioClienteArchTexto();
        Boolean contiene = false;
        string? linea;
        using (StreamReader sr = new StreamReader("Clientes.txt"))
        {
            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                if (linea.Contains(DNI.ToString()))
                    contiene = true;
            }
        }
        if (contiene is true)
            repo.EliminarCliente(DNI);
        else
            throw new Exception ($"El cliente con DNI {DNI} no existe en el repositorio.");   
    }
}