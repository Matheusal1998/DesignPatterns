using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactory
{
    public class SocorroVeiculoPequenoFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuicho()
        {
            return GuinchoCreator.Criar(Porte.Pequeno);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
