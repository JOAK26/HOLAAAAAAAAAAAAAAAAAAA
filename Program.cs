//Escriba un programa que solicite un numero al usuario. Si el numero es mayor que 10 y es impar, mostrar la secuencia de ascendente del 100 al 500, de 10 en 10. Si es mayor que 10 y es par mostrar un saludo 5 veces. Si es menor o igual que 10 mostrar su nombre y matricula 15 veces.



using System;
using System.Diagnostics.CodeAnalysis;

class Program
{

    public static void Main()
    {

        Console.WriteLine("Ingrese un numero");
        int numero = int.Parse(Console.ReadLine()!);
        int modulo = numero;

        if (numero > 10 && modulo % 2 == 0)
        {

                System.Console.WriteLine($"Su numero es {numero} y es par");
           for (int i = 0; i < 5; i++ ){

                Console.WriteLine(i+1 + ". Hola ya sabemos que funciona");
           }
            }
            else if (numero <= 10 )
            {

            for (int i = 0; i < 15; i++ ){

                Console.WriteLine(i+1 + ". ESTEBAN JOSUE MATA ACOSTA" + "********MATRICULA*********" + "2024-1860");
           }  
           }else
            {
            System.Console.WriteLine($"Su numero es {numero} y es impar");

                int num= 100 ;
             for (int i = 0; i < 500; i++)
             {
    
             num  += 10 ;
             i = num ;
             System.Console.WriteLine(i);

           }
           System.Console.ReadLine();
           
        }
            }

            } 
        

       
        




    

