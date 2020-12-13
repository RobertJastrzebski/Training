using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace WordUnscrambler
{

    class LoopsExercise
    {
        public int Loops()
        {
            int[] array = {1, 5, 6, 7, 8, 98, 9};


            List<int> lista = new List<int>() {2, 2, 4, 5, 6, 45, 47};



            //---------------------------------------------------------------------------------
            Console.WriteLine("foreach loop");
            foreach (var liczba in array)
            {
                Console.WriteLine(liczba);
            }

            //----------------------------------------------------------------------------------
            Console.WriteLine("for loop");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);


            }

            //---------------------------------------------------------------------------------
            Console.WriteLine("while loop");

            int Index = 0;
            while (Index < array.Length)
            {

                Console.WriteLine(array[Index]);
                Index++;

            }

            //---------------------------------------------------------------------------------

            string[] lines = {"this is the first line", "This is the second", "This is the third line"};
            File.WriteAllLines("MyFirstFile.txt", lines);



            string[] fileContent = File.ReadAllLines("MyFirstFile.txt");

            foreach (var zdanie in fileContent)
            {
                Console.WriteLine(zdanie);
            } 


            return 0;
        }


    }
}

        

        





       



    


