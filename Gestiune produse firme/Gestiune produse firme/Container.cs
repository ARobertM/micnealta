using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_produse_firme
{
    public class Container
    {
        List<Prod> listaProduse;

        internal List<Prod> ListaProduse { get => listaProduse; set => listaProduse = value; }
    }
}
