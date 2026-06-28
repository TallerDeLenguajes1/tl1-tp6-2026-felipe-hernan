// Declaración de variables enteras
int a;
int b;

// Asignación de valores
a = 10;
b = a;

// Muestra el contenido de las variables
Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de B: "+b);

// Variables para invertir un número
int i = 0;
int inver = 0;

// Solicita un número al usuario
Console.WriteLine("Ingrese un numero: ");
string entrada = Console.ReadLine();

// Verifica que la entrada sea un número entero
if (int.TryParse(entrada,out i))
{
    // Invierte el número dígito por dígito
    while (i>0)
    {
        inver =inver*10 +i%10;   // Agrega el último dígito al número invertido
        i/=10;                  // Elimina el último dígito del número original
    }
}
// Muestra el número invertido si fue posible
if (inver>0)
{
    Console.WriteLine("Numero invertido "+inver);
}
else
{
    Console.WriteLine("No es posible invertir");
} 

// =======================
// Ejercicio 4 - Cadenas
// =======================

// Solicita una cadena de texto
Console.WriteLine("ingrese un texto");
string cadena1 = Console.ReadLine();

// Muestra la longitud de la cadena
Console.WriteLine($@"La longitud de la cadena de texto es {cadena1.Length}");

// Solicita una segunda cadena
Console.WriteLine("ingrese otro texto");
string cadena2 = Console.ReadLine();

// Muestra ambas cadenas
Console.WriteLine($@"Dos cadena {cadena1} {cadena2}");

// Muestra una subcadena desde la posición 2 con longitud 2
Console.WriteLine($@"parte de una cadena {cadena1.Substring(2,2)}");


// Recorre la cadena carácter por carácter
foreach (char item in cadena1)
{
    Console.WriteLine(item);
}

// Convierte la cadena a minúsculas
Console.WriteLine("Cadena en minuscula "+cadena1.ToLower());

// Convierte la cadena a mayúsculas
Console.WriteLine("Cadena en mayuscula "+cadena1.ToUpper());

// Solicita una cadena separada por guiones
Console.WriteLine("ingrese un texto separado por -");
cadena1 = Console.ReadLine();

// Divide la cadena utilizando el carácter '-'
string[] nuevaCadena = cadena1.Split('-');

// Muestra cada subcadena obtenida
foreach (var item in nuevaCadena)
{
    Console.WriteLine(item);
}


// =======================
// Calculadora básica
// =======================

// Variables para almacenar los operandos y el resultado
decimal numeroA = 0;
decimal numeroB = 0;
decimal resultado = 0;

// Variable para verificar si la conversión fue correcta
bool esUnNumeroValido;

// Variable que almacenará el operador
char operacion =' ';

// Variable auxiliar
string aux = " ";

// Solicita una operación matemática al usuario
// Ejemplo: 10+5 o 8/2
Console.WriteLine("ingrese una operacion a realizar");
cadena1 = Console.ReadLine();

// Separa los números utilizando los operadores como delimitadores
nuevaCadena = cadena1.Split('-','*','/','+');

// Busca cuál fue el operador utilizado
foreach (char operador in cadena1)
{
    if (operador == '-' || operador == '*' ||operador == '/' ||operador == '+' )
    {
        operacion = operador;
        break;
    }
}

// Convierte el primer operando
aux =  nuevaCadena[0];
esUnNumeroValido = decimal.TryParse(aux,out numeroA);

// Convierte el segundo operando
aux =  nuevaCadena[1];
esUnNumeroValido = decimal.TryParse(aux,out numeroB);

// Ejecuta la operación correspondiente
switch (operacion) //realiza las operaciones
{
    case '+':
        resultado = numeroA+numeroB;
        Console.WriteLine("La suma de "+numeroA.ToString()+" y "+numeroB.ToString() + " es igual a: "+resultado.ToString());
        break;
    case '-':
        resultado = numeroA-numeroB;
        Console.WriteLine("La resta de "+numeroA.ToString() +" y " + numeroB.ToString()+ " es igual a: "+ resultado.ToString());
        break;
    case '*':
        resultado = numeroA*numeroB;
        Console.WriteLine("La multiplicacion de "+numeroA.ToString() +" y " + numeroB.ToString()+ " es igual a: "+ resultado.ToString());
        break;
    case '/':
        resultado = numeroA/numeroB;
        Console.WriteLine("La divicion de "+numeroA.ToString()+" y "+numeroB.ToString()+" es igual a: "+resultado.ToString());
        break;
}



