using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        //Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.
        double num1, num2, num3;

        Console.Write("Digite el primer numero: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite el segundo numero: ");
        num2 = double.Parse(Console.ReadLine());

        Console.Write("Digite el tercer numero: ");
        num3 = double.Parse(Console.ReadLine());

        if ((num1 > num2) && (num1 > num3))
        {
            Console.WriteLine("El numero mayor es: " + num1);

        }

        else
        { if ((num2 > num1) && (num2 > num3))Console.WriteLine("El numero mayor es: " + num2);
          else
            {
                if ((num2 > num1) && (num2 > num3)) Console.WriteLine("El numero mayor es: " + num2);
                else Console.WriteLine("El numero mayor es: " + num3);
            }




           
            
            
            











    }
    }   }
        
      
             

               
            
       

        
         
        
        
        




















    
   
        

        
        


      
        

            







            

           
            
            
            
            
            

            
            
            
            

                
             
                 
                 
                   



            
                


            



    

