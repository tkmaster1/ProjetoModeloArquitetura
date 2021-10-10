using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloArquitetura.Core.IoC
{
    public class BootStrapper
    {
        public static void Register()
        {
            // Lifestyle.Transient => Uma instância para cada solicitação
            // Lifestyle.Singleton => Uma instância única para a classe (para servidor)
            // Lifestyle.Scoped => Uma instância única para o request

            #region Domain

            #endregion

            #region InfraData

            #endregion
        }
    }
}
