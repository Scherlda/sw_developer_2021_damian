using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elementCount = 50;
            var initValue = -1;

            int[] meineZahlen;

            meineZahlen = InitArray<int>(5, 0);
            var namen = InitArray<string>(5, "test");
            var datumswert = InitArray<DateTime>(10, DateTime.Now);
        }

        //Generische Methode
        static T[] InitArray<T>(int elementCount, T initValue)              //T steht für Type, aber hier könnte alles stehen ob T, A, Ente oder sonst was. Da wo nun T steht kann jeder Datentyp übergeben werden.
        {
            T[] tmpArray = new T[elementCount];
            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = initValue;
            }

            return tmpArray;
        }




        private static int[] InitArray(int elementCount, int initValue)
        {
            int[] tmpArray = new int[elementCount];

            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = initValue;
            }
            return tmpArray;
        }
    }
}
