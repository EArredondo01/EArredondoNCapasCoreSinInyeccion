using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTxt
{
    public class txt
    {
        public static void Mensaje()
        {
            // Ruta relativa
            // Ruta partiendo de un directorio en especifico
            // Ruta absoluta
            // Toda la ruta del archivo.

            string rutatxt = "C:\\Users\\digis\\Downloads\\TxtJunio.txt";

            using (StreamReader sr = File.OpenText(rutatxt))
            {              
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    // arreglo de string
                    //do what you have to here

                    //asignacion de valores
                    Console.WriteLine(s);

                    // Erick
                    // Arredondo
                    //Arzola
                    // 546545454   
                    // JHSDYUGHJKFSD1441


                    //imprimen
                }
            }

            Console.WriteLine("Hola desde otra clase");
        }
    }
}
