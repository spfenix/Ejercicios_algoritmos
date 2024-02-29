public class Program
{
    private static void Main(string[] args)

    {//Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos
        double mayor, seg2, seg3,suma;
        string mensaje = "Se puede construir el triangulo";

        Console.Write("Digita de los tres segmentos del triangulo, el mayor de ellos: ");
        mayor = double.Parse(Console.ReadLine());

        Console.Write("Digita el segundo segmento: ");
        seg2 = double.Parse(Console.ReadLine());

        Console.Write("Digita el tercer segmento: ");
        seg3 = double.Parse(Console.ReadLine());

        suma = seg2 + seg3;

        if (suma > mayor)
            Console.WriteLine(string.Format("Si {0}", mensaje));

        else
            Console.WriteLine(string.Format("No {0}", mensaje));






    }
}   