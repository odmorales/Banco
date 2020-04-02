using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaAhorro: Cuenta
    {
        public CuentaAhorro(decimal saldo) : base(saldo)
        {

        }

        public override string Consignar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                AgregarMovimientos("Consignar", valor);
                return $"se consigno {valor} su nuevo saldo es {Saldo}";
            }


            return $"No es posible consignar. Su saldo es {Saldo}";

        }

        public override string Retirar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                AgregarMovimientos("Retirar", valor);
                return $"se retiro {valor} su nuevo saldo es {Saldo}";
            }


            return $"saldo insuficiente. Su saldo es {Saldo}";

        }
    }
}
