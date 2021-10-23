using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculoSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Celta", Porte.Pequeno),
                VeiculoCreator.Criar("Jetta", Porte.Medio),
                VeiculoCreator.Criar("BMW X6", Porte.Grande)
            };

            veiculoSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
            Console.ReadLine();
        }
    }
}
