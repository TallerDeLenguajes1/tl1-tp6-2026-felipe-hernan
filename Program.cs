Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de B: "+b);
int i = 0;
int inver = 0;
Console.WriteLine("Ingrese un numero: ");
string entrada = Console.ReadLine();
if (int.TryParse(entrada,out i))
{
    while (i>0) //invierte el numero digito a digito
    {
        inver =inver*10 +i%10; 
        i/=10;
    }
}
if (inver>0)
{
    Console.WriteLine("Numero invertido "+inver);
}
else
{
    Console.WriteLine("No es posible invertir");
} 

//ejercicio 4
Console.WriteLine("ingrese un texto");
string cadena1 = Console.ReadLine();
Console.WriteLine($@"La longitud de la cadena de texto es {cadena1.Length}");
Console.WriteLine("ingrese otro texto");
string cadena2 = Console.ReadLine();
Console.WriteLine($@"Dos cadena {cadena1} {cadena2}");
Console.WriteLine($@"parte de una cadena {cadena1.Substring(2,2)}");

foreach (char item in cadena1)
{
    Console.WriteLine(item);
}
Console.WriteLine("Cadena en minuscula "+cadena1.ToLower());
Console.WriteLine("Cadena en mayuscula "+cadena1.ToUpper());
Console.WriteLine("ingrese un texto separado por -");
cadena1 = Console.ReadLine();
string[] nuevaCadena = cadena1.Split('-');
foreach (var item in nuevaCadena) //escribe las subcadenas
{
    Console.WriteLine(item);
}
decimal numeroA = 0;
decimal numeroB = 0;
bool esUnNumeroValido;
char operacion =' ';
string aux = " ";

Console.WriteLine("ingrese una operacion a realizar");
cadena1 = Console.ReadLine();
nuevaCadena = cadena1.Split('-','*','/','+');//separa las cadenas por algun operador

foreach (char operador in cadena1) //busca la operacion a realizar
{
    if (operador == '-' || operador == '*' ||operador == '/' ||operador == '+' )
    {
        operacion = operador;
        break;
    }
}

aux =  nuevaCadena[0];
esUnNumeroValido = decimal.TryParse(aux,out numeroA);
aux =  nuevaCadena[1];
esUnNumeroValido = decimal.TryParse(aux,out numeroB);

switch (operacion) //realiza las operaciones
{
    case '+':
        Console.WriteLine("La suma es : "+(numeroA+numeroB));
        break;
    case '-':
        Console.WriteLine("La resta es : "+(numeroA-numeroB));
        break;
    case '*':
        Console.WriteLine("La multiplicacion es : "+(numeroA*numeroB));
        break;
    case '/':
        Console.WriteLine("La divicion es : "+(numeroA/numeroB));
        break;
}



