using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao.Application.ViewModels;

namespace Revisao.Application.Interfaces
{
    public interface ICartaService
    {

        IEnumerable<CartasViewModel> ObterTodos();
        void AdicionarCartas(NovaCartaViewModel carta);
    }
}
