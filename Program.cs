// =======================================
// Calculadora Versión 2
// Programa que solicita números al usuario
// y realiza diferentes operaciones
// matemáticas utilizando la clase Math.
// También compara dos números para
// determinar cuál es el mayor y el menor.
// =======================================

// Variables para almacenar los números ingresados
float numeroA = 1;
float numeroB = 1;

// Variable auxiliar para leer datos desde el teclado
string Num1 = "";

// Variable que indica si la conversión del texto a número fue exitosa
bool esUnNumeroValido = false;

// ==========================================
// Lectura y validación del primer número
// ==========================================
while(!esUnNumeroValido)
{
        Console.WriteLine("Ingrese un numero:");
        Num1 = Console.ReadLine();

        // Convierte el texto a un número de tipo float
        esUnNumeroValido = float.TryParse(Num1,out numeroA);

        // Si la conversión falla, informa el error
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
        }
}

// ==========================================
// Operaciones matemáticas con la clase Math
// ==========================================

// Calcula el valor absoluto del número
Console.WriteLine("Valor absoluto de : "+numeroA +" es : "+Math.Abs(numeroA));

// Calcula el cuadrado del número
Console.WriteLine("El cuadrado de : "+numeroA +" es : "+Math.Pow(numeroA,2));

// Calcula la raíz cuadrada únicamente si el número es positivo
if (numeroA<0)
{
    Console.WriteLine("No es puede calcular la raiz, el numero es negativo");
}
else
{
    Console.WriteLine("La raiz cuadrada de : "+numeroA +" es : "+Math.Sqrt(Math.Abs(numeroA)));
}

// Calcula el seno del número
Console.WriteLine("El seno de : "+numeroA +" es : "+Math.Sin(numeroA));

// Calcula el coseno del número
Console.WriteLine("El coseno de : "+numeroA +" es : "+Math.Cos(numeroA));

// Obtiene únicamente la parte entera del número
Console.WriteLine("La parte entera de "+numeroA +" es : "+(int)numeroA);

// ==========================================
// Lectura del primer número para comparar
// ==========================================
esUnNumeroValido = false;
while(!esUnNumeroValido) 
{
        Console.WriteLine("Ingrese otro numero:");
        Num1 = Console.ReadLine();
        esUnNumeroValido = float.TryParse(Num1,out numeroA);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
        }
}

// ==========================================
// Lectura del segundo número para comparar
// ==========================================
esUnNumeroValido = false;
while(!esUnNumeroValido)
{
        Console.WriteLine("Ingrese otro numero:");
        Num1 = Console.ReadLine();
        esUnNumeroValido = float.TryParse(Num1,out numeroB);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es un numero valido");
        }
}


// ==========================================
// Comparación entre ambos números
// ==========================================

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
     // Ambos números son iguales
    Console.WriteLine("Los numeros son iguales");
}