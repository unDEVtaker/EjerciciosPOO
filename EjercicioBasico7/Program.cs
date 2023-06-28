//Ejercicio 7: Crear una clase "Triángulo" que tenga propiedades para la longitud de cada uno de sus lados. Incluye un método para determinar si el triángulo es equilátero (todos los lados son iguales), isósceles (dos lados son iguales) o escaleno (todos los lados son diferentes).
Triangulo triangulo1 = new Triangulo();
triangulo1.Lado1= 10;
triangulo1.Lado2= 5;
triangulo1.Lado3= 20;

string TipoTri = triangulo1.Tipo();
Console.WriteLine("Tipo: "+TipoTri);


class Triangulo{
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }
    public double Lado3 { get; set; }

    public string Tipo(){
        if(Lado1==Lado2&&Lado1==Lado3){
            return "Equilatero";
        }
        else if(Lado1==Lado2||Lado1==Lado3||Lado2==Lado3){
            return "Isosceles";
        }
        else{
            return "Escaleno";
        }
        }
}