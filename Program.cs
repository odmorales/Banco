using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuenta cuenta = new CuentaCorriente(100000);

            string mensaje;

            mensaje = cuenta.Consignar(20000);
            Console.WriteLine(mensaje);

            mensaje = cuenta.Retirar(80000);
            Console.WriteLine(mensaje);

            mensaje = cuenta.ConsultarSaldo();
            Console.WriteLine(mensaje);

            cuenta.ConsultarMovimientos();

            Console.ReadKey();
        }
    }
}
