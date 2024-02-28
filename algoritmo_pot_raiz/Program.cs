public class Program
{
    private static void Main(string[] args)
    {
        //Realizar un algoritmo que me pida tres numeros por pantalla, con el primer numero hallar el cuadrado, con el segundo hallar
        //la raiz cudrada y con el tercero hallar la raiz cubica. Mostrar en pantalla los tres resultados en pantalla.
        int num1,num2,num3;
        double cuad, raiz, racub;
        Console.WriteLine("Numeros positivos");
        Console.WriteLine("Digite el primer numero");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nDigite el segundo numero");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nDigite el tercer numero");
        num3 = Convert.ToInt32(Console.ReadLine());

        cuad = num1 * num1;
        raiz = Math.Sqrt(num2);
        racub = Math.Cbrt(num3);

        Console.WriteLine("El cuadrado del primer numero es:" + cuad + "\nLa raiz cuadrada del segundo numero es:" + raiz + "\nLa raiz cubica del tercer numero es:" + racub);

    }
}