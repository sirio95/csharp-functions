using System.Linq;

namespace csharp_functions
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            int[] arrNumeri = { 2, 6, 7, 5, 3, 9 };

            Console.WriteLine("Array Originale: ");
            StampaArray(arrNumeri);
            Console.WriteLine("Array Copiato al Quadrato: ");
            StampaArray(ElevaArrayAlQuadrato(arrNumeri));
            Console.WriteLine("Sempre array originale: ");
            StampaArray(arrNumeri);

            Console.WriteLine("Somma dei numeri nell'array originario: ");
            Console.WriteLine(SommaElementiArray(arrNumeri));
            Console.WriteLine("Somma dei numeri nell'array al quadrato: ");
            Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(arrNumeri)));





        }


        public static void StampaArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
                if (i < array.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine("]");
        }
        public static int Quadrato(int numero)
        {
            return numero * numero;
        }
        public static int[] ElevaArrayAlQuadrato(int[] array)
        {
            int[] arrayCopy = (int[])array.Clone();
            for(int i=0; i<arrayCopy.Length; i++)
            {
                arrayCopy[i] = Quadrato(arrayCopy[i]);
            }
            return arrayCopy;
        }
        public static int SommaElementiArray(int[] array)
        {
            int somma = array.Sum();
            return somma;
        } 


    }
}