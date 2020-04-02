using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(decimal Saldo): base(Saldo)
        {
            
        }


        decimal cupo = 100000;
        public override string Consignar(decimal valor)
        {

            if (valor > Saldo || valor == 0)
            {
                return $"No se puede consignar";
            }
            else
            {
                Saldo -= valor;
                AgregarMovimientos("Consignar", valor);
                return $"Usted consigno {valor} y su saldo es {Saldo}";
            }
            
            
        }

        public override string Retirar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                if (Saldo < cupo)
                {
                    AgregarMovimientos("Retirar", valor);
                    return $"Usted retiro {valor} y su saldo es {Saldo}";
                }

            }
                Saldo -= valor;
                return $"No se pudo retirar";
            
        }
    }
}
