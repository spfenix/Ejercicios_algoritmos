using System.ComponentModel;

public class Program
{
    private static void Main(string[] args)
    {
        //Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:
        // -Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
        // -Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
        // -Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
        // - Si el IMC es mayor de 29.9 entonces tiene obesidad.
        // Mostrar en pantalla la categoría de cada uno de los pacientes.
        // La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular.
        int numpac = 0, opt;
        bool validador;
        double masa, altura, imc;
        do
        {
            Console.Write("Ingrese el numero de pacientes para evaluar su IMC: ");
            numpac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numpac; i++)
            {
                Console.Write("Por favor digite el peso en kilogramos: ");
                masa = int.Parse(Console.ReadLine());
                Console.Write("Por favor digite la altura  en metros: ");
                altura = double.Parse(Console.ReadLine());

                imc = masa / (altura * altura);

                if (imc < 18.5) Console.Write("Tiene peso insuficiente\n");
                if ((imc >= 18.5) && (imc <= 24.9)) Console.Write("Se encuentra en la categoria de peso saludable\n");
                if ((imc >= 25.0) && (imc <= 29.9)) Console.Write("Tiene sobrepeso\n");
                if (imc > 29.9) Console.Write("Tiene obesidad");
            }
            Console.Write("Digite 1 para seguir evaluando o 0 para terminar\n: ");
            opt = int.Parse(Console.ReadLine());

            if (opt == 0) validador = false;
            else validador = true;
          
           
        } while (validador == true) ;
}   }  