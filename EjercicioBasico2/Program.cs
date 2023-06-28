//Ejercicio 2: Crear una clase "Círculo" que tenga una propiedad para el radio. Incluye métodos para calcular el área y la circunferencia del círculo.

Circulo circulo1 = new Circulo();
circulo1.Radio = 2;

double area = circulo1.CalcularArea;
double circunferencia = circulo1.CalcularCircunferencia;

Console.WriteLine("Area:" + area);
Console.WriteLine("Circunferencia:" + circunferencia);






class Circulo{
    public double Radio { get; set; }

    public double CalcularArea(){
        return Radio*3;
    }
    public double CalcularCircunferencia(){
        return 2*3*Radio;
    }
}