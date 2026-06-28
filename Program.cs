// =======================================
// Calculadora Versión 1
// Programa que permite realizar operaciones
// matemáticas básicas y utilizar funciones
// de la clase Math.
// =======================================

// Variables para controlar el menú y la repetición del programa
int opcion1 = 0;
int opcion2 = 0;

// Variables que almacenan los números ingresados por el usuario
decimal numeroA = 1;
decimal numeroB = 1;

// Variable donde se almacena el resultado de la operación
decimal resultado;

// Variable auxiliar para leer datos desde teclado
string Num1 = "";

// Variable que indica si la conversión de texto a número fue correcta
bool esUnNumeroValido = false;

// =============================
// Menú principal de la calculadora
// =============================
do
{
    // Muestra las opciones disponibles
    Console.WriteLine("Ingrese una opcion:");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    
    // Valida que la opción ingresada sea un número entero
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
    // Verifica que la opción esté dentro del rango permitido
    if (opcion1<1 || opcion1>4)
    {
        Console.WriteLine("Opcion no valida ");
        esUnNumeroValido = false;
    }



} while (opcion1 == 0 || opcion1<1 || opcion1>4);


// =======================================
// Bucle principal de la calculadora
// Se repite mientras el usuario lo desee
// =======================================
do
{

    // ----------------------------
    // Lectura del primer número
    // ----------------------------
    esUnNumeroValido = false;

    while(!esUnNumeroValido) 
    {
        Console.WriteLine("Ingrese el primer numero: ");
        Num1 = Console.ReadLine();
        esUnNumeroValido = decimal.TryParse(Num1,out numeroA);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
                
        }
    }

    // ----------------------------
    // Lectura del segundo número
    // ----------------------------
    esUnNumeroValido = false;
    while(!esUnNumeroValido || numeroB == 0)
    {
        Console.WriteLine("Ingrese el segundo numero: ");
        Num1 = Console.ReadLine();
        esUnNumeroValido = decimal.TryParse(Num1,out numeroB);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
                
        }

        // Evita que el usuario ingrese cero
        if (numeroB == 0) 
        {
            Console.WriteLine("No puede ser 0");
        }
    }
    

    // ==================================
    // Realiza la operación seleccionada
    // ==================================
    switch (opcion1)
    {
        case 1:
            resultado = numeroA+numeroB;
            Console.WriteLine("La suma de "+numeroA.ToString()+" y "+numeroB.ToString() + " es igual a: "+resultado.ToString());
            break;
        case 2:
            resultado = numeroA-numeroB;
            Console.WriteLine("La resta de "+numeroA.ToString()+" y "+numeroB.ToString() + " es igual a: "+resultado.ToString());
            break;
        case 3:
            resultado = numeroA*numeroB;
            Console.WriteLine("La multiplicacion de "+numeroA.ToString() +" y " + numeroB.ToString()+ " es igual a: "+ resultado.ToString());
            break;
        case 4:
            resultado = numeroA/numeroB;
            Console.WriteLine("La divicion de "+numeroA.ToString()+" y "+numeroB.ToString()+" es igual a: "+resultado.ToString());
            break;
    }

    // =====================================
    // Pregunta si desea realizar otro cálculo
    // =====================================
    esUnNumeroValido = false;

    while(!esUnNumeroValido)
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

// ==========================================
// Funciones matemáticas de la clase Math
// ==========================================

// Solicita un número válido
esUnNumeroValido = false;
while(!esUnNumeroValido)
{
        Console.WriteLine("Ingrese un numero:");
        Num1 = Console.ReadLine();
        Console.WriteLine(Num1);
        esUnNumeroValido = decimal.TryParse(Num1,out numeroA);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
        }
}

// Calcula el valor absoluto
Console.WriteLine("Valor absoluto de : "+numeroA +" es : "+Math.Abs(numeroA));

// Calcula el cuadrado
Console.WriteLine("El cuadrado de : "+numeroA +" es : "+Math.Pow((float)numeroA,2));

// Calcula la raíz cuadrada únicamente si el número es positivo
if (numeroA<0)
{
    Console.WriteLine("No es puede calcular la raiz, el numero es negativo");
}
else
{
    Console.WriteLine("La raiz cuadrada de : "+numeroA +" es : "+Math.Sqrt(Math.Abs((float)numeroA)));
}

// Calcula el seno del número
Console.WriteLine("El seno de : "+numeroA +" es : "+Math.Sin((float)numeroA));

// Calcula el coseno del número
Console.WriteLine("El coseno de : "+numeroA +" es : "+Math.Cos((float)numeroA));

// Obtiene únicamente la parte entera del número
Console.WriteLine("La parte entera de "+numeroA +" es : "+(int)numeroA);


// ==========================================
// Comparación entre dos números
// ==========================================


// Solicita el primer número
esUnNumeroValido = false;
while(!esUnNumeroValido)
{
    Console.WriteLine("Ingrese otro numero:");
    Num1 = Console.ReadLine();
    esUnNumeroValido = decimal.TryParse(Num1,out numeroA);
    if (!esUnNumeroValido)
    {
        Console.WriteLine(Num1 +" no es un numero valido");
    }
}

// Solicita el segundo número
esUnNumeroValido = false;
while(!esUnNumeroValido)
{
    Console.WriteLine("Ingrese otro numero:");
    Num1 = Console.ReadLine();
    esUnNumeroValido = decimal.TryParse(Num1,out numeroB);
    if (!esUnNumeroValido)
    {
        Console.WriteLine(Num1 +" no es un numero valido");
    }
}


// Determina cuál es el mayor y cuál es el menor
if (numeroA<numeroB)
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
