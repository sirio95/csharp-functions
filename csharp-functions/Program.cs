using System.Linq;

namespace csharp_functions
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            int[] arrNumeri = { 2, 6, 7, 5, 3, 9 };
            int numeroUtente = 0;
            int[] arrUtente = new int[numeroUtente];

            Console.WriteLine("Eccoti un semplice esempio:");
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


            //Bonus

            Console.WriteLine("Ora tocca a te: scegli di quanti numeri vuoi che sia composto l'insieme");
            CreaArrayutente(out arrUtente, out numeroUtente);

            Console.WriteLine("Array Originale: ");
            StampaArray(arrUtente);
            Console.WriteLine("Array Copiato al Quadrato: ");
            StampaArray(ElevaArrayAlQuadrato(arrUtente));
            Console.WriteLine("Sempre array originale: ");
            StampaArray(arrUtente);

            Console.WriteLine("Somma dei numeri nell'array originario: ");
            Console.WriteLine(SommaElementiArray(arrUtente));
            Console.WriteLine("Somma dei numeri nell'array al quadrato: ");
            Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(arrUtente)));



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

        public static int[] CreaArrayutente(out int[] array, out int numeroUtente)
        {
            while(!int.TryParse(Console.ReadLine(), out numeroUtente)){
                Console.WriteLine("Non è complesso: devi inserire un numero");
            };

            int[] arrInterno = new int[numeroUtente];

            Console.WriteLine("Digita ora i numeri che vuoi siano inseriti nell'insieme");

            for(int i=0; i<arrInterno.Length; i++)
            {
                int num;
                while (!int.TryParse(Console.ReadLine(), out num ))
                {
                    Console.WriteLine("Non è complesso: devi inserire un numero");
                }
                
                arrInterno[i] = num;
            }
            return array = arrInterno;
        }
    }
}