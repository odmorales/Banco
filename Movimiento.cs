﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Movimiento
    {
        public DateTime Fecha { get; set; }

        public string Tipo { get; set; }

        public decimal Valor { get; set; }

        public decimal Saldo { get; set; }
    }
}
