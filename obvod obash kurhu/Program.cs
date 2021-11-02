using System;

namespace obvod_obash_kurhu
{
    class Program
    {
        static void Main(string[] args)
        {
            double polomer;
            double prumer;
            double vyber;
            double obvod;
            double obsah;

            Console.WriteLine("KRUH");

            Console.WriteLine("Vyberte z možností (1 polomer)" +
                "                                 (2 prumer)");
            double.TryParse(Console.ReadLine(), out vyber);


            
            


            if (vyber == 1)
            {
                Console.WriteLine("Zadejte polomer");
                Double.TryParse(Console.ReadLine(), out polomer);
                obvod = 2 * 3.14 * polomer;
                obsah = 3.14 * (polomer * polomer);
                Console.WriteLine($"o = {obvod}" +
                    $" S = {obsah}");
                
            }
            else if (vyber == 2)
            {
                Console.WriteLine("Zadejte prumer");
                Double.TryParse(Console.ReadLine(), out prumer);
                obvod = 3.14 * prumer;
                obsah = 3.14 * (prumer * prumer) / 4;
                Console.WriteLine($"o = {obvod}" +
                    $" S = {obsah}");

            }
              Console.ReadLine();
            Math.Round( 0.1);




        }
  
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
