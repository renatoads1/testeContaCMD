using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    public interface IConta
    {
         int Id { get; set; }
         string NumeroConta { get; set; }
         string Agencia { get; set; }
         string TipoConta { get; set; }
         decimal Saldo { get; set; }
    }
}
