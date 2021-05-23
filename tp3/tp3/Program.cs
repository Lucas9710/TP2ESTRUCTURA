using System;

namespace tp3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = { 400, 300, 100, 900, 600, 500, 700, 200, 1000, 800};




            Seleccion(array);
        }

        static void Seleccion(int[] array)
        {
            int indexDelMinimo = 0;
            int maxIndex = array.Length - 1;
            Console.WriteLine("EL ARRAY ORIGINAL ES: " + "!!");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }


            for (int indexActualSecuencial = 0; indexActualSecuencial <= maxIndex; indexActualSecuencial++)
            {
                indexDelMinimo = indexActualSecuencial;
                // en este punto todavia no esta definido cual es el index del minimo
                for (int j = indexActualSecuencial + 1; j<= maxIndex; j++)
                {
                    int valorAComparar = array[j];
                    int valorDelMejorMinimoHastaElMomento = array[indexDelMinimo];
                    if (valorAComparar < valorDelMejorMinimoHastaElMomento)
                    {
                        //el valor actual no era el minimo posible, se encontro un valor menor
                        // el index de este valor menor, es "j"
                        // por este motivo, indexDelMinimo pasa a ser = j
                        indexDelMinimo = j;
                    }
                }

                // en este punto SI esta definido cual es el index del minimo



                Console.WriteLine("\n\n\nANALIZANDO EN EL INDEX " + indexActualSecuencial + " ...");
                //SOLO HAGO UN SWAP SI EL INDEX ACTUAL NO ES EL INDEX DEL VALOR MINIMO
                if (indexActualSecuencial != indexDelMinimo)
                {
                    int aux = array[indexActualSecuencial];
                    array[indexActualSecuencial] = array[indexDelMinimo];
                    array[indexDelMinimo] = aux;

                    Console.WriteLine("NO TENGO EL VALOR MINIMO POSIBLE EN INDEX " + indexActualSecuencial + ", SI NECESITO HACER UN SWAP CON INDEX " + indexDelMinimo);
                } else {
                    Console.WriteLine("YA TENGO EL VALOR MINIMO POSIBLE EN INDEX " + indexActualSecuencial + ", NO NECESITO HACER UN SWAP");
                }


                Console.WriteLine("EL ARRAY AHORA ES: "
                 + "!!");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + ", ");
                }

            }

            Console.WriteLine(" RESULTADO DEL ORDENAMIENTO:");
            //imprimir el resultado final - NO IMPORTA NADA
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}
