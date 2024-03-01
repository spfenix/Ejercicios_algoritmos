public class Program
{
    private static void Main(string[] args)
    //Construir un programa que pida un número y luego diga si este número es par o no. 
    {
        double num;
        Console.Write("Digita un numero: ");
        num = Convert.ToDouble(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("El numero digitado es par");

        else
            Console.WriteLine("El numero digitado es impar");
    }
}




           