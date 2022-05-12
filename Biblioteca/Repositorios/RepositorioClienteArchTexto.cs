namespace Biblioteca;
using System.Collections.Generic;
using System.Linq;

public class RepositorioClienteArchTexto :IRepositorioCliente
{   

    public RepositorioClienteArchTexto(){}
    public void AgregarCliente(Cliente cliente)
    {
        using (StreamWriter sw = new StreamWriter("Clientes.txt", true))
        {
            sw.Write($" {cliente.DNI} | {cliente.Apellido} | {cliente.Nombre} | {cliente.Direccion} | {cliente.FechaDeNacimiento} | {cliente.UltimaFechaDeCompra} \n");
        }
    }

    public List<Cliente> GetClientes()
    {
        List<Cliente> lista = new List<Cliente>();
        using (StreamReader sr = new StreamReader("Clientes.txt"))
        {
            string? linea; 
            while(!sr.EndOfStream)
            {
                linea = sr.ReadLine();           
                List<string> cadena = linea.Split(new char[] {'|'}).ToList();
                int resultado;             
                Int32.TryParse(cadena.ElementAt(0), out resultado);
                lista.Add(new Cliente(resultado, cadena.ElementAt(1), cadena.ElementAt(2), cadena.ElementAt(3), Convert.ToDateTime(cadena.ElementAt(4)), Convert.ToDateTime(cadena.ElementAt(5))));
                cadena.Clear();
            }
        }
        return lista;
    }

    public Cliente? GetCliente(int DNI)
    {
        using (StreamReader sr = new StreamReader("Clientes.txt"))
        {
            string? linea;
            Boolean contiene = false;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                if (linea != null)
                    contiene = linea.Contains(DNI.ToString()); 
                if (contiene is true)
                {
                    List<string> cadena = linea.Split(new char[] {'|'}).ToList();
                    int resultado;
                    Int32.TryParse(cadena.ElementAt(0), out resultado);
                    Cliente cliente = new Cliente(resultado, cadena.ElementAt(1), cadena.ElementAt(2), cadena.ElementAt(3), Convert.ToDateTime(cadena.ElementAt(4)), Convert.ToDateTime(cadena.ElementAt(5)));
                    return cliente;
                }
            }
            return null;
        }
    }

    public void ModificarCliente(Cliente cliente)
    {   
        
        using (StreamReader sr = new StreamReader("Clientes.txt"))
        {
            using (StreamWriter sw = new StreamWriter("Temporal.txt"))
            {
                sw.WriteLine(sr.ReadToEnd());
            }
        }

        using (StreamReader sr = new StreamReader("Temporal.txt"))
        {
            using (StreamWriter sw = new StreamWriter("Clientes.txt"))
            {
                string? linea;
                Boolean contiene = false;
                while(!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    if (linea != null)
                        contiene = linea.Contains(cliente.DNI.ToString());
                    if (contiene is true)
                    {
                        sw.WriteLine($"{cliente.DNI} | {cliente.Apellido} | {cliente.Nombre} | {cliente.Direccion} | {cliente.FechaDeNacimiento} | {cliente.UltimaFechaDeCompra}");                       
                    } else if (contiene is false)
                        sw.WriteLine(linea);
                }
            }
        }
        File.Delete("Temporal.txt");
    }

    public void EliminarCliente(int DNI)
    {
        using (StreamReader sr = new StreamReader("Clientes.txt"))
        {
            using (StreamWriter sw = new StreamWriter("Temporal.txt"))
            {
                sw.WriteLine(sr.ReadToEnd());
            }
        }

        using (StreamReader sr = new StreamReader("Temporal.txt"))
        {
            using (StreamWriter sw = new StreamWriter("Clientes.txt"))
            {
                string? linea;
                Boolean contiene = false;
                while (!sr.EndOfStream)
                {                
                    linea = sr.ReadLine();
                    if (linea != null)
                        contiene = linea.Contains(DNI.ToString());
                    if (contiene is false)
                        sw.WriteLine(linea);
                    else if (contiene == true) 
                        continue;

                }
            }
        }
        File.Delete("Temporal.txt");
    }
}