using System;
using static System.Console;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {                          
            string[] number1 = ReadLine().Split(',');
            string[] number2 = ReadLine().Split(',');            

                try
                {
                    if (number1.Length != number2.Length)
                    {
                        throw new Exception("Array de tamanhos diferentes.");
                    }
                    else{
                        int nValue = number1.Length;
                        int[] value = new int[nValue];                    
                        for(int n1 = 0; n1 < number1.Length-1; n1++){
                            for(int n2 = 0; n2 < number2.Length-1; n2++){
                                value[nValue] = Convert.ToInt32(number1[n1]) * Convert.ToInt32(number2[n2]);
                                WriteLine($"{value[nValue]}");

                            }
                        }
                    }
                }
                catch (Exception fault)
                {
                    WriteLine($"Erro:{fault.Message}");
                }
        
        }           
    }
}
