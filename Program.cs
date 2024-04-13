using System;
					
public class Program
{
	
	/*Hacer una clase en C# que registre los datos de cinco personas como: Nombre, apellido,
      edad y telefono.*/
	class Persona
	{
		public String nombre ;
		public String apellido;
		public int edad;
		public String telefono;
		
		
		public Persona(String nombre, String apellido , int edad , String telefono)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.edad = edad ;
			this.telefono = telefono;
		
		}
		
		public override String ToString()
		{
			return "nombre: "+nombre+" \napellido: "+apellido+" \nedad: "+edad+" \ntelefono: "+telefono;
		}
	
	}
	
	public static void Main()
	{
        Console.Write("\nPersona 1: \n");
		Persona persona1 = new Persona("Jose","Perez",41,"1139528123");
		Console.WriteLine(persona1);
		Console.Write("\nPersona 2: \n");
		Persona persona2 = new Persona("Juan","Garcia",41,"1151365610");
		Console.WriteLine(persona2);
		
	}
}