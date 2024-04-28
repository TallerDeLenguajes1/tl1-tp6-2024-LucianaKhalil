// See https://aka.ms/new-console-template for more information
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

}
