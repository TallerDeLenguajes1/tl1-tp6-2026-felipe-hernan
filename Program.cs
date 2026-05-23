Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de B: "+b);
int i = 0;
int inver = 0;
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
