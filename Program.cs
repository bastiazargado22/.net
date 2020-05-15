using System;

namespace Principio
{
    class Program
    {
        private static int sesion;

        static void Main(string[] args)
        {

            const string usuario = "admin";
            const string contraseña = "abc123";
            Console.WriteLine("Introduce Usuario: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce contraseña: ");
            string codigo = Console.ReadLine();
            int cotinue = 0;
            while (nombre != usuario || codigo != contraseña)
            {

                cotinue++;
                if (nombre != usuario || codigo != contraseña)
                {
                    Console.WriteLine("Usuario o contraseña incorrecto. Intente de nuevo.");
                    Console.WriteLine("Introduce Usuario: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Introduce contraseña: ");
                    codigo = Console.ReadLine();

                }
                else;

            }


            do
            {

                object[,] Informacion = Lista();
                static object[,] Lista()
                {
                    Console.WriteLine("Cuanto vehiculos desea almacenar?: ");
                    string respuesta = Console.ReadLine();
                    int CVehiculos = int.Parse(respuesta);
                    object[,] datos = new object[CVehiculos, 15];
                    for (int i = 0; i < CVehiculos; i++)
                    {
                        Automovil auto;
                        auto = new Automovil();
                        datos[i, 0] = auto.Estadocomponente(0) + "% " + "completado.";
                        Console.WriteLine("Marca del Vehiculo: ");
                        string marca = Console.ReadLine();
                        datos[i, 1] = auto.Marca(marca);
                        Console.WriteLine("------------------");
                        Console.WriteLine("Año del Vehiculo: ");
                        int ano = int.Parse(Console.ReadLine());
                        datos[i, 2] = auto.Ano(ano);
                        Console.WriteLine("------------------");
                        Console.WriteLine("Kiometraje del vehiculo: ");
                        int kilometraje = int.Parse(Console.ReadLine());
                        datos[i, 3] = auto.Kilometraje(kilometraje);
                        Estanque estanque;
                        estanque = new Estanque();
                        datos[i, 4] = estanque.Estadocomponente(25) + "% " + "completado.";
                        Console.WriteLine("------------------");
                        Console.WriteLine("Capacidad del estanque del vehiculo: ");
                        int capac = int.Parse(Console.ReadLine());
                        datos[i, 5] = estanque.Cantidad(capac);
                        Console.WriteLine("------------------");
                        Console.WriteLine("Cantidad actual del combustible: ");
                        int cantidad = int.Parse(Console.ReadLine());
                        datos[i, 6] = estanque.Capacidad(cantidad);
                        Console.WriteLine("------------------");
                        Mezclador mesclador;
                        mesclador = new Mezclador();
                        datos[i, 7] = mesclador.Estadocomponente(50) + "% " + "completado.";
                        Console.WriteLine("Indique que tipo de mezclador es: 1)Carburador 2)Inyector");
                        int mezclador = int.Parse(Console.ReadLine());
                        datos[i, 8] = mesclador.Mezcla(mezclador);
                        Console.WriteLine("-------------------");
                        Rueda rueda;
                        rueda = new Rueda();
                        datos[i, 9] = rueda.Estadocomponente(75) + "% " + "completado.";
                        Console.WriteLine("Indica el tipo de recubrimiento: 1)Fenol 2)Hule 3)Poliuretano");
                        int recubrimiento = int.Parse(Console.ReadLine());
                        datos[i, 10] = rueda.Recubrimiento(recubrimiento);
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Indique el valor de dureza de la rueda:\n" +
                        "el primer numero no debe ser mayor al segundo. ejemplo(100)y(180).");
                        Console.WriteLine("primer valor:");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine("segundo valor:");
                        int num1 = int.Parse(Console.ReadLine());
                        datos[i, 11] = rueda.Durometro(num, num1);
                        Console.WriteLine("-------------------");
                        Motor motor;
                        motor = new Motor();
                        Console.WriteLine("Ingrese el numero ID del vehiculo:");
                        int id = int.Parse(Console.ReadLine());
                        datos[i, 12] = motor.Id(id);
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Indique que tipo de motor tiene el vehiculo: 1)Dos-tiempos 2)Cuatro-tiempos");
                        int tipo = int.Parse(Console.ReadLine());
                        datos[i, 13] = motor.Tipo(tipo);
                        Console.WriteLine("-------------------");
                        datos[i, 14] = motor.Estadocomponente(100) + "% " + "completado.";
                        Console.WriteLine("Datos guardados con exito!.");
                        Console.WriteLine("-------------------");
                        Console.WriteLine($"Se encuentran un total de {i + 1}" + " Vehiculos." +
                            " Almacenados \n");
                    }
                    return datos;
                }

                Console.WriteLine("Desea ver la informacion del vehiculo. 1)si 2)no");
                int respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    Console.WriteLine("informacion del Vehiculo: " + "\n");

                    /*for (int i = 0; i < Informacion.Length-1; i++)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine(">" + Informacion[i, 0]);
                        Console.WriteLine(">" + Informacion[i, 1]);
                        Console.WriteLine(">" + Informacion[i, 2]);
                        Console.WriteLine(">" + Informacion[i, 3]);
                        Console.WriteLine(">" + Informacion[i, 4]);
                        Console.WriteLine(">" + Informacion[i, 5]);
                        Console.WriteLine(">" + Informacion[i, 6]);
                        Console.WriteLine(">" + Informacion[i, 7]);
                        Console.WriteLine(">" + Informacion[i, 8]);
                        Console.WriteLine(">" + Informacion[i, 9]);
                        Console.WriteLine(">" + Informacion[i, 10]);
                        Console.WriteLine(">" + Informacion[i, 11]);
                        Console.WriteLine(">" + Informacion[i, 12]);
                        Console.WriteLine(">" + Informacion[i, 13]);
                        Console.WriteLine(">" + Informacion[i, 14]);
                    }*/

                    foreach (object i in Informacion)
                    {
                        Console.WriteLine("------------------------");
                        Console.WriteLine("> " + i);


                    }
                }
                else
                {

                }
                Console.WriteLine("-----------------------");
                Console.WriteLine("Desea cerrar sesion: marque 1)si 2)no");
                int sesion = int.Parse(Console.ReadLine());
                if (sesion == 1)
                {
                    Console.WriteLine("Programa finalizado");
                    break;
                }
                else;

            } while (sesion != 1);

        }
    }
}

