using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SOU_PROYECTO
{

    class Admin
    {
        public void adminapp(string codigo)
        {
            int alumnos, max;
            string jornada, seccionesT;
            string alumnosT = string.Empty;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("¡Bienvenido administrador! Por favor, ingrese la información que se le pide");
        inicio:

            
            try
            {//validación de datos
                // ingreso de datos
                Console.WriteLine("Número maximo de alumnos por clase");
                max = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero total de alumnos");
                alumnos = Convert.ToInt32(Console.ReadLine());
                     //validacion de jornada
            jornada:
                Console.WriteLine("Jornada:");
                jornada = Console.ReadLine();
                bool am = (jornada == "AM");
                bool pm = (jornada == "PM");
                if (am == false)
                {
                    if (pm == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Por favor, ingrese la jornada correctamente (AM o PM)");
                        Console.WriteLine("");
                        goto jornada;
                    }
                }

                // secciones y alumnos
                int secciones = alumnos % max;
                int mitad = max / 2;
                int seccionmenor, divsecciones;
                int modsecciones = secciones % 2;
                double division = alumnos / max;
                double a;
                if ( secciones == 0)
                {
                    seccionesT = Convert.ToString(division);
                    alumnosT = Convert.ToString(max);
                }
                else
                {
                    if (alumnos < max)
                    {
                        seccionesT = "1";
                        alumnosT = Convert.ToString(max);
                    }
                    else
                    {
                    if (secciones < mitad)
                    {
                        seccionmenor = Convert.ToInt32(Math.Floor(division));
                        if (modsecciones == 0)
                        {
                            seccionesT = Convert.ToString(seccionmenor);
                            divsecciones = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(secciones /2)));
                            alumnosT =Convert.ToString(max + divsecciones);
                        }
                        else
                        {
                            seccionesT = Convert.ToString(seccionmenor);
                            a = Math.Floor(Convert.ToDouble(modsecciones /2));
                            alumnosT = Convert.ToString(max + a + 1);
                        }
                    }
                    else
                    {
                        seccionesT = Convert.ToString(division + 1);
                        alumnosT = Convert.ToString(max);
                    }
                }
            }
                //horario
                string horario = string.Empty;
                if (am == true)
                {
                    horario = "Horario: 7:00am a 12:00pm";
                }
                if (pm == true)
                {
                    horario = "Horario: 5:00pm a 9:00pm";
                }


                // declaracion de strings para impresion 
                string codigoImp = "Código de administrador: "+codigo;
                string seccionesImp = "Número de secciones: " + seccionesT;
                string maxImp = "Número original de alumnos por clase: "+ max;
                string newMaxImp = "Número actual de alumnos por clase: " + alumnosT;
                string[] datos = { codigoImp, seccionesImp, maxImp, newMaxImp, horario };

                // impresión 
                Console.WriteLine("Ingrese la dirección en la que desea guardar el archivo (ejemplo: C:\\Users\\ejemplo\\desktop)");
                string ubicación = Console.ReadLine();
                DateTime fecha = DateTime.Now;
                string date = fecha.ToString("yyyyMMddHHmmss");
                string ubicacionreal = ubicación + "\\" + date + "Admin" + codigo + ".txt";

                using (StreamWriter output = new StreamWriter(ubicacionreal))
                {
                    foreach (string info in datos)
                    {
                        output.WriteLine(info);
                    }
                }
                Console.Clear();
                Console.WriteLine("¡Esperamos que regrese pronto!");
                Console.ReadKey();
                Environment.Exit(1);
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Lo siento, no ha ingresado uno de los datos correspondientes. Por favor, intente de nuevo.");
                Console.WriteLine("");
                goto inicio;
            }

        }
    }
}
