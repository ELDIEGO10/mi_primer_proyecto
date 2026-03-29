using System;
using System.ComponentModel.Design;

namespace Aca_Fundamentos_De_Programacion
    {
    class Program
    {
        static void Main(string[] args)
        {
            int opciones = -1;
            do
            {
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("1. El numero mayor entre 3 numeros");
                Console.WriteLine("2. Determinar si el numero es positvo o negativo");
                Console.WriteLine("3. Calcular IMC (Indice de masa muscular)");
                Console.WriteLine("4. Calcular factorial de un numero");
                Console.WriteLine("5. Tabla de multiplicar de el 1 hasta el 10");
                Console.WriteLine("0. Salir");
                Console.WriteLine("\n Elija una opcion:");
                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                        case 1:
                            numPositivoNegativo();
                            break;
                        case 2:
                            numPositivo();
                            break;
                        case 3:
                            calculoDeImc();
                            break;
                        case 4:
                            calculoFactorial();
                            break;
                        case 5:
                            tablaMultiplicar();
                            break;
                        case 0:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }// Agrega una línea en blanco para mejorar la legibilidad

                if (opciones != 0)
                {
                    Console.WriteLine("\n Presione otra tecla para regresar al menu principal...");
                    Console.ReadKey();
                }
            } while (opciones != 0);

            // METODOS PARA LAS OPCIONES

            // Opcion 1

            static void numPositivoNegativo()
            {
                Console.WriteLine("Escriba 3 numeros para saber cual es el mayor.");
                // Aquí puedes agregar el código para calcular el número mayor entre 3 números
                int.TryParse(Console.ReadLine(), out int a);
                int.TryParse(Console.ReadLine(), out int b);
                int.TryParse(Console.ReadLine(), out int c);

                if (a > b && a > c && b < c) Console.WriteLine($"El numero mayor es: {a} y el numero menor es: {b}");
                else if (a > b && a > c && c < b) Console.WriteLine($"El numero mayor es: {a} y el numero menor es: {c}");
                else if (b > a && b > c && a < c) Console.WriteLine($"El numero mayor es: {b} y el numero menor es: {a}");
                else if (b > a && b > c && c < a) Console.WriteLine($"El numero mayor es: {b} y el numero menor es: {c}");
                else if (c > a && c > b && a < b) Console.WriteLine($"El numero mayor es: {c} y el numero menor es: {a}");
                else if (c > a && c > b && b < a) Console.WriteLine($"El numero mayor es: {c} y el numero menor es: {b}");
                else Console.WriteLine("Los numeros son iguales");

                Console.Clear();
            }

            // Opcion 2

            static void numPositivo()
            {
                Console.WriteLine("Escriba un numero para saber si es positivo o negativo: ");
                int.TryParse(Console.ReadLine(), out int numero);
                if (numero > 0) Console.WriteLine($"El numero {numero} es positivo");
                else if (numero < 0) Console.WriteLine($"El numero {numero} es negativo");
                else Console.WriteLine("El numero es cero");

                Console.Clear();
            }

            // Opcion 3

            static void calculoDeImc()
            {
                Console.WriteLine("Escriba su peso en kg: ");
                double.TryParse(Console.ReadLine(), out double peso);
                Console.WriteLine("Escriba su altura en CM: ");
                double.TryParse(Console.ReadLine(), out double altura);
                double imc = peso / Math.Pow((altura / 100), 2);
                if (peso > 0 && altura > 0)
                {
                    Console.WriteLine($"Su IMC es de el: {imc:F2}%");
                    if (imc < 18.5) Console.WriteLine("Usted esta bajo de peso");
                    else if (imc >= 18.5 && imc < 25) Console.WriteLine("Usted tiene un peso normal");
                    else if (imc >= 25 && imc < 30) Console.WriteLine("Usted tiene sobrepeso");
                    else if (imc >= 30 && imc < 35) Console.WriteLine("Usted tiene obesidad grado 1");
                    else if (imc >= 35 && imc < 40) Console.WriteLine("Usted tiene obesidad grado 2");
                    else if (imc >= 40) Console.WriteLine("Usted tiene obesidad grado 3");
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número positivo para peso y altura.");
                }

                Console.Clear();
            }

            // Opcion 4

            static void calculoFactorial()
            {
                int factorial = 1;

                Console.Write("Ingrese un número: ");
                int.TryParse(Console.ReadLine(), out int num);

                Console.Write("Procedimiento: ");

                for (int i = num; i >= 1; i--)
                {
                    factorial *= i;

                    Console.Write(i);

                    if (i > 1)
                    {
                        Console.Write(" x ");
                    }
                }

                Console.WriteLine(" = " + factorial);

                Console.Clear();
            }

            // Opcion 5 

            static void tablaMultiplicar()
            {
                Console.WriteLine("Escriba un numero hasta el 10 para mostrar su tabla de multiplicar: ");
                int.TryParse(Console.ReadLine(), out int num);
                int i = 0;
                while (i <= 10) 
                {
                    Console.WriteLine($"{num} X {i} = {num * i} ");
                    i++;
                }

                Console.Clear();

            }
            
        }
    }
}