using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

public class Program
{
    private static void Main(string[] args)
    {
        //La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas a sus clientes. Los ingredientes para cada tipo de pizza aparecen a continuación.
        //Ingredientes vegetarianos: Pimiento y tofu
        //Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.
        //Escribir un programa en C# que pregunte al usuario si quiere una pizza vegetariana o no, y en función de su respuesta le muestre un menú con los ingredientes disponibles para que elija. Solo se puede elegir un ingrediente además de la mozzarella y el tomate que están en todas las pizzas. Al final se debe mostrar por pantalla si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.

        Int32 opcion, ingveg, ingnov;

        Console.Write("Digite 1 para pizza vegetariana o 2 para pizza no vegetariana: ");
        opcion = Int32.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.Write("Elija 1 para pimiento o 2 para tofu: ");
            ingveg = Int32.Parse(Console.ReadLine());
            if (ingveg == 1) { Console.WriteLine("Usted ha elegido pizza vegetarina con pimiento, tomate y mozzarela"); }
            else if (ingveg == 2) { Console.WriteLine("Usted ha elegido pizza vegetarina con tofu, tomate y mozzarela"); }
        }
        else
            if (opcion == 2)
        {
            Console.Write("Elija 1 para peperoni o 2 para jamon o 3 para salmon: ");
            ingnov = int.Parse(Console.ReadLine());
            if (ingnov == 1) { Console.WriteLine("Usted ha elegido pizza no  vegetarina con peperoni, tomate y mozzarela"); }
            else if (ingnov == 2) { Console.WriteLine("Usted ha elegido pizza no vegetarina con jamon, tomate y mozzarela"); }
                 else if(ingnov == 3) { Console.WriteLine("Usted ha elegido pizza no vegetarina con salmon, tomate y mozzarela"); }
              
        }

             
        
        

             
        
        
        
    }   
}


        
    
    
          


    
    
    
        


    
         

