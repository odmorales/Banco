using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public  abstract class Cuenta
    {

        private List<Movimiento> Movimientos { get; set; }
        public decimal Saldo { get; set; }

        public Cuenta(decimal valor)
        {
            Saldo = valor;
            Movimientos = new List<Movimiento>();
        }

        public abstract string Consignar(decimal valor);

        public abstract string Retirar(decimal valor);

        public string ConsultarSaldo()
        {
            return $"Su saldo es {Saldo}";
        }

        public void AgregarMovimientos(string tipo, decimal valor)
        {
            Movimiento movimiento = new Movimiento();

            movimiento.Fecha = DateTime.Now;
            movimiento.Tipo = tipo;
            movimiento.Valor = valor;
            movimiento.Saldo = Saldo;

            Movimientos.Add(movimiento);
            
        }
        public void ConsultarMovimientos()
        {
            foreach (var m in Movimientos)
            {
                Console.WriteLine($"Fecha: {m.Fecha} Tipo: {m.Tipo} Valor: {m.Valor}" +
                    $" Saldo: {m.Saldo}");
            }
        }
    }
}
