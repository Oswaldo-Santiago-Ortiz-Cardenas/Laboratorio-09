using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_09
{
    class producto
    {
        public int vendido { get; set; }
        public int devuelto { get; set; }
        public int inventario { get; set; }
        public double caja { get; set; }
    }
    internal class Program
    {
        static producto[] productos = new producto[4];
        static void Main(string[] args)
        {
            for (int i = 0; i < productos.Length; i++)
            {
                productos[i] = new producto();
            }
            int opcion = 0;
            do
            {
                opcion = pantallaprincipal();
                switch (opcion)
                {
                    case 1:
                        pantallaregistro();
                        break;
                    case 2:
                        pantalladevolucion();
                        break;
                    case 3:
                        cajatotal();
                        Console.ReadKey();
                        break;
                }
            } while (opcion!= 4);
        }
        static int pantallaprincipal()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Tienda de Don Lucas");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar venta");
            Console.WriteLine("2: Registrar devolución");
            Console.WriteLine("3: Cerrar Caja");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            String opciontext = Console.ReadLine();
            int opcion = int.Parse(opciontext);
            Console.Clear();
            return opcion;
        }
        static void pantallaregistro()
        {
            Console.Clear();
            int opcion = 0;
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Venta de:");
            Console.WriteLine("================================");
            Console.WriteLine("1: Limpieza");
            Console.WriteLine("2: Abarrotes");
            Console.WriteLine("3: Golosinas");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    registro1();
                    break;
                case 2:
                    registro2();
                    break;
                case 3:
                    registro3();
                    break;
                case 4:
                    registro4();
                    break;
            }
        }
        static void pantalladevolucion()
        {
            Console.Clear();
            int opcion = 0;
            Console.WriteLine("================================");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("================================");
            Console.WriteLine("1: Limpieza");
            Console.WriteLine("2: Abarrotes");
            Console.WriteLine("3: Golosinas");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    devolucion1();
                    break;
                case 2:
                    devolucion2();
                    break;
                case 3:
                    devolucion3();
                    break;
                case 4:
                    devolucion4();
                    break;
            }
        }
        static void registro1()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de Limpieza");
            Console.WriteLine("================================");
            Console.Write("Ingrese cantidad (unidades): ");
            int unidades = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/ ");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            float ptotal = precio * unidades;
            productos[0].vendido += unidades;
            productos[0].caja += ptotal;
            Console.WriteLine($"Se han ingresado {unidades} unidades");
            Console.WriteLine($"Se han ingresado S/ {ptotal.ToString("0.00")} en caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar más productos de limpieza");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    registro1();
                    break;
                case 2:
                    pantallaregistro();
                    break;
            }
        }
        static void registro2()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de Abarrotes");
            Console.WriteLine("================================");
            Console.Write("Ingrese cantidad (unidades): ");
            int unidades = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/ ");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            float ptotal = precio * unidades;
            productos[1].vendido += unidades;
            productos[1].caja += ptotal;
            Console.WriteLine($"Se han ingresado {unidades} unidades");
            Console.WriteLine($"Se han ingresado S/ {ptotal.ToString("0.00")} en caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar más productos de abarrotes");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    registro2();
                    break;
                case 2:
                    pantallaregistro();
                    break;
            }
        }
        static void registro3()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de Golosinas");
            Console.WriteLine("================================");
            Console.Write("Ingrese cantidad (unidades): ");
            int unidades = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/ ");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            float ptotal = precio * unidades;
            productos[2].vendido += unidades;
            productos[2].caja += ptotal;
            Console.WriteLine($"Se han ingresado {unidades} unidades");
            Console.WriteLine($"Se han ingresado S/ {ptotal.ToString("0.00")} en caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar más golosinas");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    registro3();
                    break;
                case 2:
                    pantallaregistro();
                    break;
            }
        }
        static void registro4()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de Electrónicos");
            Console.WriteLine("================================");
            Console.Write("Ingrese cantidad (unidades): ");
            int unidades = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/ ");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            float ptotal = precio * unidades;
            productos[3].vendido += unidades;
            productos[3].caja += ptotal;
            Console.WriteLine($"Se han ingresado {unidades} unidades");
            Console.WriteLine($"Se han ingresado S/ {ptotal.ToString("0.00")} en caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar más productos electrónicos");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    registro4();
                    break;
                case 2:
                    pantallaregistro();
                    break;
            }
        }
        static void devolucion1()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar devolución de Limpieza");
            Console.WriteLine("================================");
            Console.Write("Ingrese cantidad (unidades): ");
            int unidades = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/ ");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            if (unidades > 0 && unidades <= productos[0].vendido)
            {
                double precioUnitario = productos[0].caja / productos[0].vendido;
                double totalDevolucion = unidades * precioUnitario;
                productos[0].vendido = productos[0].vendido + productos[0].devuelto;
                productos[0].devuelto += unidades;
                productos[0].inventario = productos[0].vendido - productos[0].devuelto;
                productos[0].caja -= totalDevolucion;
            }
                float ptotal = precio * unidades;
            Console.WriteLine($"Se han regresado {unidades} unidades");
            Console.WriteLine($"Se han devuelto S/ {ptotal.ToString("0.00")} de caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Devolver más productos de limpieza");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    devolucion1();
                    break;
                case 2:
                    pantalladevolucion();
                    break;
            }
        }
        static void devolucion2()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar devolución de Abarrotes");
            Console.WriteLine("================================");
            Console.Write("Ingrese cantidad (unidades): ");
            int unidades = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/ ");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            if (unidades > 0 && unidades <= productos[1].vendido)
            {
                double precioUnitario = productos[1].caja / productos[1].vendido;
                double totalDevolucion = unidades * precioUnitario;
                productos[1].vendido = productos[1].vendido + productos[1].devuelto;
                productos[1].devuelto += unidades;
                productos[1].inventario = productos[1].vendido - productos[1].devuelto;
                productos[1].caja -= totalDevolucion;
            }
            float ptotal = precio * unidades;
            Console.WriteLine($"Se han regresado {unidades} unidades");
            Console.WriteLine($"Se han devuelto S/ {ptotal.ToString("0.00")} de caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Devolver más productos de abarrotes");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    devolucion2();
                    break;
                case 2:
                    pantalladevolucion();
                    break;
            }
        }
        static void devolucion3()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar devolución de Golosinas");
            Console.WriteLine("================================");
            Console.Write("Ingrese cantidad (unidades): ");
            int unidades = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/ ");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            if (unidades > 0 && unidades <= productos[2].vendido)
            {
                double precioUnitario = productos[2].caja / productos[2].vendido;
                double totalDevolucion = unidades * precioUnitario;
                productos[2].vendido = productos[2].vendido + productos[2].devuelto;
                productos[2].devuelto += unidades;
                productos[2].inventario = productos[2].vendido - productos[2].devuelto;
                productos[2].caja -= totalDevolucion;
            }
            float ptotal = precio * unidades;
            Console.WriteLine($"Se han regresado {unidades} unidades");
            Console.WriteLine($"Se han devuelto S/ {ptotal.ToString("0.00")} de caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Devolver más golosinas");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    devolucion3();
                    break;
                case 2:
                    pantalladevolucion();
                    break;
            }
        }
        static void devolucion4()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar devolución de Electrónicos");
            Console.WriteLine("================================");
            Console.Write("Ingrese cantidad (unidades): ");
            int unidades = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/ ");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            if (unidades > 0 && unidades <= productos[3].vendido)
            {
                double precioUnitario = productos[3].caja / productos[3].vendido;
                double totalDevolucion = unidades * precioUnitario;
                productos[3].vendido = productos[3].vendido + productos[3].devuelto;
                productos[3].devuelto += unidades;
                productos[3].inventario = productos[3].vendido - productos[3].devuelto;
                productos[3].caja -= totalDevolucion;
            }
            float ptotal = precio * unidades;
            Console.WriteLine($"Se han regresado {unidades} unidades");
            Console.WriteLine($"Se han devuelto S/ {ptotal.ToString("0.00")} de caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Devolver más productos de electrónicos");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    devolucion4();
                    break;
                case 2:
                    pantalladevolucion();
                    break;
            }
        }
        static void cajatotal()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Tienda de Don Lucas");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar venta");
            Console.WriteLine("2: Registrar devolución");
            Console.WriteLine("3: Cerrar Caja");
            Console.WriteLine("================================");
            Console.WriteLine("Cerrando Caja");
            Console.WriteLine("================================");
            Console.WriteLine("Totales");
            Console.WriteLine("================================");
            for (int i = 0; i < productos.Length; i++)
            {
                string nameprod = "";
                switch (i)
                {
                    case 0:
                        nameprod = "Limpieza";
                        break;
                    case 1:
                        nameprod = "Abarrotes";
                        break;
                    case 2:
                        nameprod = "Golosinas";
                        break;
                    case 3:
                        nameprod = "Electro";
                        break;
                }

                Console.WriteLine($"                        | {"     " + productos[i].vendido}"+ " vendidos");
                Console.WriteLine($"{nameprod,-20}    | {"     " + productos[i].devuelto}"+ " devueltos");
                Console.WriteLine($"                        | {"     " + productos[i].inventario}"+ " en total");
                Console.WriteLine($"                        | {"S/ " + productos[i].caja.ToString("0.00")} en caja");
                Console.WriteLine("================================");
            }

            double cajaGeneral = productos.Sum(p => p.caja);

            Console.WriteLine($"{"Queda en caja S/ " + cajaGeneral.ToString("0.00"),-20}");
        }
    
    }
}