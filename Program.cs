using System;

namespace Vize2exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Dizi kac elemanli : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dizi elemanlarini giriniz : ");
            
            int[] dizi = new int[a];
            
            for(int i = 0; i<a; i++)
            {
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            compare(dizi, a);

           foreach(int sayi in dizi)
            {
                Console.WriteLine("------------------\n" + sayi);
            }

        }

        static void compare(int[] array , int number )
        {

            for (int i = 0; i<number; i++)
            {

                for (int j = 0; j<i; j++)
                {

                    if(array[i] == array[j])
                    {
                        array[i] = -1;
                    }
                }
            }


           
        }

    }
}
