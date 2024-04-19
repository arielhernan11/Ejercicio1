using System;
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
			return "Nombre: "+nombre+" \nApellido: "+apellido+" \nEdad: "+edad+" \nTelefono: "+telefono;
		}
	
	}