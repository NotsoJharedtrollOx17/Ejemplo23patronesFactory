
Console.WriteLine("EJEMPLO BREVE FACTORY METHOD 23 PATRONES JAVA");
Console.WriteLine("INICIO");
Cliente cliente;
cliente = new ClienteContado();
cliente.nuevoCliente();
cliente = new ClienteCredito();
cliente.nuevoCliente();
Console.WriteLine("FIN");