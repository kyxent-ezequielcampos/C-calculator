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
            System.Console.WriteLine("Desea realizar otra operación?\n1-si\n2-no");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                initApp();
            }
        }

        static void initApp()
        {
            decimal result;
            System.Console.WriteLine("ingrese una opción\n1-sumar\n2-restar\n3-multiplicar\n4-dividir\n5-salir\n");
            int op = Convert.ToInt32(Console.ReadLine());
            
            System.Console.WriteLine("Porfavor ingrese el primer numero");
            decimal num1 = Convert.ToInt32(Console.ReadLine());
            
            System.Console.WriteLine("Porfavor ingrese el segundo numero");
            decimal num2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    result = sumar(num1, num2);
                    System.Console.WriteLine($"su suma es : {result}");
                    reloadApp();
                    break;
                case 2:
                    result = restar(num1, num2);
                    System.Console.WriteLine($"su restar es : {result}");
                    reloadApp();
                    break;
                case 3:
                    result = multiplicar(num1, num2);
                    System.Console.WriteLine($"su multiplicar es : {result}");
                    reloadApp();
                    break;
                case 4:
                    result = dividir(num1, num2);
                    System.Console.WriteLine($"su dividir es : {result}");
                    reloadApp();
                    break;
                case 5:
                    System.Console.WriteLine("Gracias por usar la calculadora");
                    break;
                default:
                    System.Console.WriteLine("Porfavor seleccione una opcion valida");
                    break;
                
            }
            




        }

        static decimal sumar(decimal a, decimal b)
        {
            return a + b;
        }

        static decimal restar(decimal a, decimal b)
        {
            return a - b;
        }

        static decimal multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        static decimal dividir(decimal a, decimal b)
        {
            if (a == 0 || b == 0)
            {
                System.Console.WriteLine("No puedes dividir entre 0");
                return 0;
            }
            return a / b;
        }
        
    }
}