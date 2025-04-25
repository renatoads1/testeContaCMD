using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    public class Conta : IConta
    {
        public int Id { get; set; }
        public string NumeroConta { get; set; }
        public string Agencia { get; set; }
        public string TipoConta { get; set; }
        public decimal Saldo { get; set; }
        
    }
}
