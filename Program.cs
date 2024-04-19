	
public class Program
{
	
	/*Hacer una clase en C# que registre los datos de cinco personas como: Nombre, apellido,
      edad y telefono.*/
	
	
	public static void Main()
	{
		Console.Write("\nSe registraron las siguientes personas: \n");
        Console.Write("\nPersona 1: \n");
		Persona persona1 = new Persona("Jose","Perez",33,"1146932058");
		Console.WriteLine(persona1);
		Console.Write("\nPersona 2: \n");
		Persona persona2 = new Persona("Daniel","Garcia",22,"1143596503");
		Console.WriteLine(persona2);
		 Console.Write("\nPersona 3: \n");
		Persona persona3 = new Persona("Ricardo","Lopez",44,"1143672234");
		Console.WriteLine(persona3);
		Console.Write("\nPersona 4: \n");
		Persona persona4 = new Persona("Claudio","Dominguez",24,"1144578234");
		Console.WriteLine(persona4);
		Console.Write("\nPersona 5: \n");
		Persona persona5 = new Persona("Daniel","Ortega",35,"1143113512");
		Console.WriteLine(persona5);
		Console.Write("\nPrograma ha finalizado exitosamente.\n");
	}
}