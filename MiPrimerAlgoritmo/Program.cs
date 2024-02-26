// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
public class Program
{
    static void Main(string[] args)
    {
        //Ingresar por pantalla dos numeros y calcular las cuatro operaciones aritmeticas con dichos numeros.Mostrar en pantalla
        //un mensaje de advertencia que el segundo numero debe ser diferente de 0. Imprimir en pantalla el resultado de cada operacion
        int num1, num2;
        double sum, rest, prod, cocie;

        Console.WriteLine("Ingrese el primer numero");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero, debe ser diferente de 0");
        num2 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2;
        rest = num1 - num2;
        prod = num1 * num2;
        cocie = num1 / num2;

        Console.WriteLine("La suma es: " + sum + "La resta es: " + rest + " El producto es: " + prod + " El cociente es: " + cocie);

    }
}