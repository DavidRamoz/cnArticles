using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///<summary>
/// Date: Sunday february 26
/// Name: Oscar David Ramoz Calzada 
/// Description: Aplicacion de artículos con clase abstracta 
/// </summary>

namespace cnArticle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsType4 art = new clsType4("Marcador", 3200);
            art.name();
            Console.WriteLine("El articulo es tipo: {0}", art.TYPE);
            Console.WriteLine("Nombre: {0}", art.Name);
            Console.WriteLine("Precio: {0}", art.Price);
            Console.WriteLine("Iva: {0}", art.IVAPart());

            Console.WriteLine();

            clsType7 at = new clsType7("Block iris", 5350);
            at.name();
            Console.WriteLine("El articulo es tipo: {0}", at.TYPE);
            Console.WriteLine("Nombre: {0}", at.Name);
            Console.WriteLine("Precio: {0}", at.Price);
            Console.WriteLine("Iva: {0}", at.IVAPart());

            Console.WriteLine();

            clsType17 tlo = new clsType17("Bisturi", 4800);
            tlo.name();
            Console.WriteLine("El articulo es tipo: {0}", at.TYPE);
            Console.WriteLine("Nombre: {0}", at.Name);
            Console.WriteLine("Precio: {0}", at.Price);
            Console.WriteLine("Iva: {0}", at.IVAPart());
            Console.WriteLine();

            Console.WriteLine("presione <enter> para terminar.");

            Console.ReadKey();
        }
    }
}
