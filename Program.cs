//calculadora version 2

float numeroA = 1;
float numeroB = 1;
string Num1 = "";
bool esUnNumeroValido = false;
while(!esUnNumeroValido) //controla si el numero es valido
{
        Console.WriteLine("Ingrese un numero:");
        Num1 = Console.ReadLine();
        Console.WriteLine(Num1);
        esUnNumeroValido = float.TryParse(Num1,out numeroA);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
        }
}

Console.WriteLine(numeroA);
Console.WriteLine("Valor absoluto de : "+numeroA +" es : "+Math.Abs(numeroA));
Console.WriteLine("El cuadrado de : "+numeroA +" es : "+Math.Pow(numeroA,2));

if (numeroA<0) // controla si es numero positivo para calcular la raiz cuadrada
{
    Console.WriteLine("No es puede calcular la raiz, el numero es negativo");
}
else
{
    Console.WriteLine("La raiz cuadrada de : "+numeroA +" es : "+Math.Sqrt(Math.Abs(numeroA)));
}

Console.WriteLine("El seno de : "+numeroA +" es : "+Math.Sin(numeroA));
Console.WriteLine("El coseno de : "+numeroA +" es : "+Math.Cos(numeroA));
Console.WriteLine("La parte entera de "+numeroA +" es : "+(int)numeroA);
esUnNumeroValido = false;
while(!esUnNumeroValido) //controla si el numero es valido
{
        Console.WriteLine("Ingrese otro numero:");
        Num1 = Console.ReadLine();
        esUnNumeroValido = float.TryParse(Num1,out numeroA);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
        }
}
esUnNumeroValido = false;
while(!esUnNumeroValido) //controla si el numero es valido
{
        Console.WriteLine("Ingrese otro numero:");
        Num1 = Console.ReadLine();
        esUnNumeroValido = float.TryParse(Num1,out numeroB);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
        }
}

if (numeroA<numeroB) // encuentra el numero maximo y minimo
{
    Console.WriteLine("El numero "+numeroA+" es el minimo");
    Console.WriteLine("El numero "+numeroB+" es el maximo");
}
else if (numeroA>numeroB)
{
    Console.WriteLine("El numero "+numeroA+" es el maximo");
    Console.WriteLine("El numero "+numeroB+" es el minimo");
}
else
{
    Console.WriteLine("Los numeros son iguales");
}