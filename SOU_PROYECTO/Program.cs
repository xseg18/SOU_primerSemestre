using System;

namespace SOU_PROYECTO
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE ORIENTACIÓN UNIVERSITARIA");
            Console.WriteLine("");
        selección:
            Console.WriteLine("SELECCIONE SU USUARIO:");
            Console.WriteLine("1)    Estudiante");
            Console.WriteLine("2)    Administrador");
            Console.WriteLine("");
            Console.WriteLine("0)    Salir");
            try {
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {

                    case 1:
                        Console.Clear();
                        string ususarioEST, contraseñaEST;

                        Console.WriteLine("SISTEMA DE ORIENTACIÓN UNIVERSITARIA");
                    //ESTUDIANTE
                    InicioEstudiante:
                        try
                        {
                            // INGRESO DE DATOS
                            Console.WriteLine("");
                            Console.WriteLine("USUARIO:");
                            ususarioEST = Console.ReadLine();
                            Console.WriteLine("CONTRASEÑA:");
                            contraseñaEST = Console.ReadLine();
                            string carnet;
                            // CREACION DEL CARNET
                            carnet = ususarioEST.Substring(ususarioEST.Length - 7);
                            int lenght = ususarioEST.Length;
                            string carnetstring = carnet.ToString();
                            bool usuario = ususarioEST.Contains("EST" + carnet);
                            bool contraseña = contraseñaEST.Contains(carnet + "EST");
                            int lenght2 = carnetstring.Length;
                            validacion comprobacion = new validacion();
                            estudiante ingreso = new estudiante();

                            // COMPROBACION DE USUARIO,CARNET Y CONTRASEÑA
                            if (lenght == 10 && lenght2 == 7)
                            {
                                switch (usuario)
                                {
                                    case true:

                                        switch (contraseña)
                                        {
                                            case true:
                                                Console.Clear();
                                                comprobacion.val(carnet); 
                                                if (comprobacion.val(carnet) == true)
                                                {
                                                    ingreso.estudianteapp(carnet);
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("No es valida su contraseña o usuario, intentelo de nuevo"); goto InicioEstudiante;
                                                }   
                                                    break;
                                            case false:
                                                Console.Clear();
                                                Console.WriteLine("No es valida su contraseña o usuario, intentelo de nuevo"); goto InicioEstudiante;
                                        }; break;
                                    case false:
                                        Console.Clear();
                                        Console.WriteLine("No es valida su contraseña o usuario, intentelo de nuevo"); goto InicioEstudiante;
                                }

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("No es valida su contraseña o usuario, intentelo de nuevo"); goto InicioEstudiante;
                            }
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Verifique que se hayan llenado correctamente los datos"); goto InicioEstudiante;
                        }
                        break;
                
                
                        // ADMINISTRADOR
                    case 2: Console.Clear();
                        string usaurioADMIN, contraseñaADMIN, codigo;
                        // INGRESO DE DATOS
                        Console.WriteLine("SISTEMA DE ORIENTACIÓN UNIVERSITARIA");
                    InicioAdmin:
                        Console.WriteLine("");
                        Console.WriteLine("USUARIO:");
                        usaurioADMIN = Console.ReadLine();
                        Console.WriteLine("CONTRASEÑA:");
                        contraseñaADMIN = Console.ReadLine();

                        try
                        {
                            // COMPROBACION DE USUARIO, CODIGO Y CONTRASEÑA
                            codigo = usaurioADMIN.Substring(usaurioADMIN.Length - 5);
                            int lenght = usaurioADMIN.Length;
                            string Codigostring = codigo.ToString();
                            int lenght2 = Codigostring.Length;
                            bool usuario = usaurioADMIN.Contains("ADMIN" + codigo);
                            bool contraseña = contraseñaADMIN.Contains("ADM" + codigo);
                            Admin ingreso = new Admin();
                            validacion comprobacion2 = new validacion();
                            if (lenght == 10 && lenght2 == 5)
                            {
                                switch (usuario)
                                {
                                    case true:
                                        switch (contraseña)
                                        {
                                            case true: comprobacion2.val(codigo); 
                                                if (comprobacion2.val(codigo) == true)
                                                {
                                                    ingreso.adminapp(codigo);
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("No es valida su contraseña o usuario, intentelo de nuevo");
                                                    goto InicioAdmin;
                                                }
                                                break;
                                            case false:
                                                Console.Clear();
                                                Console.WriteLine("No es valida su contraseña o usuario, intentelo de nuevo");
                                                goto InicioAdmin;
                                        }; break;
                                    case false:
                                        Console.Clear();
                                        Console.WriteLine("No es valida su contraseña o usuario, intentelo de nuevo");
                                        goto InicioAdmin;

                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("No es valida su contraseña o usuario, intentelo de nuevo");
                                goto InicioAdmin;
                            }
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Verifique que se hayan llenado correctamente los datos");
                            goto InicioAdmin;
                        }
                        ; break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("¿Seguro que desea Salir?");
                        Console.WriteLine("1).  Sí");
                        Console.WriteLine("2).  No");
                        Console.WriteLine("");
                        int exit = Convert.ToInt32(Console.ReadLine());
                        switch (exit)
                        {
                            case 1: Console.Clear();
                                Console.WriteLine("Regrese Pronto!");
                                Console.ReadKey();
                                    ;break;
                            case 2:
                                Console.Clear();
                                goto selección;
                        };break;
                            
                    default: Console.Clear();
                        Console.WriteLine("Por Favor, ingrese un número válido"); goto selección;
                }
            }
            catch
            {
                Console.WriteLine("No ha ingresado los datos correctamente. Por favor intente nuevamente");
                goto selección; 
            }
        }
    }
}
