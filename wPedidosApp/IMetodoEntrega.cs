using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wPedidosApp
{
    public interface IMetodoEntrega
    {
        double CalcularCosto(int km);
        string TipoEntrega();
    }
}
