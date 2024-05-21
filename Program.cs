// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);


Console.WriteLine("Ingrese un numero: ");
string entrada=Console.ReadLine();
bool anda = int.TryParse(entrada,out int num);
if(anda){
int Invertido=0;

while (num>0)//ej 237
 {
    int digito=num%10;//7,,3
    Invertido=(Invertido *10)+ digito;//0+7=7,,7*10+3=73,,,
    num=num/10;//pierde ultima cifra,,23
}
Console.WriteLine("El numero invertido es: "+Invertido);


//CALCULADORA V1
Console.WriteLine("Ingrese dos numeros enteros");
int opcion;
int operacion;
int resultado;
do
{
    
    Console.WriteLine("Seleccione la operacion que desea realizar:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    operacion=int.Parse(Console.ReadLine());

     Console.Write("Ingrese el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

        switch (operacion)
        {
            case 1: 
                resultado=numero1+numero2;
                Console.Write($"El resultado de sumar {numero1} y {numero2} es: {resultado}");
                break;
            case 2: 
                resultado=numero1-numero2;
                Console.Write($"El resultado de restar {numero1} y {numero2} es: {resultado}");
                break;
            case 3: 
                resultado=numero1*numero2;
                Console.Write($"El resultado de multiplicar {numero1} y {numero2} es: {resultado}");
                break;
            case 4: 
                if(numero2!=0){
                resultado=numero1/numero2;
                Console.Write($"El resultado de multiplicar {numero1} y {numero2} es: {resultado}");
                }else{
                    Console.WriteLine("No se puede dividir por 0");
                }
                break;
            default:
                Console.WriteLine("No se puede realizar la operacion");
                break;
        }

    Console.WriteLine("¿Desea realizar otra operación? (1: Si, 0: No)");
    string confirmacion = Console.ReadLine();
    int.TryParse(confirmacion, out opcion);
} while (opcion == 1);
}
//calculadora v2
int opcion;

do
{
    Console.WriteLine("Ingrese un numero");
     if (!float.TryParse(Console.ReadLine(), out float numero))
                {
                    Console.WriteLine("Numero no valido, ingrese otro");
                }
    Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
    Console.WriteLine($"Cuadrado: {Math.Pow(numero, 2)}");
    Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");


    double radianes = numero * (Math.PI / 180);
    Console.WriteLine($"Seno: {Math.Sin(radianes)}");
    Console.WriteLine($"Coseno: {Math.Cos(radianes)}");


    Console.WriteLine("Ingrese dos numeros enteros");
    int.TryParse(Console.ReadLine(), out int numero1);
    int.TryParse(Console.ReadLine(), out int numero2);
    int max = Math.Max(numero1, numero2);
    int min = Math.Min(numero1, numero2);
    Console.WriteLine($"El máximo entre {numero1} y {numero2} es: {max}");
    Console.WriteLine($"El mínimo entre {numero1} y {numero2} es: {min}");
    


    Console.WriteLine("¿Desea realizar otra operación? (1: Si, 0: No)");
    string confirmacion = Console.ReadLine();
    int.TryParse(confirmacion, out opcion);
} while (opcion == 1);