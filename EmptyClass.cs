using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Principio
{
    abstract class Vehiculo : VehiculoComponente
    {


    }
    abstract class VehiculoComponente
    {
        public abstract int Estadocomponente(int a);


    }
    class Automovil : Vehiculo
    {
        public override int Estadocomponente(int a)
        {
            return 0;
        }
        public string Marca(string marca)
        {

            return "La marca del vehiculo es " + marca;
        }
        public string Ano(int ano)
        {
            return "El año del vehiculo es " + ano;
        }
        public string Kilometraje(int kilometraje)
        {
            return "El kilometraje del vehiculo es " + kilometraje + " KMs.";
        }

    }
    class Estanque : VehiculoComponente
    {


        public override int Estadocomponente(int a)
        {
            return 25;
        }

        public string Capacidad(int capac)
        {
            return "La capacidad del vehiculo es " + capac + " Litros.";
        }
        private int capac;
        public string Cantidad(int cantidad)
        {


            if (cantidad >= (capac / 10))
            {

                return $"El estanque tiene media capacidad {true}";
            }
            else
                return $"El estanque tiene una capacidad baja {false}";
        }
    }
    class Mezclador : VehiculoComponente
    {
        public override int Estadocomponente(int a)
        {
            return 50;
        }

        public string Mezcla(int mezclador)
        {
            if (mezclador == 1)
            {
                return "El tipo de mezclador del vehiculo es Carburador";
            }
            else
                return "El tipo de mezclador del vehiculo es Inyector";

        }
    }
    class Rueda : VehiculoComponente
    {
        public override int Estadocomponente(int a)
        {
            return 75;
        }
        public string Recubrimiento(int recubrimiento)
        {
            if (recubrimiento == 1)
            {
                return "El recubrimiento del vehiculo es Fenol";
            }
            else if (recubrimiento == 2)
            {
                return "El recubrimiento del vehiculo es Hule";
            }
            else
                return "El recubrimiento del vehiculo es Poliuretano";
        }
        public string Durometro(int num, int num1)
        {

            return $"El indice del durometro es ({num},{num1})";
        }
    }
    class Motor : VehiculoComponente
    {
        public override int Estadocomponente(int a)
        {
            return 100;
        }
        public string Id(int id)
        {
            return "El numero ID del vahiculo es " + id;
        }
        public string Tipo(int tipo)
        {
            if (tipo == 1)
            {
                return "El vehiculo posee un vehiculo de Dos-tiempos";
            }
            else
                return "El vehiculo posee un motor de Cuatro-tiempos";
        }

    }
}