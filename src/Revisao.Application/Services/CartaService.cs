using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;

namespace Revisao.Application.Services
{
    public class CartaService : ICartaService
    {
        private readonly ICartasRepository _cartaRepository;
        private IMapper _mapper;
        public CartaService(ICartasRepository cartasRepository, IMapper mapper)
        {
            _cartaRepository = cartasRepository;
            _mapper = mapper;
        }


        public void AdicionarCartas(NovaCartaViewModel novaCartaViewModel)
        {
            var novaCarta = _mapper.Map<Cartas>(novaCartaViewModel);
            _cartaRepository.AdicionarCartas(novaCarta);
        }

        

        public IEnumerable<CartasViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<CartasViewModel>>(_cartaRepository.ObterTodos());
        }
    }
}

