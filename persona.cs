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
			return "nombre: "+nombre+" \napellido: "+apellido+" \nedad: "+edad+" \ntelefono: "+telefono;
		}
	
	}