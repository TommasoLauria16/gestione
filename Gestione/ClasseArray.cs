using System;

namespace Gestione
{
    public class ClasseArray
    {
        private const int a = 5;
        private static int[] array = new int[a];
        public static void Riempimento(bool vf)
        {
            Random r = new Random();
            if (vf == true)
            {
                for(int i =0; i < array.Length; i++)
                {
                    array[i] = r.Next();
                }
            }
            else
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"inserisci il valore in posizione {i}");
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void OrdineStampa(bool destraSinistra)
        {
            if (destraSinistra == true)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            else
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }

        }
    }
}
