# C# String Details

## Tipo de `string`
En C#, `string` es un **tipo por referencia**. Aunque el contenido del `string` es inmutable (es decir, no puede cambiar después de ser creado), la variable que contiene el `string` es una referencia a un objeto en el heap.

## Secuencias de escape en `string`
En C#, las cadenas de texto (`string`) pueden incluir varias secuencias de escape, que representan caracteres especiales. Algunas de las más comunes son:

- `\\` : Backslash
- `\'` : Comilla simple
- `\"` : Comilla doble
- `\n` : Nueva línea
- `\r` : Retorno de carro
- `\t` : Tabulador horizontal
- `\b` : Retroceso
- `\f` : Avance de página
- `\v` : Tabulador vertical
- `\0` : Carácter nulo

También puedes usar secuencias de escape para especificar caracteres en Unicode o en valores hexadecimales:
- `\uFFFF` : Representa un carácter Unicode (donde `FFFF` es un valor hexadecimal de cuatro dígitos).
- `\xFF` : Representa un carácter con un valor hexadecimal (donde `FF` puede ser uno o más dígitos hexadecimales).

## Uso de `@` y `$` antes de una cadena de texto

### Carácter `@`: Cadenas textuales (Verbatim String Literals)
Cuando pones un `@` antes de una cadena de texto, defines una cadena textual que no procesa las secuencias de escape. Esto significa que cada carácter dentro de la cadena es tomado literalmente, incluyendo los caracteres de nueva línea. La única excepción es la doble comilla `"` que debe duplicarse para representarse dentro de la cadena.

```csharp
string filePath = @"C:\Users\Username\Documents\File.txt";
string multiLine = @"This is a
multi-line
string.";
```

### Carácter `$`: Interpolación de cadenas (String Interpolation)
Cuando pones un `$` antes de una cadena de texto, defines una cadena interpolada. Esto permite que las expresiones dentro de llaves `{}` dentro de la cadena se evalúen y su resultado se incluya en la cadena resultante.

```csharp
int age = 30;
string name = "John";
string greeting = $"Hello, my name is {name} and I am {age} years old.";
```
### Combinación de `@` y `$`
Puedes combinar ambos caracteres para crear una cadena textual interpolada. Esto te permite usar tanto la interpolación de cadenas como la literalidad de caracteres.
```csharp
string directory = "C:\\Users\\Username\\Documents";
string file = "File.txt";
string filePath = @$"{directory}\{file}";
```


