//Ejercicio 1: Crear una clase "Rectángulo" que tenga propiedades para la longitud y el ancho. Incluye métodos para calcular el área y el perímetro del rectángulo.

Rectangulo rectangulo1= new Rectangulo();
rectangulo1.Ancho = 5;
rectangulo1.Longitud = 3;

double area = rectangulo1.CalcularArea();
double perimetro= rectangulo1.CalcularPerimetro();

Console.WriteLine("Area: " + area);
Console.WriteLine("Perimetro: " + perimetro);

class Rectangulo{
    public double Longitud { get; set; }
    public double Ancho { get; set; }

    public double CalcularArea(){
        return Longitud* Ancho;
    }

    public double CalcularPerimetro(){
        return 2* (Longitud+ Ancho);
    }
}

