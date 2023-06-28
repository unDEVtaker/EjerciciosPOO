//Ejercicio 4: Crear una clase "Persona" que tenga propiedades para el nombre, la edad y el género. Incluye un método para imprimir los detalles de la persona.
Persona persona1= new Persona();
persona1.Nombre="luis";
persona1.Edad=22;
persona1.Genero="F";

persona1.ImprimirDetalle();


class Persona{
    public int Edad { get; set; }
    public string Nombre { get; set; }
    public string Genero { get; set; }

    public void ImprimirDetalle (){
        Console.WriteLine("Nombre: "+ Nombre);
        Console.WriteLine("Edad: "+ Edad);
        Console.WriteLine("Genero: "+ Genero);
    }

}