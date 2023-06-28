//Ejercicio 6: Crear una clase "CuentaBancaria" que tenga propiedades para el titular de la cuenta y el saldo. Incluye métodos para realizar depósitos, retiros y consultar el saldo actual.
CuentaBancaria cuenta1= new CuentaBancaria();
cuenta1.Titular="Valentina";
cuenta1.Saldo=100;
cuenta1.Depositar(10000);
cuenta1.Retirar(500);
cuenta1.ConsultarSaldo();




class CuentaBancaria{
    public string Titular { get; set; }
    public double Saldo { get; set; }

    public void Depositar(double monto){
        Saldo += monto;
    }
    public void Retirar (double monto){
        if(monto<= Saldo){
            Saldo-= monto;
        }
        else{
            Console.WriteLine("Saldo Insuficiente.");
        }
    }
    public void ConsultarSaldo(){
        Console.WriteLine("Saldo actual: "+ Saldo);
    }
}
