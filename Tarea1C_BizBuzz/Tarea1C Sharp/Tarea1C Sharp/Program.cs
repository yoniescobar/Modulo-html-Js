using System;

namespace Tarea1C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Type        Byte(s) of memory   \t\t\t    Main\t\t\t\t\t       Max");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
          
            Console.WriteLine($"sbyte      {sizeof(sbyte)}       \t {sbyte.MinValue,40}  \t  {sbyte.MaxValue,40}");
            Console.WriteLine($"byte       {sizeof(byte)}        \t {byte.MinValue,40}   \t  {byte.MaxValue,40}");
            Console.WriteLine($"short      {sizeof(short)}       \t {short.MinValue,40}  \t  {short.MaxValue,40}");
            Console.WriteLine($"ushort     {sizeof(ushort)}      \t {ushort.MinValue,40} \t  {ushort.MaxValue,40}");
            Console.WriteLine($"int        {sizeof(int)}         \t {int.MinValue,40}    \t  {int.MaxValue,40}");
            Console.WriteLine($"uint       {sizeof(uint)}        \t {byte.MinValue,40}   \t  {uint.MaxValue,40}");
            Console.WriteLine($"long       {sizeof(long)}        \t {long.MinValue,40}   \t  {long.MaxValue,40}");
            Console.WriteLine($"ulong      {sizeof(ulong)}       \t {ulong.MinValue,40}  \t  {ulong.MaxValue,40}");
            Console.WriteLine($"float      {sizeof(float)}       \t {float.MinValue,40}  \t  {float.MaxValue,40}");
            Console.WriteLine($"double     {sizeof(double)}      \t {double.MinValue,40} \t  {double.MaxValue,40}");
            Console.WriteLine($"decimal    {sizeof(decimal)}     \t {decimal.MinValue,40}\t  {decimal.MaxValue,40}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("\n\n ================================= programa No. 2================================================================\n");

            //lenando vector de numeros
            int nElementos = 101;
            string[] numeros = new string[nElementos];
          
            for (int i = 0; i < nElementos; i++){
                numeros[i] = i.ToString() ;
            }

            for (int i = 1; i < nElementos; i++){
               
                if (Int32.Parse(numeros[i]) % 3 == 0){
                    numeros[i] = "Fizz";
                    
                }else if (Int32.Parse(numeros[i]) % 5 == 0){
                    numeros[i] = "Buzz";
                  
                }else if ((Int32.Parse(numeros[i]) % 3 == 0) && (Int32.Parse(numeros[i]) % 5 == 0)){
                    numeros[i] = "FizzBuzz";
                }

                Console.Write(numeros[i] + ", ");

            }


          
            Console.WriteLine("\n\n =================================Developer by: Yoni Escobar=============================================================\n");

            Console.ReadLine();
        }
    }
}
