using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    public interface IContaService
    {
        void CriarConta(IPessoa pessoa, IConta conta);
    }
}
