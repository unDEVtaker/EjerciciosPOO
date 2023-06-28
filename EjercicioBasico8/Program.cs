//Ejercicio 8: Crear una clase "Libro" que tenga propiedades para el título, el autor y el año de publicación. Incluye un método para imprimir los detalles del libro.
Libro libro1= new Libro();
libro1.Anio=1900;
libro1.Autor= "Valentina";
libro1.Titulo="Gatos al poder.";

libro1.Detalle();



class Libro{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Anio { get; set; }

    public void Detalle(){
        Console.WriteLine("---DETALLE LIBRO---");
        Console.WriteLine("Titulo: " +Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Año: " + Anio);
    }

}

