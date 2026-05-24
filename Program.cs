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
Console.WriteLine($@"parte de una cadena {cadena1.Substring(3,4)}");



