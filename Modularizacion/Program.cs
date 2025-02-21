using System.ComponentModel.Design;
using System.Linq.Expressions;
int opcion = 0;

////TITULOS, MENU Y OPCIONES DEL 1 AL 9
while (opcion != 11)
{
    Console.WriteLine("\nProyecto de Modularizacion 2025");
    Console.WriteLine("Selecciona una opcion:");
    Console.WriteLine("\n- 1 Calculadora Basica");
    Console.WriteLine("- 2 Validacion de Contraseña");
    Console.WriteLine("- 3 Numeros Primos");
    Console.WriteLine("- 4 Suma de Numeros Pares");
    Console.WriteLine("- 5 Conversion de Temperatura");
    Console.WriteLine("- 6 Contador de Vocales");
    Console.WriteLine("- 7 Calculo de Factorial");
    Console.WriteLine("- 8 Juego de Adivinanza");
    Console.WriteLine("- 9 Paso por referencia");
    Console.WriteLine("- 10 Tabla de Multiplicar");
    Console.WriteLine("- 11 Salir\n");

    //MANERA POR LA CUAL PODEMOS ESCRIBIR, O SIMPLEMENTE, UNA ENTRADA DE TEXTO
    string input = Console.ReadLine();

    //SI OCURRE DE COLOCAR ALGO DIFERENTE EN EL MENU
    if (!int.TryParse(input, out opcion))
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido");
        continue;
    }

    Console.Clear();
    //SWITCH CON LAS OPCIONES DEL 1 AL 9 DEL MENU 
    switch (opcion)
    {
        //OPCION 1 CALCULADORA SIMPLE
        case 1:
            double num1;
            double num2;
            double suma, resta, multiplicacion, division;
            Console.WriteLine("\nCalculadora Basica");

            Console.WriteLine("Por favor, elige la operacion que deseas realizar:");
            bool elegir_opcion = true;
            //ELEGIR OPCIONES DE OPERACIONES DE CALCULADORA SIMPLE
            while (elegir_opcion)
            {
                Console.WriteLine("- 1 Realizar Suma");
                Console.WriteLine("- 2 Realizar Resta");
                Console.WriteLine("- 3 Realizar Multiplicacion");
                Console.WriteLine("- 4 Realizar Division");
                Console.WriteLine("");

                int operacion;
                //SI OCURRE DE COLOCAR ALGO DIFERENTE A LAS OPCIONES EN OPERACIONES DE CALCULADORA SIMPLE
                if (int.TryParse(Console.ReadLine(), out operacion))
                {
                    if (operacion < 1 || operacion > 4)
                    {
                        Console.WriteLine("\nOpción no válida, Presiona Enter para ir al menu principal");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                    //INGRESO PRIMER NUMERO SUMA
                    Console.Clear();
                    Console.WriteLine("Ingrese el primer numero:\n");
                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido para el primer número:\n");
                    }

                    //INGRESO SEGUNDO NUMERO SUMA
                    Console.WriteLine("\nIngrese el segundo numero:\n");
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido para el segundo número:\n");
                    }

                    switch (operacion)
                    {
                        //OPERACION DE LA SUMA
                        case 1:
                            suma = num1 + num2;
                            Console.WriteLine($"\nEl resultado es: {suma}");
                            elegir_opcion = false;
                            break;
                        //OPERACION DE LA RESTA
                        case 2:
                            resta = num1 - num2;
                            Console.WriteLine($"\nEl resultado es: {resta}");
                            elegir_opcion = false;
                            break;
                        //OPERACION DE LA MULTIPLICACION
                        case 3:
                            multiplicacion = num1 * num2;
                            Console.WriteLine($"\nEl resultado es: {multiplicacion}");
                            elegir_opcion = false;
                            break;
                        //OPERACION DE LA DIVISION
                        case 4:
                            if (num2 != 0)
                            {
                                division = num1 / num2;
                                Console.WriteLine($"El resultado es {division}");
                            }
                            else
                            {
                                Console.WriteLine("No se puede dividir por cero, intente otra division");
                            }
                            elegir_opcion = false;
                            break;
                        default:
                            Console.WriteLine("Opcion no valida, intente nuevamente");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido para la operación:");
                }
            }
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;

        //OPCION 2 VALIDACION DE CONTRASEÑAS
        case 2:
            int contrasena;
            const int contrasenacorrecta = 1234;
            do
            {
                Console.WriteLine("\nValidacion de Contraseña");
                Console.WriteLine("Por favor escribe una contrasena:\n");
                string contrasenaInput = Console.ReadLine();
                if (int.TryParse(contrasenaInput, out contrasena) && contrasena == contrasenacorrecta)
                {
                    Console.WriteLine("\nContrasena Correcta");
                    break;
                }
                else
                {
                    Console.WriteLine("\nContrasena incorrecta, intente de nuevo");
                }
            } while (true);

            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;

        //OPCION 3 NUMEROS PRIMOS
        case 3:
            Console.WriteLine("\nNumeros Primos");
            Console.WriteLine("Digite un numero:\n");
            int numero;
            //SI SE INGRESA UN DATO QUE NO ES VALIDO
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("No es una entrada valida, por favor ingrese un numero entero valido");
            }

            if (EsPrimo(numero))
            {
                Console.WriteLine($"\nEl numero {numero} es primo");
            }
            else
            {
                Console.WriteLine($"\nEl numero {numero} no es primo");
            }

            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;

        //OPCION 4 SUMA DE NUMEROS PARES
        case 4:
            int numeroIngresado;
            int sumaPares = 0;
            do
            {
                Console.WriteLine("Ingrese un numero (0 para terminar)");
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.WriteLine("Entrada no valida, ingrese un numero entero valido");
                }

                if (numeroIngresado != 0) ;
                {
                    sumaPares += numeroIngresado;
                }
            } while (numeroIngresado != 0);
            Console.WriteLine($"La suma de todos los numeros pares ingresados es de: {sumaPares}");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();

            break;

            //OPCION 5 CONVERSION DE TEMPERATURA
        case 5:
            Console.WriteLine("Conversion de Temperatura");
            Console.WriteLine("Eliga la opcion deseada");
            Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir de Fahrenheit a Celsius");

            int opcionConversion;
            if (int.TryParse(Console.ReadLine(), out opcionConversion))
            {
                double temperatura;
                switch (opcionConversion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la temperatura en grados Celsius:");
                        while (!double.TryParse(Console.ReadLine(), out temperatura))
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido para la temperatura en grados Celsius:");
                        }
                        double fahrenheit = CelsiusAFahrenheit(temperatura);
                        Console.WriteLine($"La temperatura en grados Fahrenheit es: {fahrenheit}");
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
                        while (!double.TryParse(Console.ReadLine(), out temperatura))
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido para la temperatura en grados Fahrenheit:");
                        }
                        double celsius = FahrenheitACelsius(temperatura);
                        Console.WriteLine($"La temperatura en grados Celsius es: {celsius}");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Regresando al menú principal...");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Regresando al menú principal...");
            }

            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;

            //OPCION 6 CONTADOR DE VOCALES
        case 6:
            Console.WriteLine("Contador de vocales");
            Console.WriteLine("Por favor ingresa una frase:");
            string frase = Console.ReadLine();
            int numeroVocales = ContarVocales(frase);
            Console.WriteLine($"La frase contiene {numeroVocales} vocales.");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;

            //OPCION 7 CALCULO DE FACTORIAL
        case 7:
            Console.WriteLine("Calculo de factorial");
            Console.WriteLine("Por favor ingresa un numero entero:");
            int numeroFactorial;
            while (!int.TryParse(Console.ReadLine(), out numeroFactorial))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero válido:");
            }
            long factorial = 1;
            for (int i = 1; i <= numeroFactorial; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"El factorial de {numeroFactorial} es: {factorial}");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;

            //OPCION 8 JUEGO DE ADIVINANZA
        case 8:
            Console.WriteLine("Juego de Adivinanza");
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);
            int intentos = 0;
            int numeroUsuario;
            do
            {
                Console.WriteLine("Adivina el número (1-100):");
                while (!int.TryParse(Console.ReadLine(), out numeroUsuario))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero válido:");
                }
                if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El número es menor.");
                }
                else if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El número es mayor.");
                }
                intentos++;
            } while (numeroUsuario != numeroAleatorio);
            Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;

            //OPCION 9 PASO POR REFERENCIA
        case 9:
            Console.WriteLine("Paso por referencia");
            int numeroReferencia = 10;
            Console.WriteLine($"Valor antes de llamar al método: {numeroReferencia}");
            PasoPorReferencia(ref numeroReferencia);
            Console.WriteLine($"Valor después de llamar al método: {numeroReferencia}");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;

            //OPCION 10 TABLA DE MULTIPLICAR
        case 10:
            Console.WriteLine("Tabla de multiplicar");
            Console.WriteLine("Por favor ingresa un número entero:");
            int numeroTabla;
            while (!int.TryParse(Console.ReadLine(), out numeroTabla))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero válido:");
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numeroTabla} x {i} = {numeroTabla * i}");
            }
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;

            //SALIDA DEL PROGRAMA
        case 11:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opcion no valida");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}
    //DECLARACIONES
    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
    static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
    static int ContarVocales(string texto)
    {
        int contador = 0;
        string vocales = "aeiouAEIOU";
        foreach (char c in texto)
        {
            if (vocales.Contains(c))
            {
                contador++;
            }
        }
        return contador;
    }
    static void PasoPorReferencia(ref int numero)
    {
        numero += 10;
    }


