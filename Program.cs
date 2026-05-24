//calculadora version 1
int opcion1 = 0;
int opcion2 = 0;
decimal numeroA = 1;
decimal numeroB = 1;
string Num1 = "";
bool esUnNumeroValido = false;

do
{
    //menu
    Console.WriteLine("Ingrese una opcion:");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    
    while(!esUnNumeroValido)
    {
        Num1 = Console.ReadLine();
        esUnNumeroValido = int.TryParse(Num1,out opcion1);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
            Console.WriteLine("Ingrese una opcion:");
        }
    }
    if (opcion1<1 || opcion1>4) //comprueba que es un un numero y que sea una opcion valida
    {
        Console.WriteLine("Opcion no valida ");
        esUnNumeroValido = false;
    }

} while (opcion1 == 0 || opcion1<1 || opcion1>4);

do
{
    esUnNumeroValido = false;
    while(!esUnNumeroValido) //controla si el numero A es valido
    {
        Console.WriteLine("Ingrese el primer numero: ");
        Num1 = Console.ReadLine();
        esUnNumeroValido = decimal.TryParse(Num1,out numeroA);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
        }
    }
    esUnNumeroValido = false;
    while(!esUnNumeroValido || numeroB == 0) //controla si el numero B es valido
    {
        Console.WriteLine("Ingrese el segundo numero: ");
        Num1 = Console.ReadLine();
        esUnNumeroValido = decimal.TryParse(Num1,out numeroB);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
            
        }
        if (numeroB == 0) //controla si el numero B es 0
        {
            Console.WriteLine("No puede ser 0");
        }
    }

    switch (opcion1) //realiza las operaciones
    {
        case 1:

            Console.WriteLine("La suma es : "+(numeroA+numeroB));
            break;
        case 2:
            Console.WriteLine("La resta es : "+(numeroA-numeroB));
            break;
        case 3:
            Console.WriteLine("La multiplicacion es : "+(numeroA*numeroB));
            break;
        case 4:
            Console.WriteLine("La divicion es : "+(numeroA/numeroB));
            break;
    }
    esUnNumeroValido = false;
    while(!esUnNumeroValido)//controla si el numero A es valido
    {
        Console.WriteLine("Desea realizar otro calculo? si = 1, no = 0");
        Num1 = Console.ReadLine();
        esUnNumeroValido = int.TryParse(Num1,out opcion2);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
        }
    }

} while (opcion2 == 1);