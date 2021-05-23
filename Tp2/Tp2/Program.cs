/*/*
* Materia: Estructura de datos
* Docente: Ing. Pablo Avellaneda
*
* TP nro 2
* ej nro 1
* Fecha 01/01/2021
*
* 
*Integrantes ( nombre y apellido ):
*Lucas Nuñez
+Laura Lopez
*Carina Vega
*
*Las respuestas a las preguntas del tp se encuentran al final del codigo.
*/

using System;

namespace EjerciciosBusqueda
{
    class MainClass
    {

        public static void Main(string[] args)
        {


            int[] array = new int[] { 21, 27, 21, 22, 3, 28, 7, 9, 24, 12, 19, 30, 19, 4, 19, 22, 36, 17, 30, 15 };


            string[] paises = new string[35] {"Antigua y Barbuda", "Argentina", "Bahamas", "Barbados", "Belice", "Bolivia"
            , "Brasil", "Canada", "Chile", "Colombia", "Costa Rica", "Cuba", "Dominica", "Ecuador", "El Salvador"
             ,"Estados Unidos", "Granada", "Guatemala", "Guyana", "Haiti", "Honduras", "Jamaica", "Mexico", "Nicaragua",
            "Panama", "Paraguay", "Peru", "Republica Dominicana", "San Cristobal y Nieves", "San Vicente y Las Granadinas",
              "Santa Lucía", "Surinam", "Trinida y Tobago", "Uruguay", "Venezuela"};


            //ejercicio 1.1

            //Secuencial1(array);
           // Binario1(array);



            // ejercicio 1.2
           
           // secuencia2(paises);
            binario2(paises);
        }

    //ejecicio 1.1

        static void Secuencial1(int[] array)
        {
            int corte = 0;
            int i = 0;
            int corte2 = 0;


            while (i < array.Length && (corte == 0 || corte2 == 0))
            {
                switch (array[i])
                {
                    case 27:
                        {
                            Console.WriteLine("el numero 27 esta en la posicion " + i);
                            corte = 1;
                            break;


                        }

                    case 30:
                        {
                            Console.WriteLine("el numero 30 esta en la posicion " + i);
                            corte2 = 1;
                            break;
                        }

                    default:
                        {

                            break;
                        }
                }
                i++;
            }

            if (corte == 0)
            {
                Console.WriteLine("el numero 27 no esta");
            }

            if (corte2 == 0)
            {
                Console.WriteLine("el numero 30 no esta");
            }

        }

        static void Binario1(int[] array)
        {
            int pos = -1;
            int pos1 = -1;
            int pivote1 = 0;
            int pivote2 = 0;
            int min = 0;
            int max = array.Length - 1;
            int min1 = 0;
            int max1 = array.Length - 1;



            while (min < max && pos < 0)
            {
                pivote1 = (max + min) / 2;

                if (array[pivote1] == 27)
                {
                    pos = pivote1;
                }

                if (array[pivote1] < 27)
                {

                    min = pivote1 + 1;
                }
                else
                {
                    max = pivote1 - 1;


                }


            }

            while (min1 < max1 && pos1 < 0)
            {
                pivote2 = (min1 + max1) / 2;

                if (array[pivote2] == 30)
                {
                    pos1 = pivote2;
                }

                if (array[pivote2] < 30)
                {

                    min1 = pivote2 + 1;
                }
                else
                {
                    max1 = pivote2 - 1;


                }


            }

            if (pos1 >= 0)
            {
                Console.WriteLine("el numero 30 se encuentra en la posicion " + pos1);
            }
            else
            {
                Console.WriteLine("el numero 30 no se encuentra");

            }

            if (pos >= 0)
            {
                Console.WriteLine("el numero 27 se encuentra en la posicion " + pos);
            }
            else
            {
                Console.WriteLine("el numero 27 no se encuentra");

            }

        }

        //ejercicio 1.2
        static void secuencia2(string[] paises)
        {


            string pais = "Venezuela";
            int iteraciones = 0;
            

            for (int i = 0; i < paises.Length; i++)
            {
                iteraciones++;
                if (string.Compare(paises[i], pais ) == 0)
                {
                    Console.WriteLine("el " + paises[i] + " esta en la posicion " + i);
                    Console.WriteLine("El algoritmo hizo " + iteraciones + " iteraciones");
                    break;
                }

               
            }

          

        }

        static void binario2(string[] paises)
        {
            int min = 0;
            int max = paises.Length - 1;
            int pivote = 0;
            int pos = -1;
            string pais = "Venezuela";
            int iteraciones = 0;
          

            while (min <= max && pos < 0)
            {
                pivote = (min + max) / 2;
                Console.WriteLine(paises[pivote]);
               
                iteraciones++;
                int comparacion = pais.CompareTo(paises[pivote]);
                if (comparacion == 0){
                    pos = pivote;
                  

                }

                //si el pais es menor al pivote devuelve -1
               if(comparacion < 0)
                {
                    max = pivote - 1;
                }

               //si el pais es mayor al pivote, devuelve 1
               if(comparacion > 0)
                {
                    min = pivote + 1;
                   
                }

              

            }

            if(pos >= 0)
            {
                Console.WriteLine("El pais "+ pais +" esta en la posicion " + pos);
                Console.WriteLine("el algoritmo tardo " + iteraciones + " iteraciones");
            }

        }


    }
}

/*
1.1 La busqueda binaria no funciona porque el arreglo esta desordenado, ya que esta al fijarse si un 
elemento es menor o mayor al elemento buscado, necesita estar odenada. En estos casos no queda otra que 
buscar elemento por elemento de forma secuencial.



1.2
1. Adaptar el programa para que cuente la cantidad de iteraciones, la cantidad de ”vuel-
tas”que da el bucle.Cuantas iteraciones necesita cada algoritmo para completar cada
búsqueda de cada paı́s?

Pais                Binaria     Secuencial
Antigua Y Barbuda      5             1
Venezuela              6             35
Paraguay               6             26   
Colombia               5             10  
Granada                6             17

2. Qué algoritmo fue ’mejor’ ( el que realizó menos iteraciones)?

La busqueda binaria es màs optimo que la busqueda secuencial, ya que no recorre tod0 el arreglo,
pero esta depende de que el arreglo este ordenado, solo asì funciona.


3. Algún algoritmo fue el mejor ’siempre’ ?

La busqueda binaria casi siempre fue mejor, a la busqueda secuencial lo favorece si se busca elementos
que estèn en los primeros espacios del arreglo, como en el caso de Antigua y Barbuda.











*/
