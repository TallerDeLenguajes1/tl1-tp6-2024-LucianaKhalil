// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

// Console.WriteLine("Hello, World!");

// int a;
// int b;

// a=10;
// b=a;

// Console.WriteLine("valor de a: "+a);
// Console.WriteLine("valor de b: "+b);


// Console.WriteLine("Ingrese un numero: ");
// string entrada=Console.ReadLine();
// bool anda = int.TryParse(entrada,out int num);
// if(anda){
// int Invertido=0;

// while (num>0)//ej 237
//  {
//     int digito=num%10;//7,,3
//     Invertido=(Invertido *10)+ digito;//0+7=7,,7*10+3=73,,,
//     num=num/10;//pierde ultima cifra,,23
// }
// Console.WriteLine("El numero invertido es: "+Invertido);


// //CALCULADORA V1
// Console.WriteLine("Ingrese dos numeros enteros");
// int opcion;
// int operacion;
// int resultado;
// do
// {
    
//     Console.WriteLine("Seleccione la operacion que desea realizar:");
//     Console.WriteLine("1. Sumar");
//     Console.WriteLine("2. Restar");
//     Console.WriteLine("3. Multiplicar");
//     Console.WriteLine("4. Dividir");
//     operacion=int.Parse(Console.ReadLine());

//      Console.Write("Ingrese el primer numero: ");
//             int numero1 = int.Parse(Console.ReadLine());
//             Console.Write("Ingrese el segundo numero: ");
//             int numero2 = int.Parse(Console.ReadLine());

//         switch (operacion)
//         {
//             case 1: 
//                 resultado=numero1+numero2;
//                 Console.Write($"El resultado de sumar {numero1} y {numero2} es: {resultado}");
//                 break;
//             case 2: 
//                 resultado=numero1-numero2;
//                 Console.Write($"El resultado de restar {numero1} y {numero2} es: {resultado}");
//                 break;
//             case 3: 
//                 resultado=numero1*numero2;
//                 Console.Write($"El resultado de multiplicar {numero1} y {numero2} es: {resultado}");
//                 break;
//             case 4: 
//                 if(numero2!=0){
//                 resultado=numero1/numero2;
//                 Console.Write($"El resultado de multiplicar {numero1} y {numero2} es: {resultado}");
//                 }else{
//                     Console.WriteLine("No se puede dividir por 0");
//                 }
//                 break;
//             default:
//                 Console.WriteLine("No se puede realizar la operacion");
//                 break;
//         }

//     Console.WriteLine("¿Desea realizar otra operación? (1: Si, 0: No)");
//     string confirmacion = Console.ReadLine();
//     int.TryParse(confirmacion, out opcion);
// } while (opcion == 1);

// //calculadora v2
// int opcion2;
// do
// {
//     Console.WriteLine("Ingrese un numero");
//      if (!float.TryParse(Console.ReadLine(), out float numero))
//                 {
//                     Console.WriteLine("Numero no valido, ingrese otro");
//                 }
//     Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
//     Console.WriteLine($"Cuadrado: {Math.Pow(numero, 2)}");
//     Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");


//     double radianes = numero * (Math.PI / 180);
//     Console.WriteLine($"Seno: {Math.Sin(radianes)}");
//     Console.WriteLine($"Coseno: {Math.Cos(radianes)}");


//     Console.WriteLine("Ingrese dos numeros enteros");
//     int.TryParse(Console.ReadLine(), out int numero1);
//     int.TryParse(Console.ReadLine(), out int numero2);
//     int max = Math.Max(numero1, numero2);
//     int min = Math.Min(numero1, numero2);
//     Console.WriteLine($"El máximo entre {numero1} y {numero2} es: {max}");
//     Console.WriteLine($"El mínimo entre {numero1} y {numero2} es: {min}");
    


//     Console.WriteLine("¿Desea realizar otra operación? (1: Si, 0: No)");
//     string confirmacion = Console.ReadLine();
//     int.TryParse(confirmacion, out opcion2);
// } while (opcion2 == 1);

//longitud
Console.WriteLine("Ingrese una cadena de texto: ");
string Cadena=Console.ReadLine();
int longitud=Cadena.Length;
Console.WriteLine($"El largo de la cadena es: {longitud}");

//concatenar
Console.WriteLine("Ingrese otra cadena de texto: ");
string Cadena2=Console.ReadLine();
string concatenada= Cadena+ Cadena2;
Console.WriteLine($"La cadena concatenada es: {concatenada}");

//extraer subcadena
Console.WriteLine("Ingrese una subcadena de texto: ");
string subcadena = Console.ReadLine();

int indiceSubcadena = concatenada.IndexOf(subcadena);//busca la posición de la subcadena dentro de concatenada tilizando IndexOf. Si la subcadena se encuentra dentro de la cadena concatenada, indiceSubcadena contendrá el índice de la primera ocurrencia de la subcadena dentro de la cadena concatenada. Si no se encuentra la subcadena, IndexOf devuelve -1.
if (indiceSubcadena != -1)
{
    int posicionFinSubcadena = indiceSubcadena + subcadena.Length;
    string subcadenaExtraida = concatenada.Substring(posicionFinSubcadena);
    Console.WriteLine($"La cadena sin la subcadena extraída es: {subcadenaExtraida}");
    }
    else
    {
    Console.WriteLine("La subcadena no se encontró dentro de la cadena ingresada.");
}
//calculadora to string
 int opcion3;
int resultado3;
int operacion3;
do
{
    Console.WriteLine("Seleccione la operación que desea realizar:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    operacion3 = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el primer número: ");
    int numero1 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el segundo número: ");
    int numero2 = int.Parse(Console.ReadLine());

    switch (operacion3)
    {
        case 1: 
            resultado3 = numero1 + numero2;
            Console.WriteLine("La suma de " + numero1.ToString() + " y " + numero2.ToString() + " es igual a: " + resultado3.ToString());
            break;
        case 2: 
            resultado3 = numero1 - numero2;
            Console.WriteLine("La resta de " + numero1.ToString() + " y " + numero2.ToString() + " es igual a: " + resultado3.ToString());
            break;
        case 3: 
            resultado3 = numero1 * numero2;
            Console.WriteLine("La multiplicación de " + numero1.ToString() + " y " + numero2.ToString() + " es igual a: " + resultado3.ToString());
            break;
        case 4: 
            if (numero2 != 0)
            {
                resultado3 = numero1 / numero2;
                Console.WriteLine("La división de " + numero1.ToString() + " y " + numero2.ToString() + " es igual a: " + resultado3.ToString());
            }
            else
            {
                Console.WriteLine("No se puede dividir por 0");
            }
            break;
        default:
            Console.WriteLine("No se puede realizar la operación");
            break;
    }

    Console.WriteLine("¿Desea realizar otra operación? (1: Sí, 0: No)");
    string confirmacion = Console.ReadLine();
    int.TryParse(confirmacion, out opcion3);
} while (opcion3 == 1);

Console.WriteLine("Ingrese una cadena de texto: ");
string cadena4 = Console.ReadLine();

Console.WriteLine("Los caracteres de la cadena son:");
foreach (char caracter in cadena4)
{
    Console.WriteLine(caracter);
}
/**************************buscar palabra**************************/
Console.WriteLine("Ingrese una palabra a buscar: ");
string palabraBuscada = Console.ReadLine();

if (cadena4.Contains(palabraBuscada))
{
    Console.WriteLine($"La palabra \"{palabraBuscada}\" se encontró en la cadena.");
}
else
{
    Console.WriteLine($"La palabra \"{palabraBuscada}\" no se encontró en la cadena.");
}
/****************************mayuscula a minuscula**************************************/
string mayusculas = cadena4.ToUpper();
string minusculas = cadena4.ToLower();

Console.WriteLine("La cadena en mayúsculas es: " + mayusculas);
Console.WriteLine("La cadena en minúsculas es: " + minusculas);
/**********************************separadores de cadena*****************************/
Console.WriteLine("Ingrese una cadena separada por caracteres:");
string cadenaSeparada = Console.ReadLine();

char[] separadores = { ',', ';', ' ' }; // Puedes modificar los caracteres de separación según tus necesidades
string[] partes = cadenaSeparada.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine("Los elementos separados son:");
foreach (string parte in partes)
{
    Console.WriteLine(parte);
}
/*******************************ECUACION*******************************************/
Console.WriteLine("Ingrese una ecuación simple (por ejemplo, \"582+2\"):");
string ecuacion = Console.ReadLine();
// Dividir la ecuación en operandos y operador
string[] partesEcuacion = ecuacion.Split(new char[] { '+', '-', '*', '/' });

int operando1 = int.Parse(partesEcuacion[0]);
int operando2 = int.Parse(partesEcuacion[1]);
char operador = ecuacion[partesEcuacion[0].Length];

// Realizar la operación según el operador
int resultadoEcuacion = 0;
switch (operador)
{
    case '+':
        resultadoEcuacion = operando1 + operando2;
        break;
    case '-':
        resultadoEcuacion = operando1 - operando2;
        break;
    case '*':
        resultadoEcuacion = operando1 * operando2;
        break;
    case '/':
        if (operando2 != 0)
        {
            resultadoEcuacion = operando1 / operando2;
        }
        else
        {
            Console.WriteLine("No se puede dividir por 0.");
            return;
        }
        break;
    default:
        Console.WriteLine("Operador no válido.");
        return;
}

Console.WriteLine($"El resultado de la ecuación \"{ecuacion}\" es: {resultadoEcuacion}");