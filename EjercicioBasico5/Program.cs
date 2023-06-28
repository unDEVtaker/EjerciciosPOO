//Ejercicio 5: Crear una clase "Calculadora" que tenga métodos estáticos para realizar operaciones matemáticas básicas, como suma, resta, multiplicación y división.
Calculadora calcular1 = new Calculadora();
calcular1.num1= 4;
calcular1.num2= 5;


double sumaa= calcular1.CalcularSuma();
double restaa= calcular1.CalcularResta();
double multi= calcular1.CalcularMulti();
double div= calcular1.CalcularDiv();

Console.WriteLine("Suma: "+ sumaa);
Console.WriteLine("Resta: "+ restaa);
Console.WriteLine("Division: "+ div);
Console.WriteLine("Multiplicacion: "+ multi);

class Calculadora{
    public double num1 { get; set; }
    public double num2 { get; set; }
    public double CalcularSuma(){
        return num1+num2;
    }
    public double CalcularResta(){
        return num1-num2;
    }
    public double CalcularMulti(){
        return num1*num2;
    }    
    public double CalcularDiv(){
        if(num2 !=0){
            return (double) num1/num2;
        }
        else{
        Console.WriteLine("No se puede dividir por 0");
        return 0;
        }
    }
}