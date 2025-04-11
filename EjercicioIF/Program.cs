using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            //Aritméticos(+, -, *, /, %)
            //Relacionales(==, !=, <, >, <=, >=)
            //Lógicos(&&, ||, !)

            //Igual ==
            if (edad == 18)
            {
                Console.WriteLine("La variable es igual a 18");

            }
            else
            {
                Console.WriteLine("La variable no es igual a 18");
            }

            //Distinto !=
            if (edad != 18)
            {

                Console.WriteLine("La variable es distinta");

            }
            else
            { 
                Console.WriteLine("La variable es igual");
            }

            //Menor <
            if (edad < 18)
            {
                Console.WriteLine("La variable es menor a 18");

            }
            else
            {
                Console.WriteLine("La variable es mayor a 18");
            }

            //Mayor >
            if (edad > 18)
            {
                Console.WriteLine("La variable es mayor a 18");

            }
            else
            {
                Console.WriteLine("La variable es menor a 18");
            }

            //Menor o igual <=
            if (edad <= 18)
            {
                Console.WriteLine("La variable es menor o igual a 18");

            }
            else
            {
                Console.WriteLine("La variable es mayor a 18");
            }

            //Mayor >
            if (edad >= 18)
            {
                Console.WriteLine("La variable es mayor o igual a 18");

            }
            else
            {
                Console.WriteLine("La variable es menor a 18");
            }

            //Logicos || combinados con relacionales
            if (edad < 18 || edad > 65)
            {
                Console.WriteLine("Tiene derecho a un descuento.");
            }
            else
            {
                Console.WriteLine("No aplica descuento.");
            }

            //Logicos && combinados con relacionales
            if (edad >= 10 && edad < 20)
            {
                Console.WriteLine("Usted se encuentras en los 10's ");

            }
            else
            {
                Console.WriteLine("Usted no se encuentras en los 10's ");
            }

            //Logicos ! combinados con relacionales
            if (!(edad > 20))
            {
                Console.WriteLine("La edad NO es mayor que 20");
            }
            else
            {
                Console.WriteLine("La edad SÍ es mayor que 20");
            }

            //Varios If Anidados
            if (edad > 20)
            {
                Console.WriteLine("La edad es mayor que 20");
            }
            else if (edad < 20)
            {
                Console.WriteLine("La edad es menor que 20");
            }
            else
            {
                Console.WriteLine("La edad es igual que 20");
            }
        }
    }
}
