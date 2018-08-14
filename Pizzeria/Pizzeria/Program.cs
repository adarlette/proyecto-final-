using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;


namespace Pizzeria
{

    //Nombre Adarlette Catano
    //Matricula 17-miin-1-014
    ////Seccion O463
    class Program

    {
        [DllImport("kernel32.dll", ExactSpelling = true)]

        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

        static void Main(string[] args)
        {
            //Abrir pantalla completa
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            //Variables
            int extra = 0, menoptions = 0, tamanooptions = 0, ingroptions = 0, answer, pequena = 82, mediana = 113, grande = 201;
            double costoadicional , subtotal, totalpagar;

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            ShowWindow(ThisConsole, MAXIMIZE);
            Console.Clear();
            do
            {
                //Titulo del Programa
                Console.WriteLine("Adarlette Catano, 17-miin-1-014, O463 ");
                Console.WriteLine("\n\n----------PIZZERIA---------");

                //Inician las opciones del menu
                Console.WriteLine("---Menu de Opciones---\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1-Pedido\t");
                Console.Write("2-Salir\t\n"); ;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Digite una Opcion:  ");
                menoptions = Convert.ToInt32(Console.ReadLine());
                if (menoptions == 1)
                {
                    do
                    {
                        Console.WriteLine("----Seleccione el Pedido----");
                        Console.WriteLine("Tamaño de la Pizza\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("1-Pequeña\t");
                        Console.Write("2-Mediana\t");
                        Console.WriteLine("3-Grande\t");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Digite una Opcion:  ");
                        tamanooptions = Convert.ToInt32(Console.ReadLine());

                        if (tamanooptions == 1)
                        {
                          
                            tamanooptions = pequena;


                        } else if (tamanooptions == 2)
                        {
                       
                            tamanooptions = mediana;
                        }
                        else if (tamanooptions == 3)
                        {
                          
                            tamanooptions = grande;
                        } else
                        {
                            Console.Clear();
                            Console.WriteLine("Favor selecciones una Opcion Valida");

                        }

                    } while (tamanooptions == 1 || tamanooptions == 2 || tamanooptions == 3);
                  
                    subtotal = tamanooptions * 1.5;
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Precio de Venta: RD$" + subtotal);
                    Console.WriteLine("---------------------------------\n");

                    Console.WriteLine("----Desea Ingredientes adicionales----\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("1-SI\t");
                    Console.WriteLine("2-NO\t");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Digite una Opcion:  ");
                    answer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("---------------------------------\n");

                    if (answer == 1)
                    {
                        Console.WriteLine("----Favor Seleccionar los Ingredientes Adicionales----\n\n");
                        Console.Write("1-Pepinillos\t");
                        Console.Write("2-Chanpiñones\t");
                        Console.Write("3-Cebolla\t");
                        Console.WriteLine("4-Si desea todos los ingredientes\t");
                        Console.Write("Seleccion:  ");
                        ingroptions = Convert.ToInt32(Console.ReadLine());

                        switch (ingroptions)
                        {
                            case 1:
                                Console.WriteLine("A seleccionado Pepinillos");

                                //Calculo del precio de venta de la Pizza
                                extra = 1;
                                costoadicional = extra * 50;
                                totalpagar = subtotal + costoadicional;
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                Console.WriteLine("---------------------------------\n");

                                Console.WriteLine("----Desea Ingredientes adicionales----\n");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("1-SI\t");
                                Console.WriteLine("2-NO\t");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Digite una Opcion:  ");
                                answer = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("---------------------------------\n");
                                if (answer == 1)
                                {
                                    Console.WriteLine("----Favor Seleccionar los Ingredientes Adicionales----\n\n");
                                    Console.Write("1-Chanpiñones\t");
                                    Console.Write("2-Cebolla\t");
                                    ingroptions = Convert.ToInt32(Console.ReadLine());
                                    switch (ingroptions)
                                    {
                                        case 1:
                                            Console.WriteLine("A seleccionado Chanpiñones");

                                            //Calculo del precio de venta de la Pizza
                                            extra = 2;
                                            costoadicional = extra * 50;
                                            totalpagar = subtotal + costoadicional;
                                            Console.WriteLine("---------------------------------");
                                            Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                            Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                            Console.WriteLine("---------------------------------\n");
                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            Console.WriteLine("A seleccionado Cebolla");

                                            //Calculo del precio de venta de la Pizza
                                            extra = 2;
                                            costoadicional = extra * 50;
                                            totalpagar = subtotal + costoadicional;
                                            Console.WriteLine("---------------------------------");
                                            Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                            Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                            Console.WriteLine("---------------------------------\n");
                                            Console.ReadKey();


                                            break;



                                    }

                                }
                                else
                                {
                                    extra = 1;
                                    costoadicional = extra * 50;
                                    totalpagar = subtotal + costoadicional;
                                    Console.WriteLine("---------------------------------");
                                    Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                    Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                    Console.WriteLine("---------------------------------\n");


                                }
                                break;

                            case 2:
                                Console.WriteLine("A seleccionado Chanpiñones");

                                //Calculo del precio de venta de la Pizza
                                extra = 1;
                                costoadicional = extra * 50;
                                totalpagar = subtotal + costoadicional;
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                Console.WriteLine("---------------------------------\n");

                                Console.WriteLine("----Desea Ingredientes adicionales----\n");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("1-SI\t");
                                Console.WriteLine("2-NO\t");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Digite una Opcion:  ");
                                answer = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("---------------------------------\n");
                                if (answer == 1)
                                {
                                    Console.WriteLine("----Favor Seleccionar los Ingredientes Adicionales----\n\n");
                                    Console.Write("1-Pepinillos\t");
                                    Console.Write("2-Cebolla\t");
                                    ingroptions = Convert.ToInt32(Console.ReadLine());
                                    switch (ingroptions)
                                    {
                                        case 1:
                                            Console.WriteLine("A seleccionado Pepinillos");

                                            //Calculo del precio de venta de la Pizza
                                            extra = 2;
                                            costoadicional = extra * 50;
                                            totalpagar = subtotal + costoadicional;
                                            Console.WriteLine("---------------------------------");
                                            Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                            Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                            Console.WriteLine("---------------------------------\n");
                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            Console.WriteLine("A seleccionado Cebolla");

                                            //Calculo del precio de venta de la Pizza
                                            extra = 2;
                                            costoadicional = extra * 50;
                                            totalpagar = subtotal + costoadicional;
                                            Console.WriteLine("---------------------------------");
                                            Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                            Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                            Console.WriteLine("---------------------------------\n");
                                            Console.ReadKey();
                                            break;

                                    }

                                }
                                else
                                {
                                    //Calculo del precio de venta de la Pizza
                                    extra = 1;
                                    costoadicional = extra * 50;
                                    totalpagar = subtotal + costoadicional;
                                    Console.WriteLine("---------------------------------");
                                    Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                    Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                    Console.WriteLine("---------------------------------\n");


                                }
                                break;
                            case 3:
                                Console.WriteLine("A seleccionado Cebolla");

                                //Calculo del precio de venta de la Pizza
                                extra = 1;
                                costoadicional = extra * 50;
                                totalpagar = subtotal + costoadicional;
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                Console.WriteLine("---------------------------------\n");
                                Console.ReadKey();


                                Console.WriteLine("----Desea Ingredientes adicionales----\n");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("1-SI\t");
                                Console.WriteLine("2-NO\t");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Digite una Opcion:  ");
                                answer = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("---------------------------------\n");
                                if (answer == 1)
                                {
                                    Console.WriteLine("----Favor Seleccionar los Ingredientes Adicionales----\n\n");
                                    Console.Write("1-Pepinillos\t");
                                    Console.Write("2-Chanpiñones\t");
                                    ingroptions = Convert.ToInt32(Console.ReadLine());
                                    switch (ingroptions)
                                    {
                                        case 1:
                                            Console.WriteLine("A seleccionado Pepinillos");

                                            //Calculo del precio de venta de la Pizza
                                            extra = 2;
                                            costoadicional = extra * 50;
                                            totalpagar = subtotal + costoadicional;
                                            Console.WriteLine("---------------------------------");
                                            Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                            Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                            Console.WriteLine("---------------------------------\n");
                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            Console.WriteLine("A seleccionado Chanpiñones");

                                            //Calculo del precio de venta de la Pizza
                                            extra = 2;
                                            costoadicional = extra * 50;
                                            totalpagar = subtotal + costoadicional;
                                            Console.WriteLine("---------------------------------");
                                            Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                            Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                            Console.WriteLine("---------------------------------\n");
                                            Console.ReadKey();
                                            break;

                                    }

                                }
                                else
                                {
                                    //Calculo del precio de venta de la Pizza
                                    extra = 1;
                                    costoadicional = extra * 50;
                                    totalpagar = subtotal + costoadicional;
                                    Console.WriteLine("---------------------------------");
                                    Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                    Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                    Console.WriteLine("---------------------------------\n");


                                }

                                break;
                            case 4:

                                Console.WriteLine("A seleccionado Todos los Ingredientes Adicionales");
                                Console.WriteLine("Pepinillos");
                                Console.WriteLine("Chanpiñones");
                                Console.WriteLine("Cebolla");
                                Console.WriteLine("---------------------------------------");
                                //Calculo del precio de venta de la Pizza
                                extra = 3;
                                costoadicional = extra * 50;
                                totalpagar = subtotal + costoadicional;
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                                Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                                Console.WriteLine("---------------------------------\n");
                                Console.ReadKey();

                                break;

                        }
                    }
                    else if (answer == 2)
                    {
                        Console.WriteLine("Una pizza sencilla (con sólo salsa y carne) ");
                        Console.WriteLine("Sin ningun extra");

                        //Calculo del precio de venta de la Pizza
                        extra = 0;
                        costoadicional = extra * 50;
                        totalpagar = subtotal + costoadicional;
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Cantidad de Ingredientes Extras: " + extra);
                        Console.WriteLine("Precio de Venta: RD$" + totalpagar);
                        Console.WriteLine("---------------------------------\n");
                        Console.ReadKey();


                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("La Opcion que a Digitado es Incorrecta favor repita");
                        menoptions = 3;

                    }
                }
                else if (menoptions == 2)
                {
                    menoptions = 4;
                   
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("La Opcion que a Digitado es Incorrecta favor repita");
                    menoptions = 3;

                }
           

            } while (menoptions == 3 );

        }

        }
    }
