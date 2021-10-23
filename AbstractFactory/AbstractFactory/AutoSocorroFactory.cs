using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactory
{
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuicho();
        public abstract Veiculo CriarVeiculo(string Modelo, Porte porte);
    }
}
