//Ejercicio 3: Crear una clase "Estudiante" que tenga propiedades para el nombre y la edad. Incluye un método para imprimir los detalles del estudiante.

Alumno alumno1= new Alumno();
alumno1.Nombre="Jona";
alumno1.Edad=22;

alumno1.ImprimirDetalle();


class Alumno {
    public string Nombre { get; set; }
    public int Edad { get; set; }

public void ImprimirDetalle(){
    Console.WriteLine("Nombre:" + Nombre);
    Console.WriteLine("Edad:" + Edad);
}


}