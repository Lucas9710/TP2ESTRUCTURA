using System;
using System.IO;

namespace EjercicioStruct
{
    class Tp2Csv
    {

        struct RUTA
        {
            public string altura_fin_derecha;
            public string altura_fin_izquierda;
            public string altura_inicio_derecha;
            public string altura_inicio_izquierda;
            public string categoria;
            public string departamento_id;
            public string departamento_nombre;
            public string fuente;
            public string id;
            public string localidad_censal_id;
            public string localidad_censal_nombre;
            public string nombre;
            public string provincia_id;
            public string provincia_nombre;


            public RUTA(string altura_fin_derecha, string altura_fin_izquierda, string altura_inicio_derecha, string altura_inicio_izquierda, string categoria, string departamento_id, string departamento_nombre, string fuente, string id, string localidad_censal_id, string localidad_censal_nombre, string nombre, string provincia_id, string provincia_nombre)
            {
                this.altura_fin_derecha = altura_fin_derecha;
                this.altura_fin_izquierda = altura_fin_izquierda;
                this.altura_inicio_derecha = altura_inicio_derecha;
                this.altura_inicio_izquierda = altura_inicio_izquierda;
                this.categoria = categoria;
                this.departamento_id = departamento_id;
                this.departamento_nombre = departamento_nombre;
                this.fuente = fuente;
                this.id = id;
                this.localidad_censal_id = localidad_censal_id;
                this.localidad_censal_nombre = localidad_censal_nombre;
                this.nombre = nombre;
                this.provincia_id = provincia_id;
                this.provincia_nombre = provincia_nombre;
            }

            public override String ToString()
            {

                var stringComp = "";
                stringComp += "\n altura final derecha:" + altura_fin_derecha;
                stringComp += "\n altura final izquierda: " + altura_fin_izquierda;
                stringComp += "\n altura inicio derecha: " + altura_inicio_derecha;
                stringComp += "\n altura inicio izquierda: " + altura_inicio_izquierda;
                stringComp += "\n categoria: " + categoria;
                stringComp += "\n departamento id: " + departamento_id;
                stringComp += "\n departamento nombre: " + departamento_nombre;
                stringComp += "\n fuente: " + fuente;
                stringComp += "\n id: " + id;
                stringComp += "\n localidad censal id " + localidad_censal_id;
                stringComp += "\n localidad censal nombre " + localidad_censal_nombre;
                stringComp += "\n nombre " + nombre;
                stringComp += "\n provincia id " + provincia_id;
                stringComp += "\n provincia nombre " + provincia_nombre;

              

                return stringComp;
            }

        }


        private RUTA[] calles;
        private int index = 0;

        private void LeerCsv()
        {

            var reader = new StreamReader(File.OpenRead("calles_1_200.csv"));
            var titulos = reader.ReadLine();
            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();

                var values = line.Split(',');
                var ruta = new RUTA
               (values[0],
                values[1],
                values[2],
                values[3],
                values[4],
                values[5],
                values[6],
                values[7],
                values[8],
                values[9],
                values[10],
                values[11],
                values[12],
                values[13]);

                calles[index] = ruta;

                index++;

            }

            reader.Close();

        }

        public void EjercicioCsv()
        {
            calles = new RUTA[200];
            LeerCsv();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("item " + i);
                Console.WriteLine(calles[i].ToString());
                Console.WriteLine("");

            }
        }


        string nombre_calle = "";

        public void PedirCalle()
        {
            calles = new RUTA[200];
            LeerCsv();
            Console.WriteLine("Ingrese la calle que desea buscar");
            nombre_calle = Console.ReadLine();
            var resultadoDeLaBusqueda = BuscarLocalidad(nombre_calle);
            Console.WriteLine("Resultado: " + resultadoDeLaBusqueda);
        }

        public String BuscarLocalidad(string nombre_calle)
        {

            for (int i = 0; i < calles.Length; i++)
            {
              
                var ruta = calles[i];

                if (ruta.nombre == nombre_calle)
                {
                   
                    return "Localidad: " + ruta.localidad_censal_nombre + "\n" + "Provincia: " + ruta.provincia_nombre;

                }
               

            }

            return "no se encontraron coincidencias";
        }



    }



    class Tp2ejemplo
    {
        static void Main(string[] args)
        {
          


            Tp2Csv tpCsv = new Tp2Csv();
            Tp2Csv tpCsv2 = new Tp2Csv();

            

            tpCsv.EjercicioCsv();
            tpCsv2.PedirCalle();

        }
    }
}
