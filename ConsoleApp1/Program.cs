using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            initApp();
        }

        static void reloadApp()
        {
            Console.WriteLine("\n¿Desea realizar otra operación?\n1 - Sí\n2 - No");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                initApp();
            }
            else
            {
                Console.WriteLine("Gracias por usar la calculadora.");
            }
        }

        static void initApp()
        {
            Console.WriteLine("\nIngrese una opción:");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Área de Triángulo");
            Console.WriteLine("6 - Área de Cuadrado");
            Console.WriteLine("7 - Área de Círculo");
            Console.WriteLine("8 - Salir");

            int op = Convert.ToInt32(Console.ReadLine());

            decimal num1 = 0, num2 = 0;
            double numCircle = 0;

            if (op >= 1 && op <= 6)
            {
                Console.WriteLine("Por favor ingrese el primer número:");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Por favor ingrese el segundo número:");
                num2 = Convert.ToDecimal(Console.ReadLine());
            }
            else if (op == 7)
            {
                Console.WriteLine("Por favor ingrese el radio del círculo:");
                numCircle = Convert.ToDouble(Console.ReadLine());
            }

            decimal result;
            switch (op)
            {
                case 1:
                    result = sumar(num1, num2);
                    Console.WriteLine($"Resultado de la suma: {result}");
                    reloadApp();
                    break;
                case 2:
                    result = restar(num1, num2);
                    Console.WriteLine($"Resultado de la resta: {result}");
                    reloadApp();
                    break;
                case 3:
                    result = multiplicar(num1, num2);
                    Console.WriteLine($"Resultado de la multiplicación: {result}");
                    reloadApp();
                    break;
                case 4:
                    result = dividir(num1, num2);
                    Console.WriteLine($"Resultado de la división: {result}");
                    reloadApp();
                    break;
                case 5:
                    result = triangulo(num1, num2);
                    Console.WriteLine($"Área del triángulo: {result}");
                    reloadApp();
                    break;
                case 6:
                    result = cuadrado(num1, num2);
                    Console.WriteLine($"Área del cuadrado (rectángulo): {result}");
                    reloadApp();
                    break;
                case 7:
                    double area = circulo(numCircle);
                    Console.WriteLine($"Área del círculo: {area}");
                    reloadApp();
                    break;
                case 8:
                    Console.WriteLine("Gracias por usar la calculadora.");
                    break;
                default:
                    Console.WriteLine("Por favor seleccione una opción válida.");
                    reloadApp();
                    break;
            }
        }

        static decimal sumar(decimal a, decimal b) => a + b;

        static decimal restar(decimal a, decimal b) => a - b;

        static decimal multiplicar(decimal a, decimal b) => a * b;

        static decimal dividir(decimal a, decimal b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir entre 0.");
                return 0;
            }
            return a / b;
        }

        static decimal triangulo(decimal baseT, decimal altura)
        {
            return 0.5m * baseT * altura;
        }

        static decimal cuadrado(decimal baseC, decimal altura)
        {
            return baseC * altura;
        }

        static double circulo(double radio)
        {
            const double pi = 3.14159;
            return pi * radio * radio;
        }
    }
}
