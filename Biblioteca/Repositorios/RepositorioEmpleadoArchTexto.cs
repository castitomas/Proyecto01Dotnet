namespace Biblioteca;
using System.Collections.Generic;
using System.Linq;

public class RepositorioEmpleadoArchTexto
{

    public void AgregarEmpleado(Empleado empleado)
    {
        using (StreamWriter sw = new StreamWriter("Empleados.txt", true))
        {
            sw.Write($" {empleado.DNI} | {empleado.Apellido} | {empleado.Nombre} | {empleado.Direccion} | {empleado.FechaDeNacimiento} | {empleado.NumeroLegajo} \n");
        }
    }

    public List<Empleado> GetEmpleados()
    {
        List<Empleado> lista = new List<Empleado>();
        using (StreamReader sr = new StreamReader("Empleados.txt"))
        {
            string? linea; 
            while(!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                List<string> cadena = linea.Split(new char[] {'|'}).ToList();
                int resultado;             
                Int32.TryParse(cadena.ElementAt(0), out resultado);
                lista.Add(new Empleado(resultado, cadena.ElementAt(1), cadena.ElementAt(2), cadena.ElementAt(3), Convert.ToDateTime(cadena.ElementAt(4)), int.Parse(cadena.ElementAt(5))));
                cadena.Clear();
            }
        }
        return lista;
    }

    public Empleado? GetEmpleado(int DNI)
    {
        using (StreamReader sr = new StreamReader("Empleados.txt"))
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
                    Empleado empleado = new Empleado(resultado, cadena.ElementAt(1), cadena.ElementAt(2), cadena.ElementAt(3), Convert.ToDateTime(cadena.ElementAt(4)), int.Parse(cadena.ElementAt(5)));
                    return empleado;
                }
            }
            return null;
        }
    }

    public void ModificarEmpleado(Empleado empleado)
    {   
        
        using (StreamReader sr = new StreamReader("Empleados.txt"))
        {
            using (StreamWriter sw = new StreamWriter("Temporal.txt"))
            {
                sw.WriteLine(sr.ReadToEnd());
            }
        }

        using (StreamReader sr = new StreamReader("Temporal.txt"))
        {
            using (StreamWriter sw = new StreamWriter("Empleados.txt"))
            {
                string? linea;
                Boolean contiene = false;
                while(!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    if (linea != null)
                        contiene = linea.Contains(empleado.DNI.ToString());
                    if (contiene is true)
                    {
                        sw.WriteLine($"{empleado.DNI} | {empleado.Apellido} | {empleado.Nombre} | {empleado.Direccion} | {empleado.FechaDeNacimiento} | {empleado.NumeroLegajo}");                       
                    } else if (contiene is false)
                        sw.WriteLine(linea);
                }
            }
        }
        File.Delete("Temporal.txt");
    }


    public void EliminarEmpleado(int DNI)
    {
        using (StreamReader sr = new StreamReader("Empleados.txt"))
        {
            using (StreamWriter sw = new StreamWriter("Temporal.txt"))
            {
                sw.WriteLine(sr.ReadToEnd());
            }
        }

        using (StreamReader sr = new StreamReader("Temporal.txt"))
        {
            using (StreamWriter sw = new StreamWriter("Empleados.txt"))
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