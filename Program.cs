	
public class Program
{
	
	/*Hacer una clase en C# que registre los datos de cinco personas como: Nombre, apellido,
      edad y telefono.*/
	
	
	public static void Main()
	{
        Console.Write("\nPersona 1: \n");
		Persona persona1 = new Persona("Jose","Perez",33,"1146932058");
		Console.WriteLine(persona1);
		Console.Write("\nPersona 2: \n");
		Persona persona2 = new Persona("Juan","Garcia",22,"1143596503");
		Console.WriteLine(persona2);
		
	}
}