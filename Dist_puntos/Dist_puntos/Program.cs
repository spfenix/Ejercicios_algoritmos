public class Program
{
    private static void Main(string[] args)
    {
        //Distancia entre dos puntos
        double  x1, x2, y1, y2, dist;
        Console.Write("Por favor digite el x1: ");
        x1 = Double.Parse(Console.ReadLine());

        Console.Write("Por favor digite el x2: ");
        x2 = Double.Parse(Console.ReadLine());

        Console.Write("Por favor digite el y1: ");
        y1 = Double.Parse(Console.ReadLine());

        Console.Write("Por favor digite el y2: ");
        y2 = Double.Parse(Console.ReadLine());

        dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine(string.Format("la distancia entre los pares ordenados ({0},{1}) y ({2},{3}) es = {4})",x1, y1,x2,y2,dist));

    }
}