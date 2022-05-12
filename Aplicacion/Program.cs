
using Biblioteca;

// var agregarCliente = new AgregarClienteUseCase();
// agregarCliente.Ejecutar(new Cliente(18_000_000, "COLOMBO", "Marina", "calle 1 numero 1123", new DateTime(1960, 3, 14), new DateTime(2022, 4, 1)));
// agregarCliente.Ejecutar(new Cliente(30_000_000, "MARTINEZ", "Jose", "calle 12 numero 321", new DateTime(1980, 9, 12), new DateTime(2022, 1, 12)));
// agregarCliente.Ejecutar(new Cliente(32_000_000, "GARCIA", "Analia", "calle 13 numero 112", new DateTime(1982, 10, 29), DateTime.Today));
// agregarCliente.Ejecutar(new Cliente(40_000_000, "FERRETI", "Josefina", "Diag. 74 numero 13", new DateTime(2000, 1, 17), new DateTime(2022, 4, 11)));

// Listando los clientes con la cantidad de dias desde su ultima compra.

// var lista = new ListaDeClientesUseCase().Ejecutar();
// foreach(var cli in lista)
// {
//     Console.WriteLine($"{cli.Apellido}, {cli.Nombre}: {cli.DiasDesdeUltimaCompra} dias");
// }
// Console.ReadKey();

// Listando todos los clientes
// Observar como muestra los clientes el metodo Console.Writeline
// var lista = new ListaDeClientesUseCase().Ejecutar();
// foreach(var cli in lista)
// {
//     Console.WriteLine(cli);
// }
// Console.ReadKey();

// // Agregando un cliente que ya existe
// Cliente cli = new Cliente(30_000_000, "", "", "", new DateTime(), new DateTime());
// try
// {
//      new AgregarClienteUseCase().Ejecutar(cli);    
// }
// catch (Exception e)
// {
//      Console.WriteLine(e.Message);  
// }
// Console.ReadKey();



// Modificando un cliente
// Cliente cli = new Cliente(
//          30_000_000,
//          "MARTINEZ",
//          "Juan",
//          "calle 12 numero 321",
//          new DateTime(1980, 9, 12),
//          new DateTime(2022, 1, 12)
//      );
// new ModificarClienteUseCase().Ejecutar(cli);


// // Eliminando el cliente GARCIA que tiene DNI 32_000_000
// new EliminarClienteUseCase().Ejecutar(32_000_000);


// // Eliminando un cliente que no existe
// try 
// {
//     new EliminarClienteUseCase().Ejecutar(11_110_000);
// }
// catch (Exception e)
// {
//     Console.WriteLine(e.Message);
// }
// Console.ReadKey();


// // Agregando Empleados
// var agregarEmpleado = new AgregarEmpleadoUseCase();
// agregarEmpleado.Ejecutar(new Empleado(12_123_456, "SOSA", "Pablo", "calle numero 23", new DateTime(1950, 5, 16), 432));
// agregarEmpleado.Ejecutar(new Empleado(42_234_555, "RODRIGUEZ", "Juana", "Av. 7 numero 1223", new DateTime(1989, 2, 11), 112));
// agregarEmpleado.Ejecutar(new Empleado(43_015_771, "ALVAREZ", "Silvina", "Av. 25. numero 857", new DateTime(2001, 1, 24), 555));
// agregarEmpleado.Ejecutar(new Empleado(44_345_753, "ADAMI", "Julia", "calle 53 numero 423", new DateTime(1999, 7, 14), 987));
// agregarEmpleado.Ejecutar(new Empleado(20_789_654, "MARTINEZ", "Daniel", "calle 117 numero 54", new DateTime(1995, 8, 11), 741));

//Listando empleados
// var lista = new ListaDeEmpleadosUseCase().Ejecutar();
// foreach(var emp in lista)
// {
//     Console.WriteLine($"{emp.Apellido}, {emp.Nombre}: {emp.NumeroLegajo} ");
// }
// Console.ReadKey();

//Listando todos los empleados
//Observar como muestra los clientes el metodo Console.Writeline
// var lista = new ListaDeEmpleadosUseCase().Ejecutar();
// foreach(var emp in lista)
// {
//     Console.WriteLine(emp);
// }
// Console.ReadKey();


//Listando todas las personas ordenadas por Apellido y Nombre
// var lista = new ListaDePersonasUseCase().Ejecutar();
// foreach(var persona in lista)
// {
//     Console.WriteLine(persona);
// }
// Console.ReadKey();


// // Agregando un empleado que ya existe
// Empleado emp = new Empleado(44_345_753, "", "", "", new DateTime(), 123);
// try
// {
//      new AgregarEmpleadoUseCase().Ejecutar(emp);    
// }
// catch (Exception e)
// {
//      Console.WriteLine(e.Message);  
// }
// Console.ReadKey();


// // Modificando un empleado
// Empleado emp = new Empleado(
//          44_345_753,
//          "ADAMI",
//          "Romina",
//          "calle 53 numero 423",
//          new DateTime(1999, 7, 14),
//          987
//      );
// new ModificarEmpleadoUseCase().Ejecutar(emp);

// // Eliminando el empleado ALVAREZ que tiene DNI 43_015_771
// new EliminarEmpleadoUseCase().Ejecutar(43_015_771);

// // Eliminando un empleado que no existe
// try 
// {
//     new EliminarEmpleadoUseCase().Ejecutar(11_110_000);
// }
// catch (Exception e)
// {
//     Console.WriteLine(e.Message);
// }
// Console.ReadKey();