using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bug();
            }
            catch (Exception ex)
            {
                Console.WriteLine("wyskoczyl wyjatek w aplikacji");
                Console.WriteLine(ex.Message);
                



            }
            Console.ReadLine();

        }


        private static void Bug()
        {
            int[] liczby = new[] { 1, 2, 5 };
            for (int i = 0; i <= liczby.Length; i++)
            {
                try
                {
                    Console.WriteLine(liczby[i]);
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine(ex.Message);
                    throw new Exception("mamy bład w petli", ex);

                }
                
            }
        }

    }

}
