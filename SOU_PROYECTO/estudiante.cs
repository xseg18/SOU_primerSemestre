using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace SOU_PROYECTO
{
    class validacion
    {
    public bool val(string carnet)
    {
        try
        {
            int x = Convert.ToInt32(carnet);
            return true;
        }
        catch (Exception)
        {
             return false;
        }
    }
    }
    class estudiante
    {
        public void estudianteapp(string carnet)
        {

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("¡Bienvenido Estudiante! Por favor, ingrese los siguientes datos:");
            Console.WriteLine("");
        inicio:
            try
            {
                Console.WriteLine("Ingrese su nombre o nombres:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Apellidos");
                string apellidos = Console.ReadLine();
                bool dpi;
                string departamento = string.Empty;

                Console.WriteLine("Número de cursos:");
                int cursos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Número de laboratorios:");
                int lab = Convert.ToInt32(Console.ReadLine());
            jornada:
                Console.WriteLine("Jornada (AM O PM):");
                string jornada = Console.ReadLine();
                bool am = (jornada == "AM");
                bool pm = (jornada == "PM");
                if (am == false && pm == false)
                {
                    Console.Clear();
                    Console.WriteLine("Por favor, ingrese la jornada correctamente (AM o PM)");
                    goto jornada;
                }

            cui:
                Console.WriteLine("Codigo Unico de Identificación (CUI) o NA en caso de no tenerlo");
                string cui = Console.ReadLine();
                int cuis = cui.Length;
                if (cuis != 13)
                {
                    switch (cui)
                    {
                        case "NA":
                            dpi = false; break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Valores ingresados no válidos, intentelo de nuevo"); goto cui;
                    }
                }
                else
                {
                    dpi = true;
                }


                // nombres
                string inombre = ("Estudiante: " + apellidos + ", " + nombre);

                // departamentos
                if (dpi == true)
                {
                    int x = Convert.ToInt32(cui.Substring(cui.Length - 4));
                    if (x >= 0101 && x <= 0117)
                    {
                        departamento = "Departamento: Guatemala";
                    }
                    else if (x >= 0201 && x <= 0208)
                    {
                        departamento = "Departamento: El Progreso";
                    }
                    else if (x >= 0301 && x <= 0316)
                    {
                        departamento = "Departamento: Sacatepequez";
                    }
                    else if (x >= 0401 && x <= 0416)
                    {
                        departamento = "Departamento: Chimaltenango";
                    }
                    else if (x >= 0501 && x <= 0513)
                    {
                        departamento = "Departamento: Escuintla";
                    }
                    else if (x >= 0601 && x <= 0614)
                    {
                        departamento = "Departamento: Santa Rosa";
                    }
                    else if (x >= 0701 && x <= 0719)
                    {
                        departamento = "Departamento: Sololá";
                    }
                    else if (x >= 0801 && x <= 0808)
                    {
                        departamento = "Departamento: Totonicapán";
                    }
                    else if (x >= 0901 && x <= 0924)
                    {
                        departamento = "Departamento: Quetzaltenango";
                    }
                    else if (x >= 1001 && x <= 1021)
                    {
                        departamento = "Departamento: Suchitepequez";
                    }
                    else if (x >= 1101 && x <= 1109)
                    {
                        departamento = "Departamento: Retalhuleu";
                    }
                    else if (x >= 1201 && x <= 1230)
                    {
                        departamento = "Departamento: San Marcos";
                    }
                    else if (x >= 1301 && x <= 1332)
                    {
                        departamento = "Departamento: Huehuetenango";
                    }
                    else if (x >= 1401 && x <= 1421)
                    {
                        departamento = "Departamento: Quiché";
                    }
                    else if (x >= 1501 && x <= 1508)
                    {
                        departamento = "Departamento: Baja Verapaz";
                    }
                    else if (x >= 1601 && x <= 1617)
                    {
                        departamento = "Departamento: Alta Verapaz";
                    }
                    else if (x >= 1701 && x <= 1714)
                    {
                        departamento = "Departamento: Petén";
                    }
                    else if (x >= 1801 && x <= 1805)
                    {
                        departamento = "Departamento: Izabal";
                    }
                    else if (x >= 1901 && x <= 1911)
                    {
                        departamento = "Departamento: Zacapa";
                    }
                    else if (x >= 2001 && x <= 2011)
                    {
                        departamento = "Departamento: Chiquimula";
                    }
                    else if (x >= 2101 && x <= 2107)
                    {
                        departamento = "Departamento: Jalapa";
                    }
                    else if (x >= 2201 && x <= 2217)
                    {
                        departamento = "Departamento: Jutiapa";
                    }
                }
                else
                {
                    departamento = "Departamento no disponible";
                }

                // año de ingreso
                string año = carnet.Substring(5);
                int años = Convert.ToInt32(año);
                string añosT = string.Empty;
                if (años >= 51 && años <= 99)
                {
                    añosT = ("Año de ingreso: 19" + años);
                }
                if (años >= 00 && años <= 50)
                {
                    añosT = ("Año de ingreso: 20" + años);
                }

                // carrera, clases, labs, matricula y mensualidad
                string carrera = carnet.Substring(3, 2);
                int carreran = Convert.ToInt32(carrera);
                int insis = carreran % 11;
                int sis = carreran % 13;
                int ind = carreran % 15;
                string carreraF;
                int clasesT, men, labT, matricula, semestre;
                if (carreran == 00 || insis == 0)
                {
                    carreraF = "Ingenieria Indrustrial y de Sistemas";
                    clasesT = cursos * 1500;
                    labT = lab * 900;
                    matricula = 3000;
                    semestre = (clasesT + labT + matricula);
                    men = semestre / 4;
                }
                else if (sis == 0)
                {
                    carreraF = "Ingenieria en Sistemas";
                    clasesT = cursos * 1600;
                    labT = lab * 700;
                    matricula = 2000;
                    semestre = (clasesT + labT + matricula);
                    men = semestre / 4;
                }
                else if (ind  ==0)
                {
                    carreraF = "Ingenieria Industrial";
                    clasesT = cursos * 1700;
                    labT = lab * 500;
                    matricula = 3000;
                    semestre = (clasesT + labT + matricula);
                    men = semestre / 4;
                }
                else
                {
                    carreraF = "Ingenieria Electrónica";
                    clasesT = cursos * 1800;
                    labT = lab * 300;
                    matricula = 2000;
                    semestre = (clasesT + labT + matricula);
                    men = semestre / 4;
                }

                // horario
                string horario = string.Empty;
                if (am == true)
                {
                    horario = "Horario: 7:00am a 12:00pm";
                }
                if (pm == true)
                {
                    horario = "Horario: 5:00pm a 9:00pm";
                }




                // conversión de ints a strings para ingresar en el array del .txt
                string clases = "Cantidad a pagar por clases: " + Convert.ToString(clasesT) + "GTQ";
                string labsT = "Cantidad a pagar por laboratorios: " + Convert.ToString(labT) + "GTQ";
                string mensualidad = "Cantidad total a pagar mensualmente: " + Convert.ToString(men) + "GTQ";
                string sem = "Cantidad total a pagar por semestre: " + Convert.ToString(semestre) + "GTQ";
                string matriculas = "Cantidad total a pagar por matrícula: " + Convert.ToString(matricula) + "GTQ";
                string carnet2 = "Carnet: " + carnet;
                string[] datos = { inombre, departamento, carnet2, añosT, carreraF, clases, labsT, matriculas, mensualidad, sem, horario };
                Console.WriteLine("Ingrese la dirección en la que desea guardar el archivo ejemplo C:\\Users\\ejemplo\\desktop:");
                string ubicación = Console.ReadLine();
                DateTime fecha = DateTime.Now;
                string date = fecha.ToString("yyyyMMddHHmmss");
                string ubicacionreal = ubicación + "\\" + date + "Alumno" + carnet + ".txt";
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
                Console.WriteLine("Alguno de los campos fue dejado en blanco. Porfavor revise correctamente su información e intentelo de nuevo");
                goto inicio;
            }

        }
    }
}